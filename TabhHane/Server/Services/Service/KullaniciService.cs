using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TabhHane.Server.Data.Context;
using TabhHane.Server.Data.Models;
using TabhHane.Server.Services.Interface;
using TabhHane.Shared.DTO;

namespace TabhHane.Server.Services.Service
{
    public class KullaniciService : IKullaniciService
    {
        private readonly IMapper mapper;
        private readonly TabhHaneContext context;
        private readonly IConfiguration configuration;
        public KullaniciService(IMapper Mapper,TabhHaneContext Context, IConfiguration Configuration)
        {
            mapper = Mapper;
            context = Context;
            configuration = Configuration;
        }
        public async Task<KullaniciDTO> CreateKullanici(KullaniciDTO kullanici)
        {
            var dbUser = await context.Kullanicilar.Where(c => c.Id == kullanici.Id).FirstOrDefaultAsync();
            if (dbUser == null)
                throw new Exception("İlgili Kayıt Zaten Mevcut");
            dbUser = mapper.Map<Kullanici>(kullanici);
            context.Kullanicilar.AddAsync(dbUser);
            int result = await context.SaveChangesAsync();
            return mapper.Map<KullaniciDTO>(dbUser);
        }

        public async Task<bool> DeleteUserById(int id)
        {
            var dbUser= await context.Kullanicilar.Where(c=>c.Id==id).FirstOrDefaultAsync();
            if (dbUser==null)
                throw new Exception("Kullanici Bulunamadi");

            context.Kullanicilar.Remove(dbUser);
            int result = await context.SaveChangesAsync();
            return result > 0;
        }

        public async Task<KullaniciDTO> GetKullaniciById(int id)
        {
            return await context.Kullanicilar.Where(c=>c.Id==id).ProjectTo<KullaniciDTO>(mapper.ConfigurationProvider).FirstOrDefaultAsync();
        }

        public async Task<List<KullaniciDTO>> GetKullanicis()
        {
            return await context.Kullanicilar.ProjectTo<KullaniciDTO>(mapper.ConfigurationProvider).ToListAsync();
        }

        public async Task<KullaniciLoginResponseDTO> Login(string kullaniciAdi, string parola)
        {
            // Veritabanı Kullanıcı Doğrulama İşlemleri Yapıldı.;

            var dbUser = await context.Kullanicilar.FirstOrDefaultAsync(i => i.KullaniciAdi == kullaniciAdi && i.Parola == parola);

            if (dbUser == null)
                throw new Exception("User not found or given information is wrong");


            KullaniciLoginResponseDTO result = new KullaniciLoginResponseDTO();

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JwtSecurityKey"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expiry = DateTime.Now.AddDays(1);

            var claims = new[]
            {
                new Claim(ClaimTypes.Email, kullaniciAdi),
                new Claim(ClaimTypes.Name,dbUser.Adi+" "+dbUser.Soyadi),
                new Claim(ClaimTypes.UserData, dbUser.Id.ToString())
            };

            var token = new JwtSecurityToken(configuration["JwtIssuer"], configuration["JwtAudience"], claims, null, expiry, creds);

            result.ApiToken = new JwtSecurityTokenHandler().WriteToken(token);
            result.Kullanici = mapper.Map<KullaniciDTO>(dbUser);

            return result;
        }

        public async Task<KullaniciDTO> UpdateKullanici(KullaniciDTO kullanici)
        {
            var dbUser = await context.Kullanicilar.Where(c => c.Id == kullanici.Id).FirstOrDefaultAsync();
            if (dbUser == null)
                throw new Exception("İlgili Kayıt Bulunamadı");
            dbUser = mapper.Map<Kullanici>(kullanici);

            mapper.Map(kullanici,dbUser);
            int result = await context.SaveChangesAsync();
            return mapper.Map<KullaniciDTO>(dbUser);
        }
    }
}

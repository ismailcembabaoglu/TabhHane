using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
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

        public KullaniciService(IMapper Mapper,TabhHaneContext Context)
        {
            mapper = Mapper;
            context = Context;
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

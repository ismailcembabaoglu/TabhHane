using TabhHane.Shared.DTO;

namespace TabhHane.Server.Services.Interface
{
    public interface IKullaniciService
    {
        public Task<KullaniciDTO> GetKullaniciById(int id);
        public Task<List< KullaniciDTO>> GetKullanicis();
        public Task<KullaniciDTO> CreateKullanici(KullaniciDTO kullanici);
        public Task<KullaniciDTO> UpdateKullanici(KullaniciDTO kullanici);
        public Task<bool> DeleteUserById(int id);
        public Task<KullaniciLoginResponseDTO> Login(string kullaniciAdi, string parola);


    }
}

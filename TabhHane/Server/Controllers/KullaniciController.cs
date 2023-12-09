
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TabhHane.Server.Services.Interface;
using TabhHane.Shared.DTO;
using TabhHane.Shared.ResponseModels;

namespace TabhHane.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class KullaniciController : ControllerBase
    {
        private readonly IKullaniciService kullaniciService;

        public KullaniciController(IKullaniciService KullaniciService)
        {
            kullaniciService = KullaniciService;
        }
        [HttpPost("Login")]
        [AllowAnonymous]
        public async Task<ServiceResponse<KullaniciLoginResponseDTO>> Login(KullaniciLoginRequestDTO UserRequest)
        {
            return new ServiceResponse<KullaniciLoginResponseDTO>()
            {
                Value = await kullaniciService.Login(UserRequest.KullaniciAdi, UserRequest.Parola)
            };
        }
        [HttpGet("GetKullanicilar")]
        public async Task<ServiceResponse< List<KullaniciDTO>>> GetKullanicilar()
        {
            return new ServiceResponse<List<KullaniciDTO>>()
            {
                Value = await kullaniciService.GetKullanicis(),
                
            };
        }
        [HttpPost("CreateKullanici")]
        public async Task<ServiceResponse<KullaniciDTO>> CreateKullanici([FromBody] KullaniciDTO User)
        {
            return new ServiceResponse<KullaniciDTO>()
            {
                Value = await kullaniciService.CreateKullanici(User)
            };
        }

        [HttpPost("UpdateKullanici")]
        public async Task<ServiceResponse<KullaniciDTO>> UpdateKullanici([FromBody] KullaniciDTO User)
        {
            return new ServiceResponse<KullaniciDTO>()
            {
                Value = await kullaniciService.UpdateKullanici(User)
            };
        }

        [HttpGet("GetKullaniciById/{Id}")]
        public async Task<ServiceResponse<KullaniciDTO>> GetKullaniciById(int Id)
        {
            return new ServiceResponse<KullaniciDTO>()
            {
                Value = await kullaniciService.GetKullaniciById(Id)
            };
        }


        [HttpPost("DeleteKullanici")]
        public async Task<ServiceResponse<bool>> DeleteKullanici([FromBody] int id)
        {
            return new ServiceResponse<bool>()
            {
                Value = await kullaniciService.DeleteUserById(id)
            };
        }
    }
}

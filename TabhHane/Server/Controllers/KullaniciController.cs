using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TabhHane.Server.Services.Interface;
using TabhHane.Shared.DTO;
using TabhHane.Shared.ResponseModels;

namespace TabhHane.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KullaniciController : ControllerBase
    {
        private readonly IKullaniciService kullaniciService;

        public KullaniciController(IKullaniciService KullaniciService)
        {
            kullaniciService = KullaniciService;
        }
        [HttpGet("Kullanici")]
        public async Task<ServiceResponse< List<KullaniciDTO>>> GetKullanicis()
        {
            return new ServiceResponse<List<KullaniciDTO>>()
            {
                Value = await kullaniciService.GetKullanicis(),
            };
        }
    }
}

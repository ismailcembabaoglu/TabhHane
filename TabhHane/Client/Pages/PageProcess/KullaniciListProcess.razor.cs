using Microsoft.AspNetCore.Components;
using System.Net;
using System.Net.Http.Json;
using TabhHane.Shared.DTO;
using TabhHane.Shared.ResponseModels;

namespace TabhHane.Client.Pages.Kullanicilar
{
    public class KullaniciListProcess : ComponentBase
    {
        [Inject]
        public HttpClient Client { get; set; }

        public List<KullaniciDTO> kullaniciList = new List<KullaniciDTO>();
        protected override async Task OnInitializedAsync()
        {
            await LoadList();
        }
        public async Task LoadList()
        {
            var serviceResponse = await Client.GetFromJsonAsync<ServiceResponse<List<KullaniciDTO>>>("api/kullanici/getkullanicilar");
            if (serviceResponse.Success)
                kullaniciList = serviceResponse.Value;
         
        }
    }
}

using Blazored.Modal.Services;
using Microsoft.AspNetCore.Components;
using System.Net;
using System.Net.Http.Json;
using System.Reflection;
using TabhHane.Client.Utils;
using TabhHane.Shared.CustomExceptions;
using TabhHane.Shared.DTO;
using TabhHane.Shared.ResponseModels;

namespace TabhHane.Client.Pages.Kullanicilar
{

    public class KullaniciListProcess : ComponentBase
    {
        [Inject]
        public HttpClient Client { get; set; }
        [CascadingParameter]
        public IModalService Modal { get; set; }

        public List<KullaniciDTO> kullaniciList = new List<KullaniciDTO>();
        protected override async Task OnInitializedAsync()
        {

            //await InvokeAsync(StateHasChanged);
            //await LoadList();
        }
        
        //protected override async Task OnAfterRenderAsync(bool firstRender)
        //{
        //    if (!firstRender)
        //    {
        //        await LoadList();
        //    }

        //}
        public async Task LoadList()
        {          
            try
            {
             var db=   await Client.GetServiceResponseAsync<List<KullaniciDTO>>("api/kullanici/getkullanicilar", true);
                kullaniciList = db.ToList();
            }
            catch (ApiException ex)
            {

                ModalManager modalManager = new ModalManager(Modal);
                await modalManager.ShowMessageAsync("Api Exception", ex.Message);
            }

         
        }
    }
}

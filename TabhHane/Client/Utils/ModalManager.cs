using Blazored.Modal;
using Blazored.Modal.Services;
using TabhHane.Client.CustomCompoments.ModalCompoments;

namespace TabhHane.Client.Utils
{
    public class ModalManager
    {
        private readonly IModalService modalService;
        public ModalManager(IModalService _modalService)
        {
            modalService= _modalService;
        }

        public async Task ShowMessageAsync(string title, string message)
        {
            ModalParameters mParams= new ModalParameters();
            mParams.Add("Message", message);
            var modalRef = modalService.Show<ShowMessagePopupCompoment>(title, mParams);
            await modalRef.Result;
        }
        public async Task<bool> ConfirmationAsync(string title,string message,int duration=0)
        {
            ModalParameters mParams= new ModalParameters();
            mParams.Add("Message", message);
            var modalRef = modalService.Show<ConfirmationPopupComponent>(title, mParams);
            if (duration>0)
            {
                await Task.Delay(duration);
                modalRef.Close();
            }
          var modalResult= await modalRef.Result;
            return modalResult.Cancelled;
        }
    }
}

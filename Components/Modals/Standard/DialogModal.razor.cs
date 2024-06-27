﻿using Microsoft.AspNetCore.Components;
using TabBlazor.Services;

namespace TabBlazor.Modals
{
    public partial class DialogModal : ComponentBase
    {
        [Inject] private IModalService modalService { get; set; }

        [Parameter] public DialogOptions Options { get; set; }
        private void Cancel()
        {
            modalService.Close();
        }

        private void Ok()
        {
            modalService.Close(ModalResult.Ok());
        }



    }
}

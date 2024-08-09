using HsPerformance.User.Mobile.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HsPerformance.User.Mobile.Views
{
    public class ContentPageBase : ContentPage
    {
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            if(BindingContext is not IViewModelBase ivmb)
            {
                return;
            }

            await ivmb.InitializeAsyncCommand.ExecuteAsync(null);
        }
    }
}

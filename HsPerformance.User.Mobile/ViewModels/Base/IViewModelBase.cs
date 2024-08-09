using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HsPerformance.User.Mobile.ViewModels.Base
{
    public interface IViewModelBase
    {
        public IAsyncRelayCommand InitializeAsyncCommand { get; }
    }
}

using Prism.Mvvm;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mov.WpfControls.Helpers;
using Prism.Services.Dialogs;
using Reactive.Bindings.Extensions;
using Mov.WpfViewModels;

namespace Stocker.Wpf.ViewModels.Panels
{
    public class MenuViewModel : ContentViewModelBase
    {
        #region フィールド

        #endregion

        #region コマンド

        public ReactiveCommand LoginCommand { get; } = new ReactiveCommand();

        #endregion

        public MenuViewModel(IDialogService dialogService) : base(dialogService)
        {
            LoginCommand.Subscribe(OnLogin).AddTo(Disposables);
        }

        private void OnLogin()
        {
            DialogService.Show("LoginDialog");
        }

    }
}

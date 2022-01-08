using Prism.Mvvm;
using Reactive.Bindings;
using Stocker.Wpf.Views;
using Stocker.Wpf.Views.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mov.WpfControls.Helpers;

namespace Stocker.Wpf.ViewModels.Panels
{
    public class MenuViewModel : BindableBase
    {
        #region コマンド

        public ReactiveCommand LoginCommand { get; } = new ReactiveCommand();

        #endregion

        public MenuViewModel()
        {
            LoginCommand.Subscribe(() => ShellSwitcher.Switch<MainWindow, LoginWindow>());
        }

    }
}

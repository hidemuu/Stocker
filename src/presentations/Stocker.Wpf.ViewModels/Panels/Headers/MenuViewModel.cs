using Prism.Mvvm;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocker.Wpf.ViewModels.Panels
{
    public class MenuViewModel : BindableBase
    {
        #region コマンド

        public ReactiveCommand LoginCommand { get; } = new ReactiveCommand();

        #endregion

        public MenuViewModel()
        {
            LoginCommand.Subscribe(() => { });
            //LoginCommand.Subscribe(() => ShellSwitcher.Switch<MainWindow, LoginWindow>());
        }

    }
}

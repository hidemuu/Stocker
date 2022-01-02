using Prism.Mvvm;
using Prism.Regions;
using Reactive.Bindings;
using WpfControls.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocker.Wpf.ViewModels.Panels
{
    public class DashboardViewModel : BindableBase
    {
        #region フィールド

        private readonly IRegionManager regionManager;

        #endregion

        #region プロパティ

        public bool KeepAlive => true;

        #endregion

        #region コマンド

        public ReactiveCommand LoginCommand { get; } = new ReactiveCommand();

        #endregion

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="eventAggregator">PubSubパターンでイベントの通知と購読を管理することで、ViewModel間の通信を実現</param>
        public DashboardViewModel(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
            //LoginCommand.Subscribe(() => ShellSwitcher.Switch<MainWindow, LoginWindow>());
        }

    }
}

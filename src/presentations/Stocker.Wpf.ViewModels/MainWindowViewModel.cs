using Mov.WpfViewModels;
using Prism.Regions;
using Prism.Services.Dialogs;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using Stocker.Wpf.Models;
using Stocker.Wpf.Models.Constants;
using System;
using System.Linq;
using System.Reactive.Concurrency;
using System.Threading;

namespace Stocker.Wpf.ViewModels
{
    /// <summary>
    ///
    /// </summary>
    public class MainWindowViewModel : RegionViewModelBase
    {
        #region フィールド

        public ReactiveCollection<MainWindowModel> Models { get; } = new ReactiveCollection<MainWindowModel>();
        public ReactivePropertySlim<int> TabPage { get; set; } = new ReactivePropertySlim<int>(-1);

        #endregion

        #region コマンド

        public ReactiveCommand TabChangeCommand { get; } = new ReactiveCommand();

        #endregion

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="regionManager"></param>
        /// <param name="dialogService"></param>
        public MainWindowViewModel(IRegionManager regionManager, IDialogService dialogService) : base(regionManager, dialogService)
        {
            Models.Add(new MainWindowModel(0, "Dashboard", "Home", () => this.RegionManager.RequestNavigate(RegionNames.CENTER_CONTENT, "DashboardView")));
            Models.Add(new MainWindowModel(1, "Table", "Table", () => this.RegionManager.RequestNavigate(RegionNames.CENTER_CONTENT, "TableView")));
            Models.Add(new MainWindowModel(2, "Chart", "Graph", () => this.RegionManager.RequestNavigate(RegionNames.CENTER_CONTENT, "ChartView")));
            Models.Add(new MainWindowModel(3, "Tree", "Tree", () => this.RegionManager.RequestNavigate(RegionNames.CENTER_CONTENT, "TreeTableView")));
            Models.Add(new MainWindowModel(4, "Setting", "Cog", () => this.RegionManager.RequestNavigate(RegionNames.CENTER_CONTENT, "SettingView")));

            TabChangeCommand.Subscribe(_ => OnChangeTab()).AddTo(Disposables);

            // 定期更新スレッド
            var timer = new ReactiveTimer(TimeSpan.FromMilliseconds(10), new SynchronizationContextScheduler(SynchronizationContext.Current));
            timer.Subscribe(_ =>
            {
            });
            timer.AddTo(Disposables);
            timer.Start();
        }

        #region メソッド

        protected override void OnLoaded()
        {
            this.RegionManager.RequestNavigate(RegionNames.MENU_BAR, "MenuView");
            this.RegionManager.RequestNavigate(RegionNames.TOOL_BAR, "ToolView");
            this.RegionManager.RequestNavigate(RegionNames.RIGHT_CONTENT, "LayoutView");
            //this.RegionManager.RequestNavigate(RegionNames.LEFT_CONTENT, "TreeTableView");
            this.RegionManager.RequestNavigate(RegionNames.CENTER_CONTENT, "DashboardView");
            this.RegionManager.RequestNavigate(RegionNames.FOOTER, "GuideView");
        }

        private void OnChangeTab()
        {
            Models.FirstOrDefault(x => x.Index == TabPage.Value).TabCommand();
        }

        #endregion

    }
}
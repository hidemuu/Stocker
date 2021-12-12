using Prism.Mvvm;
using Prism.Regions;
using Prism.Services.Dialogs;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using Stocker.Wpf.Models;
using Stocker.Wpf.Models.Constants;
using Stocker.Wpf.Views.Panels;
using System;
using System.Linq;
using System.Reactive.Concurrency;
using System.Reactive.Disposables;
using System.Threading;

namespace Stocker.Wpf.ViewModels
{
    public class MainWindowViewModel : BindableBase, INavigationAware, IRegionMemberLifetime
    {
        public ReactiveCollection<MainWindowModel> Models { get; } = new ReactiveCollection<MainWindowModel>();
        public ReactivePropertySlim<int> TabPage { get; set; } = new ReactivePropertySlim<int>(-1);
        public IRegionManager RegionManager { get; }
        private IRegionNavigationJournal journal;
        private readonly IDialogService dialogService;

        public ReactiveCommand LoadedCommand { get; } = new ReactiveCommand();
        public ReactiveCommand TabChangeCommand { get; } = new ReactiveCommand();

        private CompositeDisposable disposables = new CompositeDisposable();

        public bool KeepAlive => true;

        public MainWindowViewModel(IRegionManager regionManager, IDialogService dialogService)
        {
            this.RegionManager = regionManager;
            this.dialogService = dialogService;

            Models.Add(new MainWindowModel(0, "Dashboard", "Home", () => this.RegionManager.RequestNavigate(RegionNames.ContentRegion, nameof(DashboardView))));
            Models.Add(new MainWindowModel(1, "Product", "Table", () => this.RegionManager.RequestNavigate(RegionNames.ContentRegion, nameof(ProductTableView))));
            Models.Add(new MainWindowModel(2, "Product", "Chart", () => this.RegionManager.RequestNavigate(RegionNames.ContentRegion, nameof(ProductChartView))));
            Models.Add(new MainWindowModel(3, "Order", "Table", () => this.RegionManager.RequestNavigate(RegionNames.ContentRegion, nameof(OrderTableView))));
            Models.Add(new MainWindowModel(4, "Customer", "Table", () => this.RegionManager.RequestNavigate(RegionNames.ContentRegion, nameof(CustomerTableView))));
            Models.Add(new MainWindowModel(5, "Setting", "Cog", () => this.RegionManager.RequestNavigate(RegionNames.ContentRegion, nameof(SettingView))));

            LoadedCommand.Subscribe(() => OnLoaded());
            TabChangeCommand.Subscribe(_ => OnChangeTab());

            
            // 定期更新スレッド
            var timer = new ReactiveTimer(TimeSpan.FromMilliseconds(10), new SynchronizationContextScheduler(SynchronizationContext.Current));
            timer.Subscribe(_ =>
            {

            });
            timer.AddTo(disposables);
            timer.Start();
        }

        private void OnLoaded()
        {
            this.RegionManager.RequestNavigate(RegionNames.ToolBarRegion, nameof(ToolView));
            this.RegionManager.RequestNavigate(RegionNames.PropertyRegion, nameof(PropertyView));
            this.RegionManager.RequestNavigate(RegionNames.ExploreRegion, nameof(ExploreView));
            this.RegionManager.RequestNavigate(RegionNames.ContentRegion, nameof(DashboardView));
        }

        private void OnChangeTab()
        {
            Models.FirstOrDefault(x => x.Index == TabPage.Value).TabCommand();
        }

        #region ナビゲーションメソッド

        /// <summary>
        /// このメソッドの返す値により、画面のインスタンスを使いまわすかどうか制御できる。
        /// true ：インスタンスを使いまわす(画面遷移してもコンストラクタ呼ばれない)
        /// false：インスタンスを使いまわさない(画面遷移するとコンストラクタ呼ばれる)
        /// メソッド実装なし：trueになる
        /// ※コンストラクタは呼ばれないが、Loadedイベントは起きる
        /// </summary>
        /// <param name="navigationContext"></param>
        /// <returns></returns>
        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        /// <summary>
        /// この画面から他の画面に遷移する時の処理
        /// </summary>
        /// <param name="navigationContext"></param>
        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            //MessageBox.Show("退出完了");
        }

        /// <summary>
        /// 他の画面からこの画面に遷移してきた時の処理
        /// </summary>
        /// <param name="navigationContext"></param>
        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            journal = navigationContext.NavigationService.Journal;

        }

        #endregion

    }
}

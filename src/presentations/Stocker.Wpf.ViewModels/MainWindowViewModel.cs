using Prism.Mvvm;
using Prism.Regions;
using Prism.Services.Dialogs;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using Stocker.Wpf.Models;
using Stocker.Wpf.Models.Constants;
using Stocker.Wpf.Views.Panels;
using System;
using System.Reactive.Concurrency;
using System.Reactive.Disposables;
using System.Threading;

namespace Stocker.Wpf.ViewModels
{
    public class MainWindowViewModel : BindableBase, INavigationAware, IRegionMemberLifetime
    {
        public MainWindowModel Models { get; } = new MainWindowModel();
        public IRegionManager RegionManager { get; }
        private IRegionNavigationJournal journal;
        private readonly IDialogService dialogService;

        public ReactiveCommand LoadedCommand { get; } = new ReactiveCommand();

        private CompositeDisposable disposables = new CompositeDisposable();

        public bool KeepAlive => true;

        public MainWindowViewModel(IRegionManager regionManager, IDialogService dialogService)
        {
            this.RegionManager = regionManager;
            this.dialogService = dialogService;

            LoadedCommand.Subscribe(() => { 
                this.RegionManager.RequestNavigate(RegionNames.MainRegion, nameof(MainView));
                this.RegionManager.RequestNavigate(RegionNames.ToolRegion, nameof(ToolView));
                this.RegionManager.RequestNavigate(RegionNames.PropertyRegion, nameof(PropertyView));
                this.RegionManager.RequestNavigate(RegionNames.ExploreRegion, nameof(ExploreView));
            });

            // 定期更新スレッド
            var timer = new ReactiveTimer(TimeSpan.FromMilliseconds(10), new SynchronizationContextScheduler(SynchronizationContext.Current));
            timer.Subscribe(_ =>
            {

            });
            timer.AddTo(disposables);
            timer.Start();
        }

        
        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            //MessageBox.Show("退出完了");
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            journal = navigationContext.NavigationService.Journal;

        }

    }
}

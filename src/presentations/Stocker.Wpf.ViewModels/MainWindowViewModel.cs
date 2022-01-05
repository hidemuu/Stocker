using Prism.Mvvm;
using Prism.Regions;
using Prism.Services.Dialogs;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using Stocker.Wpf.Models;
using Stocker.Wpf.Models.Constants;
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

            Models.Add(new MainWindowModel(0, "Dashboard", "Home", () => this.RegionManager.RequestNavigate(RegionNames.CENTER_CONTENT, "DashboardView")));
            Models.Add(new MainWindowModel(1, "Table", "Table", () => this.RegionManager.RequestNavigate(RegionNames.CENTER_CONTENT, "TableView")));
            Models.Add(new MainWindowModel(2, "Chart", "Graph", () => this.RegionManager.RequestNavigate(RegionNames.CENTER_CONTENT, "ChartView")));
            Models.Add(new MainWindowModel(3, "Tree", "Tree", () => this.RegionManager.RequestNavigate(RegionNames.CENTER_CONTENT, "TreeTableView")));
            Models.Add(new MainWindowModel(4, "Setting", "Cog", () => this.RegionManager.RequestNavigate(RegionNames.CENTER_CONTENT, "SettingView")));

            LoadedCommand.Subscribe(() => OnLoaded());
            TabChangeCommand.Subscribe(_ => OnChangeTab());

            
            // ����X�V�X���b�h
            var timer = new ReactiveTimer(TimeSpan.FromMilliseconds(10), new SynchronizationContextScheduler(SynchronizationContext.Current));
            timer.Subscribe(_ =>
            {

            });
            timer.AddTo(disposables);
            timer.Start();
        }

        private void OnLoaded()
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

        #region �i�r�Q�[�V�������\�b�h

        /// <summary>
        /// ���̃��\�b�h�̕Ԃ��l�ɂ��A��ʂ̃C���X�^���X���g���܂킷���ǂ�������ł���B
        /// true �F�C���X�^���X���g���܂킷(��ʑJ�ڂ��Ă��R���X�g���N�^�Ă΂�Ȃ�)
        /// false�F�C���X�^���X���g���܂킳�Ȃ�(��ʑJ�ڂ���ƃR���X�g���N�^�Ă΂��)
        /// ���\�b�h�����Ȃ��Ftrue�ɂȂ�
        /// ���R���X�g���N�^�͌Ă΂�Ȃ����ALoaded�C�x���g�͋N����
        /// </summary>
        /// <param name="navigationContext"></param>
        /// <returns></returns>
        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        /// <summary>
        /// ���̉�ʂ��瑼�̉�ʂɑJ�ڂ��鎞�̏���
        /// </summary>
        /// <param name="navigationContext"></param>
        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            //MessageBox.Show("�ޏo����");
        }

        /// <summary>
        /// ���̉�ʂ��炱�̉�ʂɑJ�ڂ��Ă������̏���
        /// </summary>
        /// <param name="navigationContext"></param>
        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            journal = navigationContext.NavigationService.Journal;

        }

        #endregion

    }
}

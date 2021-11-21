using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Unity;
using Stocker.Wpf.ViewModels;
using Stocker.Wpf.ViewModels.Panels;
using Stocker.Wpf.Views;
using Stocker.Wpf.Views.Panels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Stocker.Wpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        /// <summary>
        /// シェル生成
        /// </summary>
        /// <returns></returns>
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>(); //初期表示ビュー
        }

        /// <summary>
        /// コンテナ登録
        /// </summary>
        /// <param name="containerRegistry"></param>
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //DIコンテナ GetContainerでUnityのコンテナに直接アクセス可能
            var container = containerRegistry.GetContainer();

            //リポジトリの登録
            //containerRegistry.RegisterInstance<ILandMarkRepository>(new InMemoryLandMarkRepository());

            //サービスの登録
            //containerRegistry.RegisterInstance<IGameService>(Container.Resolve<GameService>());

            //Viewの登録
            containerRegistry.RegisterForNavigation<MainView>();
            containerRegistry.RegisterForNavigation<ToolView>();
            containerRegistry.RegisterForNavigation<ExploreView>();
            containerRegistry.RegisterForNavigation<PropertyView>();

            //Dialogの登録
            //containerRegistry.RegisterDialog<GameOverDialog, GameOverDialogViewModel>();
        }

        protected override void ConfigureRegionAdapterMappings(RegionAdapterMappings regionAdapterMappings)
        {
            base.ConfigureRegionAdapterMappings(regionAdapterMappings);
        }

        /// <summary>
        /// View-ViewModel関連付け
        /// </summary>
        protected override void ConfigureViewModelLocator()
        {
            base.ConfigureViewModelLocator();

            ViewModelLocationProvider.Register<MainWindow, MainWindowViewModel>();
            ViewModelLocationProvider.Register<MainView, MainViewModel>();
            ViewModelLocationProvider.Register<ToolView, ToolViewModel>();
            ViewModelLocationProvider.Register<ExploreView, ExploreViewModel>();
            ViewModelLocationProvider.Register<PropertyView, PropertyViewModel>();
        }

        protected override IModuleCatalog CreateModuleCatalog()
        {
            return new ConfigurationModuleCatalog();
        }

    }
}

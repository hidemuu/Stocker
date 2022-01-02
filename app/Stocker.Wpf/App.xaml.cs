using Microsoft.EntityFrameworkCore;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Unity;
using Designer.Models;
using Designer.Repository.Xml;
using Stocker.Models;
using Stocker.Repository.Sql;
using Configurator.Models;
using Configurator.Repository;
using Utilities;
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
using Authorizer.Models;
using Authorizer.Repository;
using Stocker.Wpf.Views.Dialogs;
using Stocker.Wpf.ViewModels.Dialogs;
using Stocker.Wpf.Views.Login;
using Stocker.Wpf.ViewModels.Login;
using Language.Repository;
using Language.Models;
using System.IO;
using Stocker.Wpf.Views.Panels.Contents;
using Stocker.Wpf.ViewModels.Panels.Contents;

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
            var rootPath = PathHelper.GetCurrentRootPath("Stocker");
            var assetPath = Path.Combine(rootPath, "assets");
            containerRegistry.RegisterInstance<IStockerRepository>(new SqlStockerRepository(new DbContextOptionsBuilder<StockerDbContext>().UseSqlite(@"Data Source=" + Path.Combine(assetPath, "db.sqlite"))));
            containerRegistry.RegisterInstance<IConfiguratorRepository>(new ConfiguratorRepository(Path.Combine(assetPath, "configurator"), Accessors.FileType.Json));
            containerRegistry.RegisterInstance<IDesignerRepository>(new DesignerRepository(Path.Combine(assetPath, "designer"), Accessors.FileType.Xml));
            containerRegistry.RegisterInstance<IAuthorizerRepository>(new AuthorizerRepository(Path.Combine(assetPath, "authorizer"), Accessors.FileType.Json));
            containerRegistry.RegisterInstance<ILanguageRepository>(new LanguageRepository(Path.Combine(assetPath, "language"), Accessors.FileType.Json));

            //サービスの登録
            //containerRegistry.RegisterInstance<IGameService>(Container.Resolve<GameService>());

            //Viewの登録
            containerRegistry.RegisterForNavigation<LoginMainContent>();
            containerRegistry.RegisterForNavigation<CreateAccount>();
            containerRegistry.RegisterForNavigation<DashboardView>();
            containerRegistry.RegisterForNavigation<ToolView>();
            containerRegistry.RegisterForNavigation<TreeTableView>();
            containerRegistry.RegisterForNavigation<LayoutView>();
            containerRegistry.RegisterForNavigation<TableView>();
            containerRegistry.RegisterForNavigation<ChartView>();
            containerRegistry.RegisterForNavigation<SettingView>();

            //Dialogの登録
            containerRegistry.RegisterDialog<AlertDialog, AlertDialogViewModel>();
            containerRegistry.RegisterDialog<SuccessDialog, SuccessDialogViewModel>();
            containerRegistry.RegisterDialog<WarningDialog, WarningDialogViewModel>();
            containerRegistry.RegisterDialogWindow<DialogWindow>();
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

            ViewModelLocationProvider.Register<LoginWindow, LoginWindowViewModel>();
            ViewModelLocationProvider.Register<LoginMainContent, LoginMainContentViewModel>();
            ViewModelLocationProvider.Register<MainWindow, MainWindowViewModel>();
            ViewModelLocationProvider.Register<DashboardView, DashboardViewModel>();
            ViewModelLocationProvider.Register<ToolView, ToolViewModel>();
            ViewModelLocationProvider.Register<TreeTableView, TreeTableViewModel>();
            ViewModelLocationProvider.Register<LayoutView, LayoutViewModel>();
            ViewModelLocationProvider.Register<TableView, TableViewModel>();
            ViewModelLocationProvider.Register<ChartView, ChartViewModel>();
            ViewModelLocationProvider.Register<SettingView, SettingViewModel>();
        }

        protected override IModuleCatalog CreateModuleCatalog()
        {
            return new ConfigurationModuleCatalog();
        }

    }
}

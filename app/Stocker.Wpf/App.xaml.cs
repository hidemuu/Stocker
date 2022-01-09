using Microsoft.EntityFrameworkCore;
using Mov.Authorizer.Models;
using Mov.Authorizer.Repository;
using Mov.Configurator.Models;
using Mov.Configurator.Repository;
using Mov.Designer.Models;
using Mov.Designer.Repository.Xml;
using Mov.Translator.Models;
using Mov.Translator.Repository;
using Mov.Utilities;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Unity;
using Stocker.Models;
using Stocker.Repository.Sql;
using Stocker.Wpf.ViewModels;
using Stocker.Wpf.ViewModels.Dialogs;
using Stocker.Wpf.ViewModels.Login;
using Stocker.Wpf.ViewModels.Panels;
using Stocker.Wpf.ViewModels.Panels.Contents;
using Stocker.Wpf.Views;
using Stocker.Wpf.Views.Dialogs;
using Stocker.Wpf.Views.Login;
using Stocker.Wpf.Views.Panels;
using Stocker.Wpf.Views.Panels.Contents;
using System.IO;
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
            var rootPath = PathHelper.GetCurrentRootPath("Stocker");
            var assetPath = Path.Combine(rootPath, "assets");
            containerRegistry.RegisterInstance<IStockerRepository>(new SqlStockerRepository(new DbContextOptionsBuilder<StockerDbContext>().UseSqlite(@"Data Source=" + Path.Combine(assetPath, "db.sqlite"))));
            containerRegistry.RegisterInstance<IConfiguratorRepository>(new ConfiguratorRepository(Path.Combine(assetPath, "configurator"), Mov.Accessors.FileType.Json));
            containerRegistry.RegisterInstance<IDesignerRepository>(new DesignerRepository(Path.Combine(assetPath, "designer"), Mov.Accessors.FileType.Xml));
            containerRegistry.RegisterInstance<IAuthorizerRepository>(new AuthorizerRepository(Path.Combine(assetPath, "authorizer"), Mov.Accessors.FileType.Json));
            containerRegistry.RegisterInstance<ITranslatorRepository>(new TranslatorRepository(Path.Combine(assetPath, "translator"), Mov.Accessors.FileType.Json));

            //サービスの登録
            //containerRegistry.RegisterInstance<IGameService>(Container.Resolve<GameService>());

            //Viewの登録
            containerRegistry.RegisterForNavigation<LoginMainContent>();
            containerRegistry.RegisterForNavigation<CreateAccount>();
            containerRegistry.RegisterForNavigation<DashboardView>();
            containerRegistry.RegisterForNavigation<MenuView>();
            containerRegistry.RegisterForNavigation<ToolView>();
            containerRegistry.RegisterForNavigation<TreeTableView>();
            containerRegistry.RegisterForNavigation<LayoutView>();
            containerRegistry.RegisterForNavigation<TableView>();
            containerRegistry.RegisterForNavigation<ChartView>();
            containerRegistry.RegisterForNavigation<SettingView>();

            //Dialogの登録
            containerRegistry.RegisterDialog<LoginDialog, LoginDialogViewModel>();
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

            ViewModelLocationProvider.Register<LoginMainContent, LoginMainContentViewModel>();
            ViewModelLocationProvider.Register<MainWindow, MainWindowViewModel>();
            ViewModelLocationProvider.Register<DashboardView, DashboardViewModel>();
            ViewModelLocationProvider.Register<MenuView, MenuViewModel>();
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
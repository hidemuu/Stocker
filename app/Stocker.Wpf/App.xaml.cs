﻿using Microsoft.EntityFrameworkCore;
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
using Configurator.Repository.Xml;
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
            containerRegistry.RegisterInstance<IStockerRepository>(new SqlStockerRepository(new DbContextOptionsBuilder<StockerDbContext>().UseSqlite(@"Data Source=" + rootPath + @"assets\db.sqlite")));
            containerRegistry.RegisterInstance<ISettingRepository>(new XmlSettingRepository(rootPath + @"assets\settings\"));
            containerRegistry.RegisterInstance<IDesignRepository>(new XmlDesignRepository(rootPath + @"assets\guis\"));

            //サービスの登録
            //containerRegistry.RegisterInstance<IGameService>(Container.Resolve<GameService>());

            //Viewの登録
            containerRegistry.RegisterForNavigation<DashboardView>();
            containerRegistry.RegisterForNavigation<ToolView>();
            containerRegistry.RegisterForNavigation<ExploreView>();
            containerRegistry.RegisterForNavigation<PropertyView>();
            containerRegistry.RegisterForNavigation<ProductTableView>();
            containerRegistry.RegisterForNavigation<ProductChartView>();
            containerRegistry.RegisterForNavigation<OrderTableView>();
            containerRegistry.RegisterForNavigation<CustomerTableView>();
            containerRegistry.RegisterForNavigation<LineItemTableView>();
            containerRegistry.RegisterForNavigation<CustomView>();
            containerRegistry.RegisterForNavigation<SettingView>();

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
            ViewModelLocationProvider.Register<DashboardView, DashboardViewModel>();
            ViewModelLocationProvider.Register<ToolView, ToolViewModel>();
            ViewModelLocationProvider.Register<ExploreView, ExploreViewModel>();
            ViewModelLocationProvider.Register<PropertyView, PropertyViewModel>();
            ViewModelLocationProvider.Register<ProductTableView, ProductTableViewModel>();
            ViewModelLocationProvider.Register<ProductChartView, ProductChartViewModel>();
            ViewModelLocationProvider.Register<OrderTableView, OrderTableViewModel>();
            ViewModelLocationProvider.Register<CustomerTableView, CustomerTableViewModel>();
            ViewModelLocationProvider.Register<LineItemTableView, LineItemTableViewModel>();
            ViewModelLocationProvider.Register<CustomView, CustomViewModel>();
            ViewModelLocationProvider.Register<SettingView, SettingViewModel>();
        }

        protected override IModuleCatalog CreateModuleCatalog()
        {
            return new ConfigurationModuleCatalog();
        }

    }
}

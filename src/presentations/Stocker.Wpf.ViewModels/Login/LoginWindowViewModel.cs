﻿using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Services.Dialogs;
using Stocker.Wpf.Models.Constants;
using Stocker.Wpf.ViewModels.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Stocker.Wpf.ViewModels.Login
{
    public class LoginWindowViewModel : BindableBase
    {
        public IRegionManager RegionManager { get; }
        private readonly UserService userService;
        private readonly IDialogService dialogService;

        private DelegateCommand _loginLoadingCommand;
        public DelegateCommand LoginLoadingCommand =>
            _loginLoadingCommand ?? (_loginLoadingCommand = new DelegateCommand(ExecuteLoginLoadingCommand));

        void ExecuteLoginLoadingCommand()
        {
            RegionManager.RequestNavigate(RegionNames.LoginRegion, "LoginMainContent");
            //IRegion region = regionManager.Regions[RegionNames.LoginRegion];
            //region.RequestNavigate("LoginMainContent", NavigationCompelted);
            //Global.AllUsers = userService.GetAllUsers();
        }

        public async Task TestTask()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(6000);
                Debug.WriteLine("test");
            });

        }

        public LoginWindowViewModel(IRegionManager regionManager, UserService userService, IDialogService dialogService)
        {
            this.RegionManager = regionManager;
            this.userService = userService;
            this.dialogService = dialogService;
        }



        private void NavigationCompelted(NavigationResult result)
        {
            if (result.Result == true)
            {
                Thread.Sleep(1000);
                dialogService.Show("SuccessDialog", new DialogParameters($"message={"LoginMainContent画面表示成功"}"), null);
            }
            else
            {
                dialogService.Show("WarningDialog", new DialogParameters($"message={"LoginMainContent画面表示失敗"}"), null);
            }
        }


    }
}

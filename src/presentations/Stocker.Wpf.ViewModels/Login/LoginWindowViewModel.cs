using Mov.Authorizer.Models;
using Prism.Commands;
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
    public class LoginWindowViewModel : BindableBase, IDialogAware
    {
        #region フィールド

        public IRegionManager RegionManager { get; }

        private readonly IDialogService dialogService;

        private readonly IAuthorizerRepository authorizerRepository;

        #endregion

        #region コマンド

        private DelegateCommand _loginLoadingCommand;
        public DelegateCommand LoginLoadingCommand =>
            _loginLoadingCommand ?? (_loginLoadingCommand = new DelegateCommand(OnLoading));

        #endregion

        

        public LoginWindowViewModel(IRegionManager regionManager, IDialogService dialogService, IAuthorizerRepository authorizerRepository)
        {
            this.RegionManager = regionManager;
            this.dialogService = dialogService;
            this.authorizerRepository = authorizerRepository;
        }

        void OnLoading()
        {
            RegionManager.RequestNavigate(RegionNames.LOGIN, "LoginMainContent", NavigationCompleted);
            //IRegion region = RegionManager.Regions[RegionNames.LoginRegion];
            //region.RequestNavigate("LoginMainContent", NavigationCompelted);
            //Global.AllUsers = userService.GetAllUsers();
        }

        private void NavigationCompleted(NavigationResult result)
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

        #region DialogAware

        /// <summary>
        /// ダイアログタイトル
        /// </summary>
        public string Title => "loginWindow";
        
        /// <summary>
        /// ダイアログを閉じる時に呼び出す
        /// </summary>
        public event Action<IDialogResult> RequestClose;
        
        /// <summary>
        /// ダイアログを閉じれるかどうか
        /// </summary>
        /// <returns></returns>
        public bool CanCloseDialog() => true;
        
        /// <summary>
        /// ダイアログを閉じた時に呼ばれる
        /// </summary>
        public void OnDialogClosed() { }
        
        /// <summary>
        /// ダイアログを開くときに呼ばれる
        /// </summary>
        /// <param name="parameters"></param>
        public void OnDialogOpened(IDialogParameters parameters)
        {
            
        }

        #endregion

    }
}

using Mov.Authorizer.Models;
using Mov.WpfControls.ViewModels;
using Prism.Regions;
using Prism.Services.Dialogs;
using Stocker.Wpf.Models.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Stocker.Wpf.ViewModels.Login
{
    /// <summary>
    /// ログインダイアログ
    /// </summary>
    public class LoginDialogViewModel : DialogViewModelBase
    {
        #region フィールド

        public override string Title => "LoginView";

        public IRegionManager RegionManager { get; }

        private readonly IDialogService dialogService;

        private readonly IAuthorizerRepository authorizerRepository;

        #endregion

        #region コマンド

        #endregion

        public LoginDialogViewModel(IRegionManager regionManager, IDialogService dialogService, IAuthorizerRepository authorizerRepository)
        {
            this.RegionManager = regionManager;
            this.dialogService = dialogService;
            this.authorizerRepository = authorizerRepository;

        }

        protected override void OnLoaded()
        {
            RegionManager.RequestNavigate(RegionNames.LOGIN, "LoginMainContent", NavigationCompleted);
        }

        private void NavigationCompleted(NavigationResult result)
        {
            if (result.Result == true)
            {
                dialogService.Show("SuccessDialog", new DialogParameters($"message={"画面表示が成功しました"}"), null);
            }
            else
            {
                dialogService.Show("WarningDialog", new DialogParameters($"message={"画面表示が失敗しました"}"), null);
            }
        }
    }
}

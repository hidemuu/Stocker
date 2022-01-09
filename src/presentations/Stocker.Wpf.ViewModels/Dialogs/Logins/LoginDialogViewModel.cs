using Mov.Authorizer.Models;
using Mov.WpfControls.ViewModels;
using Prism.Regions;
using Prism.Services.Dialogs;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using Stocker.Wpf.Models.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Stocker.Wpf.ViewModels.Login
{
    /// <summary>
    /// ログインダイアログ
    /// </summary>
    public class LoginDialogViewModel : DialogRegionViewModelBase, IConfirmNavigationRequest
    {
        #region フィールド

        public override string Title => "LoginView";

        private readonly IAuthorizerRepository authorizerRepository;
        public ReactivePropertySlim<User> CurrentUser { get; } = new ReactivePropertySlim<User>();
        public ReactivePropertySlim<string> ApplyContent { get; } = new ReactivePropertySlim<string>("Login");

        public ReactivePropertySlim<string> ChangeContentGuide { get; } = new ReactivePropertySlim<string>("Now Here?");

        public ReactivePropertySlim<string> ChangeContent { get; } = new ReactivePropertySlim<string>("Create an account");

        #endregion

        #region コマンド

        public ReactiveCommand<object> ApplyCommand { get; } = new ReactiveCommand<object>();

        public ReactiveCommand ChangeContentCommand { get; } = new ReactiveCommand();

        #endregion

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="regionManager"></param>
        /// <param name="dialogService"></param>
        public LoginDialogViewModel(IRegionManager regionManager, IDialogService dialogService, IAuthorizerRepository authorizerRepository) : base(regionManager, dialogService)
        {
            this.authorizerRepository = authorizerRepository;
            ApplyCommand.Subscribe(OnApply).AddTo(Disposables);
            ChangeContentCommand.Subscribe(OnChangeContent).AddTo(Disposables);
        }

        #region メソッド

        protected override void OnLoaded()
        {
            RequestMainContent();
        }

        private void OnApply(object parameter)
        {
            if (ApplyContent.Value == "Login")
            {
                ApplyLogin();
                return;
            }
            ApplyCreate();
        }

        private void OnChangeContent()
        {
            if(ApplyContent.Value == "Login")
            {
                RequestCreateAccount();
                return;
            }
            RequestMainContent();
        }

        private void RequestMainContent()
        {
            RequestNoContent();
            ApplyContent.Value = "Login";
            ChangeContentGuide.Value = "Now Here?";
            ChangeContent.Value = "Create an account";
            RegionManager.RequestNavigate(RegionNames.MAIN, "LoginMainContent", NavigationCompleted);
        }

        private void RequestCreateAccount()
        {
            RequestNoContent();
            ApplyContent.Value = "Create";
            ChangeContentGuide.Value = "already registerted?";
            ChangeContent.Value = "Login";
            RegionManager.RequestNavigate(RegionNames.MAIN, "CreateAccount");
        }

        private void RequestNoContent()
        {
            RegionManager.RequestNavigate(RegionNames.MAIN, "NoContent");
        }

        private void ApplyLogin()
        {
            if (this.CurrentUser.Value == null)
            {
                return;
            }
            if (string.IsNullOrEmpty(this.CurrentUser.Value.LoginId))
            {
                DialogService.Show("WarningDialog", new DialogParameters($"message={"LoginIdを入力して下さい!"}"), null);
                return;
            }
            if (string.IsNullOrEmpty(this.CurrentUser.Value.Password))
            {
                DialogService.Show("WarningDialog", new DialogParameters($"message={"Passwordを入力して下さい!"}"), null);
                return;
            }
            else if (authorizerRepository.Users.Gets().Where(t => t.LoginId == this.CurrentUser.Value.LoginId && t.Password == this.CurrentUser.Value.Password).Count() == 0)
            {
                DialogService.Show("WarningDialog", new DialogParameters($"message={"LoginIdかPasswordが一致しません!"}"), null);
                return;
            }
            RequestCloseInvoke(new DialogResult(ButtonResult.OK));
        }

        private void ApplyCreate()
        {
            
            var password = string.Empty;
            var confimPassword = string.Empty;
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Passwordが空白です！");
                return;
            }
            if (string.IsNullOrEmpty(confimPassword))
            {
                MessageBox.Show("ConfirmPassword パスワードを確認して下さい！");
                return;
            }
            if (password.Trim() != confimPassword.Trim())
            {
                MessageBox.Show("アカウントが一致しません");
                return;
            }
            //Global.AllUsers.Add(new User()
            //{
            //    Id = Global.AllUsers.Max(t => t.Id) + 1,
            //    LoginId = this.RegisteredLoginId,
            //    Password = password
            //});
            DialogService.ShowDialog("SuccessDialog", new DialogParameters($"message={"登録成功"}"), null);
            Journal.GoBack();
            
        }

        private void NavigationCompleted(NavigationResult result)
        {
            if (result.Result == true)
            {
                DialogService.Show("SuccessDialog", new DialogParameters($"message={"画面表示が成功しました"}"), null);
            }
            else
            {
                DialogService.Show("WarningDialog", new DialogParameters($"message={"画面表示が失敗しました"}"), null);
            }
        }

        #endregion

        #region ナビゲーションメソッド

        public void ConfirmNavigationRequest(NavigationContext navigationContext, Action<bool> continuationCallback)
        {
            
            continuationCallback(true);

        }

        public override void OnNavigatedFrom(NavigationContext navigationContext)
        {
            base.OnNavigatedFrom(navigationContext);

        }

        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            base.OnNavigatedTo(navigationContext);
            var loginId = navigationContext.Parameters["loginId"] as string;
            var password = navigationContext.Parameters["password"] as string;
            if (loginId != null)
            {
                this.CurrentUser.Value = new User() { LoginId = loginId };
            }

        }

        #endregion

    }
}

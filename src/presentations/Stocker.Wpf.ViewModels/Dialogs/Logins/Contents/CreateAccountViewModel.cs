using Mov.WpfControls.ViewModels;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Services.Dialogs;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using Stocker.Wpf.Models.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Stocker.Wpf.ViewModels.Login
{
    public class CreateAccountViewModel : RegionViewModelBase
    {
        #region フィールド;

        public ReactivePropertySlim<string> RegisteredLoginId = new ReactivePropertySlim<string>();

        public bool IsUseRequest { get; set; }

        #endregion

        #region コマンド

        public ReactiveCommand LoginMainContentCommand = new ReactiveCommand();

        public ReactiveCommand GoBackCommand = new ReactiveCommand();

        public ReactiveCommand<object> VerityCommand = new ReactiveCommand<object>();

        #endregion

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="regionManager"></param>
        /// <param name="dialogService"></param>
        public CreateAccountViewModel(IRegionManager regionManager, IDialogService dialogService) : base(regionManager, dialogService)
        {
            LoginMainContentCommand.Subscribe(OnLoginMainContentCommand).AddTo(Disposables);
            GoBackCommand.Subscribe(OnGoBackCommand).AddTo(Disposables);
            VerityCommand.Subscribe(OnVerityCommand).AddTo(Disposables);
        }

        #region メソッド

        void OnGoBackCommand()
        {
            Journal.GoBack();
        }

        void OnLoginMainContentCommand()
        {
            Navigate("LoginMainContent");
        }

        void OnVerityCommand(object parameter)
        {
            if (!VerityRegister(parameter))
            {
                return;
            }
            this.IsUseRequest = true;
            var Title = string.Empty;
            DialogService.ShowDialog("SuccessDialog", new DialogParameters($"message={"登録成功"}"), null);
            Journal.GoBack();
        }

        private bool VerityRegister(object parameter)
        {
            if (string.IsNullOrEmpty(this.RegisteredLoginId.Value))
            {
                MessageBox.Show("LoginIdが空白です！");
                return false;
            }
            var passwords = parameter as Dictionary<string, PasswordBox>;
            var password = (passwords["Password"] as PasswordBox).Password;
            var confimPassword = (passwords["ConfirmPassword"] as PasswordBox).Password;
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Passwordが空白です！");
                return false;
            }
            if (string.IsNullOrEmpty(confimPassword))
            {
                MessageBox.Show("ConfirmPassword パスワードを確認して下さい！");
                return false;
            }
            if (password.Trim() != confimPassword.Trim())
            {
                MessageBox.Show("アカウントが一致しません");
                return false;
            }
            //Global.AllUsers.Add(new User()
            //{
            //    Id = Global.AllUsers.Max(t => t.Id) + 1,
            //    LoginId = this.RegisteredLoginId,
            //    Password = password
            //});
            return true;
        }

        #endregion

        #region ナビゲーションメソッド

        private void Navigate(string navigatePath)
        {
            if (navigatePath != null)
                RegionManager.RequestNavigate(RegionNames.LOGIN, navigatePath);
        }

        public void ConfirmNavigationRequest(NavigationContext navigationContext, Action<bool> continuationCallback)
        {
            if (!string.IsNullOrEmpty(RegisteredLoginId.Value) && this.IsUseRequest)
            {
                DialogService.ShowDialog("AlertDialog", new DialogParameters($"message={"登録してもいいですか？"}"), r =>
                {
                    if (r.Result == ButtonResult.Yes)
                        navigationContext.Parameters.Add("loginId", RegisteredLoginId);
                });
            }
            continuationCallback(true);
            
        }

        #endregion

    }
}

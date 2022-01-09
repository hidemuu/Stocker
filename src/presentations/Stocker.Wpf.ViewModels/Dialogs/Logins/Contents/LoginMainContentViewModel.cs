using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Services.Dialogs;
using Mov.Designer.Models;
using Mov.Configurator.Models;
using Stocker.Wpf.Models.Constants;
using Mov.WpfControls.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Mov.Authorizer.Models;
using Reactive.Bindings;
using Mov.WpfControls.ViewModels;
using Reactive.Bindings.Extensions;

namespace Stocker.Wpf.ViewModels.Login
{
    public class LoginMainContentViewModel : RegionViewModelBase
    {
        #region フィールド

        public ReactivePropertySlim<bool> IsCanExcute = new ReactivePropertySlim<bool>();
        
        public ReactivePropertySlim<User> CurrentUser = new ReactivePropertySlim<User>();


        #endregion

        #region コマンド

        public ReactiveCommand CreateAccountCommand = new ReactiveCommand();
            
        public ReactiveCommand GoForwardCommand = new ReactiveCommand();
        
        private DelegateCommand<PasswordBox> _loginCommand;
        public DelegateCommand<PasswordBox> LoginCommand =>
            _loginCommand ?? (_loginCommand = new DelegateCommand<PasswordBox>(OnLoginCommand, CanExecuteGoForwardCommand));

        #endregion

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="regionManager"></param>
        /// <param name="dialogService"></param>
        public LoginMainContentViewModel(IRegionManager regionManager, IDialogService dialogService) : base(regionManager, dialogService)
        {
            CreateAccountCommand.Subscribe(OnCreateAccountCommand).AddTo(Disposables);
            GoForwardCommand.Subscribe(OnGoForwardCommand).AddTo(Disposables);
        }


        #region メソッド

        void OnCreateAccountCommand()
        {
            Navigate("CreateAccount");
        }
        void OnLoginCommand(PasswordBox passwordBox)
        {
            if(this.CurrentUser.Value == null)
            {
                return;
            }
            if (string.IsNullOrEmpty(this.CurrentUser.Value.LoginId))
            {
                DialogService.Show("WarningDialog", new DialogParameters($"message={"LoginIdを入力して下さい!"}"), null);
                return;
            }
            this.CurrentUser.Value.Password = passwordBox.Password;
            if (string.IsNullOrEmpty(this.CurrentUser.Value.Password))
            {
                DialogService.Show("WarningDialog", new DialogParameters($"message={"Passwordを入力して下さい!"}"), null);
                return;
            }
            //else if (Global.AllUsers.Where(t => t.LoginId == this.CurrentUser.LoginId && t.Password == this.CurrentUser.Password).Count() == 0)
            //{
            //    dialogService.Show("WarningDialog", new DialogParameters($"message={"LoginIdかPasswordが一致しません!"}"), null);
            //    return;
            //}
            //ShellSwitcher.Switch<LoginWindow, MainWindow>();
        }

        private void OnGoForwardCommand()
        {
            Journal.GoForward();
        }

        #endregion

        #region ナビゲーションメソッド

        private void Navigate(string navigatePath)
        {
            if (navigatePath != null)
                RegionManager.RequestNavigate(RegionNames.LOGIN, navigatePath);
        }



        private bool CanExecuteGoForwardCommand(PasswordBox passwordBox)
        {
            this.IsCanExcute.Value = Journal != null && Journal.CanGoForward;
            return true;
        }

        

        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            base.OnNavigatedTo(navigationContext);

            var loginId = navigationContext.Parameters["loginId"] as string;
            if (loginId != null)
            {
                this.CurrentUser.Value = new User() { LoginId = loginId };
            }
            LoginCommand.RaiseCanExecuteChanged();
        }

        #endregion

    }
}

using Mov.WpfControls.ViewModels;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocker.Wpf.ViewModels.Dialogs
{
    public class AlertDialogViewModel : DialogViewModelBase
    {

        #region フィールド

        public override string Title => "Notification";

        public ReactivePropertySlim<string> Message { get; } = new ReactivePropertySlim<string>();

        #endregion

        #region コマンド

        public ReactiveCommand<string> RequestCloseCommand { get; } = new ReactiveCommand<string>();

        #endregion

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public AlertDialogViewModel()
        {
            RequestCloseCommand.Subscribe(OnRequestClose).AddTo(Disposables);
        }

        void OnRequestClose(string parameter)
        {
            ButtonResult result = ButtonResult.None;

            if (parameter?.ToLower() == "true")
                result = ButtonResult.Yes;
            else if (parameter?.ToLower() == "false")
                result = ButtonResult.No;
            else
                result = ButtonResult.None;
            RequestCloseInvoke(new DialogResult(result));
            
        }

        public override void OnDialogOpened(IDialogParameters parameters)
        {
            Message.Value = parameters.GetValue<string>("message");
        }

    }
}

using Mov.WpfControls.ViewModels;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocker.Wpf.ViewModels.Dialogs
{
    public class WarningDialogViewModel : DialogViewModelBase
    {
        #region フィールド

        public override string Title => "Notification";
        
        public ReactivePropertySlim<string> Message { get; } = new ReactivePropertySlim<string>();

        #endregion

        #region コマンド

        

        #endregion

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public WarningDialogViewModel()
        {
            
        }

        #region メソッド

        protected async override void OnLoaded()
        {
            await Task.Delay(2000);
            RequestCloseInvoke(new DialogResult(ButtonResult.No));
        }

        public override void OnDialogOpened(IDialogParameters parameters)
        {
            Message.Value = parameters.GetValue<string>("message");
        }

        #endregion

    }
}

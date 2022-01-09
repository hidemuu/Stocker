﻿using Mov.WpfControls.ViewModels;
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
    public class SuccessDialogViewModel : DialogViewModelBase
    {

        #region フィールド

        public override string Title => "Notification";
        
        public ReactivePropertySlim<string> Message = new ReactivePropertySlim<string>();

        #endregion

        #region コマンド

        
        #endregion

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public SuccessDialogViewModel()
        {
           
        }

        #region メソッド

        protected override async void OnLoaded()
        {
            ButtonResult result = ButtonResult.No;
            await Task.Delay(2000);
            RequestCloseInvoke(new DialogResult(result));
        }

        public override void OnDialogOpened(IDialogParameters parameters)
        {
            Message.Value = parameters.GetValue<string>("message");
        }

        #endregion

    }
}

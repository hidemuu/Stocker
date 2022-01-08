using Prism.Mvvm;
using Prism.Regions;
using Reactive.Bindings;
using Mov.WpfControls.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocker.Wpf.ViewModels.Panels
{
    public class DashboardViewModel : BindableBase
    {
        #region フィールド

        private readonly IRegionManager regionManager;

        #endregion

        #region プロパティ

        public bool KeepAlive => true;

        #endregion

        #region コマンド


        #endregion

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public DashboardViewModel(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

    }
}

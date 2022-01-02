using MaterialDesignColors;
using Prism.Mvvm;
using Reactive.Bindings;
using Stocker.Wpf.Models;
using Stocker.Wpf.ViewModels.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocker.Wpf.ViewModels.Panels
{
    public class SettingViewModel : BindableBase, ISettingViewModel
    {

        #region プロパティ
        public Swatch[] Swatches { get; } = new SwatchesProvider().Swatches.ToArray();

        public ReactivePropertySlim<Swatch> SelectedSwatch { get; }

        public ReactivePropertySlim<string> BackupPath { get; }

        #endregion

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public SettingViewModel()
        {
            // ComboBoxの初期値を設定するにはItemsSourceで利用しているインスタンスの中から指定する必要がある
            SelectedSwatch = new ReactivePropertySlim<Swatch>(Swatches.FirstOrDefault(s => s.Name == ThemeService.CurrentTheme.Name));
            SelectedSwatch.Subscribe(s => ChangeTheme(s));

            var backupPath = "";
            BackupPath = new ReactivePropertySlim<string>(backupPath);
        }

        #region メソッド

        public void RegistBackupPath()
        {
            if (Directory.Exists(BackupPath.Value) == false)
            {
                return;
            }
        }

        public void RegistImportURL()
        {

        }


        public void ShutDown()
        {

        }

        #endregion


        #region 内部メソッド

        private void ChangeTheme(Swatch swatch)
        {
            ThemeService.ApplyTheme(swatch);
        }

        #endregion


    }
}

using MaterialDesignColors;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocker.Wpf.Models
{
    public interface ISettingViewModel
    {
        public Swatch[] Swatches { get; }

        public ReactivePropertySlim<Swatch> SelectedSwatch { get; }

        public ReactivePropertySlim<string> BackupPath { get; }
    }
}

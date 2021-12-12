using Prism.Mvvm;
using Reactive.Bindings;
using Stocker.Models;
using Stocker.Wpf.Models.Panels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocker.Wpf.ViewModels.Panels
{
    public class LineItemTableViewModel : RepositoryViewModelBase
    {
        public ReactiveCollection<LineItemModel> Models { get; } = new ReactiveCollection<LineItemModel>();

        public LineItemTableViewModel(IStockerRepository repository) : base(repository)
        {
            
        }

        protected override void OnLoaded()
        {

        }
    }
}

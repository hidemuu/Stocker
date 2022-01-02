using Prism.Mvvm;
using Reactive.Bindings;
using Stocker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocker.Wpf.ViewModels
{
    public abstract class ViewModelBase : BindableBase
    {
        protected readonly IStockerRepository repository;

        public ReactiveCommand LoadedCommand { get; } = new ReactiveCommand();

        public ViewModelBase(IStockerRepository repository)
        {
            this.repository = repository;
            LoadedCommand.Subscribe(() => OnLoaded());
        }

        protected abstract void OnLoaded();
    }
}

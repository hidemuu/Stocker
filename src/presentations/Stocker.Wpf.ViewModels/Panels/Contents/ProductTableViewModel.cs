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
    public class ProductTableViewModel : RepositoryViewModelBase
    {
        public ReactiveCollection<ProductModel> Models { get; } = new ReactiveCollection<ProductModel>();

        public ProductTableViewModel(IStockerRepository repository) : base(repository)
        {
            var task = this.repository.Products.GetAsync();
            Task.WaitAll(task);
            foreach(var item in task.Result)
            {
                Models.Add(new ProductModel(item));
            }
        }

        protected override void OnLoaded()
        {

        }
    }
}

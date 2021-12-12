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
    public class CustomerTableViewModel : RepositoryViewModelBase
    {
        public ReactiveCollection<CustomerModel> Models { get; } = new ReactiveCollection<CustomerModel>();

        public CustomerTableViewModel(IStockerRepository repository) : base(repository)
        {
            var task = this.repository.Customers.GetAsync();
            Task.WaitAll(task);
            foreach (var item in task.Result)
            {
                Models.Add(new CustomerModel(item));
            }
        }

        protected override void OnLoaded()
        {

        }
    }
}

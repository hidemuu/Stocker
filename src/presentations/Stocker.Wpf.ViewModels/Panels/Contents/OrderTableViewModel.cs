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
    public class OrderTableViewModel : RepositoryViewModelBase
    {
        public ReactiveCollection<OrderModel> Models { get; } = new ReactiveCollection<OrderModel>();

        public OrderTableViewModel(IStockerRepository repository) : base(repository)
        {
            var task = this.repository.Orders.GetAsync();
            Task.WaitAll(task);
            foreach (var item in task.Result)
            {
                Models.Add(new OrderModel(item));
            }
        }

        protected override void OnLoaded()
        {

        }
    }
}

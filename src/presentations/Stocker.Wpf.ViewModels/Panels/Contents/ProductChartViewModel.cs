using LiveCharts;
using LiveCharts.Wpf;
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
    public class ProductChartViewModel : RepositoryViewModelBase
    {
        public ReactivePropertySlim<SeriesCollection> Series { get; private set; }
        public ReactiveCollection<ProductModel> Models { get; } = new ReactiveCollection<ProductModel>();

        public ProductChartViewModel(IStockerRepository repository) : base(repository)
        {
            var task = this.repository.Products.GetAsync();
            Task.WaitAll(task);
            foreach (var item in task.Result)
            {
                Models.Add(new ProductModel(item));
            }

            Series = new ReactivePropertySlim<SeriesCollection>(new SeriesCollection
            {
                new LineSeries
                {
                    //Title = Models.FirstOrDefault(x => x.Title.Value ==  "patient").Title.Value,
                    //Values = Models.FirstOrDefault(x => x.Title.Value ==  "patient").ChartValues.Value,
                    //Stroke = System.Windows.Media.Brushes.Blue,
                    //Fill = Brushes.Transparent
                },
                new LineSeries
                {
                    //Title = Models.FirstOrDefault(x => x.Title.Value ==  "death").Title.Value,
                    //Values = Models.FirstOrDefault(x => x.Title.Value ==  "death").ChartValues.Value,
                },
            });
        }

        protected override void OnLoaded()
        {

        }
    }
}

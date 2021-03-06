using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocker.Wpf.Models.Tables
{
    public interface ITableViewModel
    {
        public ReactiveCollection<TableModel> Models { get; }

        public TableAttribute Attribute { get; }
    }
}

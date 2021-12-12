using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocker.Wpf.Models.Panels
{
    public class ToolModel
    {
        public ReactivePropertySlim<int> Index { get; set; } = new ReactivePropertySlim<int>();
        public ReactivePropertySlim<string> Name { get; set; } = new ReactivePropertySlim<string>();
    }
}

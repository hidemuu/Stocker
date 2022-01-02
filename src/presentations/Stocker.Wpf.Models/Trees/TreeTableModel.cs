using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocker.Wpf.Models.Trees
{
    public class TreeTableModel
    {
        public ReactivePropertySlim<int> Index { get; } = new ReactivePropertySlim<int>();
        public ReactivePropertySlim<string> NodeType { get; } = new ReactivePropertySlim<string>();
        public ReactivePropertySlim<string> Name { get; } = new ReactivePropertySlim<string>();
        public ReactivePropertySlim<bool> IsExpanded { get; } = new ReactivePropertySlim<bool>(true);
        public List<TreeTableModel> Children { get; set; } = new List<TreeTableModel>();


    }
}

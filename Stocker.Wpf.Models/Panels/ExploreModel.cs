﻿using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocker.Wpf.Models.Panels
{
    public class ExploreModel
    {
        public ReactivePropertySlim<int> Index { get; set; } = new ReactivePropertySlim<int>();
        public ReactivePropertySlim<string> NodeType { get; set; } = new ReactivePropertySlim<string>();
        public ReactivePropertySlim<string> Name { get; set; } = new ReactivePropertySlim<string>();

        public ExploreModel(int index, string nodeType, string name)
        {
            Index.Value = index;
            NodeType.Value = nodeType;
            Name.Value = name;
        }

    }
}

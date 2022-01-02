﻿using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocker.Wpf.Models.Trees
{
    public interface ITreeTableViewModel
    {
        ReactiveCollection<TreeTableModel> Models { get; }
    }
}

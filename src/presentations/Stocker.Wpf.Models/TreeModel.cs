using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocker.Wpf.Models
{
    public class TreeModel<T>
    {
        public T Parent { get; set; }
        public List<TreeModel<T>> Children { get; set; } = new List<TreeModel<T>>();

    }
}

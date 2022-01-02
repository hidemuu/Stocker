using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocker.Wpf.Models.Trees
{
    public class DemoTreeTableModel : TreeTableModel
    {
        public DemoTreeTableModel(int index, string name, string nodeType) : base()
        {
            Index.Value = index;
            Name.Value = name;
            NodeType.Value = nodeType;
        }
    }
}

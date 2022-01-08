using Mov.Designer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocker.Wpf.Models.Trees
{
    public class LayoutTreeTableModel : TreeTableModel
    {
        public LayoutTreeTableModel(LayoutTree layoutTree)
        {
            Index.Value = layoutTree.Id;
            NodeType.Value = layoutTree.NodeType;
            Name.Value = layoutTree.Name;
            foreach(var layout in layoutTree.Children)
            {
                Children.Add(new LayoutTreeTableModel(layout));
            }
        }
    }
}

using Prism.Mvvm;
using Reactive.Bindings;
using Mov.Designer.Models;
using Stocker.Wpf.Models;
using Stocker.Wpf.Models.Trees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocker.Wpf.ViewModels.Panels
{
    public class TreeTableViewModel : BindableBase, ITreeTableViewModel
    {

        public ReactiveCollection<TreeTableModel> Models { get; private set; } = new ReactiveCollection<TreeTableModel>();

        public TreeTableViewModel(IDesignerRepository designerRepository)
        {
            var layoutTree = designerRepository.Layouts.Get();
            Models.Clear();
            Models.Add(new LayoutTreeTableModel(layoutTree));
        }

        public void MakeDemoModel()
        {
            Models.Add(new DemoTreeTableModel(0, "", "Root")
            {
                Children = new List<TreeTableModel>
                {
                    new DemoTreeTableModel(1, "", "Test1")
                    {
                        Children = new List<TreeTableModel>
                        {
                            new DemoTreeTableModel(2, "", "Test12")
                            {
                                
                            }
                        }
                    },
                    new DemoTreeTableModel(1, "", "Test2")
                    {

                    }
                }
            }); 
        }
    }
}

using Prism.Mvvm;
using Reactive.Bindings;
using Designer.Models;
using Stocker.Wpf.Models;
using Stocker.Wpf.Models.Panels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocker.Wpf.ViewModels.Panels
{
    public class ExploreViewModel : BindableBase
    {

        public ReactiveCollection<TreeModel<ExploreModel>> Models { get; private set; } = new ReactiveCollection<TreeModel<ExploreModel>>();


        public ExploreViewModel(IDesignRepository guiRepository)
        {
            var exploreTree = guiRepository.Explores.Get();
            MakeDemoModel();
        }

        public void MakeDemoModel()
        {
            Models.Add(new TreeModel<ExploreModel>
            {
                Parent = new ExploreModel(0, "", "Root"),
                Children = new List<TreeModel<ExploreModel>>
                {
                    new TreeModel<ExploreModel>
                    {
                        Parent = new ExploreModel(1, "", "Test1"),
                        Children = new List<TreeModel<ExploreModel>>
                        {
                            new TreeModel<ExploreModel>
                            {
                                Parent = new ExploreModel(2, "", "Test12")
                            }
                        }
                    },
                    new TreeModel<ExploreModel>
                    {
                        Parent = new ExploreModel(1, "", "Test2")
                    }
                }
            }); 
        }
    }
}

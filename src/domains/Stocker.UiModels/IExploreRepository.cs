using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stocker.GuiModels
{
    public interface IExploreRepository
    {
        ExploreTree Get();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Stocker.GuiModels
{
    public interface IGuiRepository
    {
        IExploreRepository Explores { get; }
    }
}

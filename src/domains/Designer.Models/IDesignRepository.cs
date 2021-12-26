using System;
using System.Collections.Generic;
using System.Text;

namespace Designer.Models
{
    public interface IDesignRepository
    {
        IExploreRepository Explores { get; }
    }
}

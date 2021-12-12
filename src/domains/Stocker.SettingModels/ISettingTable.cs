using System;
using System.Collections.Generic;
using System.Text;

namespace Stocker.SettingModels
{
    public interface ISettingTable<T>
    {
        IEnumerable<T> Items { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Configurator.Models
{
    public interface ISettingTable<T>
    {
        IEnumerable<T> Items { get; set; }
    }
}

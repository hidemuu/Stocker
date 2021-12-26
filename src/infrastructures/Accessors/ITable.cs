using System;
using System.Collections.Generic;
using System.Text;

namespace Accessors
{
    public interface ITable<T>
    {
        IEnumerable<T> Items { get; set; }
    }
}

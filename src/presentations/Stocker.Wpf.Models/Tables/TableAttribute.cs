using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocker.Wpf.Models.Tables
{
    public class TableAttribute
    {
        public TableAttributeItem Id { get; } = new TableAttributeItem("id", true);

        public TableAttributeItem Category { get; } = new TableAttributeItem("category", true);

        public TableAttributeItem Code { get; } = new TableAttributeItem("code", true);

        public TableAttributeItem Name { get; } = new TableAttributeItem("name", true);

        public TableAttributeItem Description { get; } = new TableAttributeItem("description", true);

        public TableAttributeItem Reference { get; } = new TableAttributeItem("reference", true);
    }

    public class TableAttributeItem
    {       
        public ReactivePropertySlim<string> Header { get; } = new ReactivePropertySlim<string>("");

        public ReactivePropertySlim<bool> IsVisible { get; } = new ReactivePropertySlim<bool>(true);

        public TableAttributeItem(string header, bool isVisible)
        {
            Header.Value = header;
            IsVisible.Value = isVisible;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Stocker.GuiModels
{
    public class ToolTable
    {
        public List<Tool> Tools { get; set; }
    }

    public class Tool
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Designer.Models
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

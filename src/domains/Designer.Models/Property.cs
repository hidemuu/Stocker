using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Designer.Models
{
    public class PropertyTree
    {
        public Property Parent { get; set; }
        public List<PropertyTree> Children { get; set; }
    }

    public class Property
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NodeType { get; set; }
    }
}

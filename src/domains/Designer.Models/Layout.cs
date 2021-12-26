using Accessors;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Designer.Models
{
    [XmlRoot("tree")]
    public class LayoutTree
    {
        [XmlElement("parent")]
        public Layout Parent { get; set; }
        [XmlArray("children")]
        [XmlArrayItem("tree")]
        public List<LayoutTree> Children { get; set; }
    }
    [XmlRoot("layout")]
    public class Layout
    {
        [XmlElement("id")]
        public int Id { get; set; }
        [XmlElement("name")]
        public string Name { get; set; }
        [XmlElement("nodetype")]
        public string NodeType { get; set; }
    }
}

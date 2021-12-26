using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Designer.Models
{
    [XmlRoot("tree")]
    public class ExploreTree
    {
        [XmlElement("parent")]
        public Explore Parent { get; set; }
        [XmlArray("children")]
        [XmlArrayItem("tree")]
        public List<ExploreTree> Children { get; set; }
    }
    [XmlRoot("explore")]
    public class Explore
    {
        [XmlElement("id")]
        public int Id { get; set; }
        [XmlElement("name")]
        public string Name { get; set; }
        [XmlElement("nodetype")]
        public string NodeType { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Designer.Models
{
    [XmlRoot("tree")]
    public interface IDesignTree<T>
    {
        [XmlElement("parent")]
        T Parent { get; set; }
        [XmlArray("children")]
        [XmlArrayItem("tree")]
        List<IDesignTree<T>> Children { get; set; }
    }
}

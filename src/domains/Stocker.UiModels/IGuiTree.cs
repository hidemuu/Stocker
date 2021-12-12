using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Stocker.GuiModels
{
    [XmlRoot("tree")]
    public interface IGuiTree<T>
    {
        [XmlElement("parent")]
        T Parent { get; set; }
        [XmlArray("children")]
        [XmlArrayItem("tree")]
        List<IGuiTree<T>> Children { get; set; }
    }
}

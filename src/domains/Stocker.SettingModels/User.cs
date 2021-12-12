using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Stocker.SettingModels
{
    [XmlRoot("root")]
    public class UserDb : ISettingTable<User>
    {
        [XmlArray("users")]
        [XmlArrayItem("user")]
        public IEnumerable<User> Items { get; set; }
    }
    [XmlRoot("user")]
    public class User
    {
        [XmlElement("id")]
        public int Id { get; set; }
        [XmlElement("loginid")]
        public string LoginId { get; set; }
        [XmlElement("password")]
        public string Password { get; set; }
    }
}

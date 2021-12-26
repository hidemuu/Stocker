using Accessors;
using Configurator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Configurator.Repository.Xml
{
    public class XmlSettingRepository : ISettingRepository
    {
        private readonly string path;
        private readonly string encode;
        public XmlSettingRepository(string path, string encode = "utf-8")
        {
            this.path = path;
            this.encode = encode;
        }

        public IUserRepository Users => new XmlUserRepository(new XmlFileHelper(path + "User.xml"));
    }
}

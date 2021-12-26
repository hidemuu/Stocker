using Accessors;
using Configurator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Configurator.Repository.Xml
{
    public class XmlConfiguratorRepository : IConfiguratorRepository
    {
        private readonly string path;
        private readonly string encode;
        public XmlConfiguratorRepository(string path, string encode = "utf-8")
        {
            this.path = path;
            this.encode = encode;
        }

    }
}

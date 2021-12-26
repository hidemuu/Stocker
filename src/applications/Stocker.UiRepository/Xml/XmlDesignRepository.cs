using Accessors;
using Designer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Designer.Repository.Xml
{
    public class XmlDesignRepository : IDesignRepository
    {
        private readonly string path;
        private readonly string encode;
        public XmlDesignRepository(string path, string encode = "utf-8")
        {
            this.path = path;
            this.encode = encode;
        }

        public IExploreRepository Explores => new XmlExploreRepository(new XmlFileHelper(path + "Explore.xml"));

    }
}

using Accessors;
using Designer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Designer.Repository.Xml
{
    public class XmlDesignerRepository : IDesignerRepository
    {
        private readonly string path;
        private readonly string encode;
        public XmlDesignerRepository(string path, string encode = "utf-8")
        {
            this.path = path;
            this.encode = encode;
        }

        public ILayoutRepository Layouts => new XmlLayoutRepository(new XmlFileHelper(path + "Layout.xml"));

    }
}

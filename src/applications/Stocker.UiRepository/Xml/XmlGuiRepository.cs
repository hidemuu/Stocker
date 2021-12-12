using Stocker.Accessors;
using Stocker.GuiModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stocker.GuiRepository.Xml
{
    public class XmlGuiRepository : IGuiRepository
    {
        private readonly string path;
        private readonly string encode;
        public XmlGuiRepository(string path, string encode = "utf-8")
        {
            this.path = path;
            this.encode = encode;
        }

        public IExploreRepository Explores => new XmlExploreRepository(new XmlFileHelper(path + "Explore.xml"));

    }
}

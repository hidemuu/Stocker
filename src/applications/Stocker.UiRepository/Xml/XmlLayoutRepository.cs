using Accessors;
using Designer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Designer.Repository.Xml
{
    public class XmlLayoutRepository : DesignerRepositoryBase<LayoutTree>, ILayoutRepository
    {
        public XmlLayoutRepository(XmlFileHelper fileHelper) : base(fileHelper)
        {
        }
    }
}

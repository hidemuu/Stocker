using Accessors;
using Designer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Designer.Repository.Xml
{
    public class XmlExploreRepository : DesignRepositoryBase<ExploreTree>, IExploreRepository
    {
        public XmlExploreRepository(XmlFileHelper fileHelper) : base(fileHelper)
        {

        }
    }
}

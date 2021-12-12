using Stocker.Accessors;
using Stocker.GuiModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stocker.GuiRepository.Xml
{
    public class XmlExploreRepository : GuiRepositoryBase<ExploreTree>, IExploreRepository
    {
        public XmlExploreRepository(XmlFileHelper fileHelper) : base(fileHelper)
        {

        }
    }
}

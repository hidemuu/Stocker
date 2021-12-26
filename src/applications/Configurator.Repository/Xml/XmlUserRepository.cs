using Accessors;
using Configurator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Configurator.Repository.Xml
{
    public class XmlUserRepository : SettingRepositoryBase<User>, IUserRepository
    {
        public XmlUserRepository(XmlFileHelper fileHelper) : base(fileHelper)
        {

        }
    }
}

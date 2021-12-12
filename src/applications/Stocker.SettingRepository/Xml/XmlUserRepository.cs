using Stocker.Accessors;
using Stocker.SettingModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stocker.SettingRepository.Xml
{
    public class XmlUserRepository : SettingRepositoryBase<User>, IUserRepository
    {
        public XmlUserRepository(XmlFileHelper fileHelper) : base(fileHelper)
        {

        }
    }
}

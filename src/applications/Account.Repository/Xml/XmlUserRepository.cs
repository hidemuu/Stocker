using Accessors;
using Account.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Account.Repository.Xml
{
    public class XmlUserRepository : AccountRepositoryBase<User>, IUserRepository
    {
        public XmlUserRepository(XmlFileHelper fileHelper) : base(fileHelper)
        {

        }
    }
}

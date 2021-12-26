using Accessors;
using Account.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Account.Repository.Xml
{
    public class XmlAccountRepository : IAccountRepository
    {
        private readonly string path;
        private readonly string encode;
        public XmlAccountRepository(string path, string encode = "utf-8")
        {
            this.path = path;
            this.encode = encode;
        }

        public IUserRepository Users => new XmlUserRepository(new XmlFileHelper(path + "User.xml"));
    }
}

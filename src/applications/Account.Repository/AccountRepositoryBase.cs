using Accessors;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Account.Repository
{
    public abstract class AccountRepositoryBase<T>
    {
        private readonly IFileHelper fileHelper;
        public AccountRepositoryBase(IFileHelper fileHelper)
        {
            this.fileHelper = fileHelper;
        }
        public async Task<IEnumerable<T>> GetAsync()
        {
            return (await Task.Run(() => fileHelper.Read<ITable<T>>())).Items;
        }
    }
}

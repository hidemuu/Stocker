using Stocker.Accessors;
using Stocker.SettingModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stocker.SettingRepository
{
    public abstract class SettingRepositoryBase<T>
    {
        private readonly IFileHelper fileHelper;
        public SettingRepositoryBase(IFileHelper fileHelper)
        {
            this.fileHelper = fileHelper;
        }
        public async Task<IEnumerable<T>> GetAsync()
        {
            return (await Task.Run(() => fileHelper.Read<ISettingTable<T>>())).Items;
        }
    }
}

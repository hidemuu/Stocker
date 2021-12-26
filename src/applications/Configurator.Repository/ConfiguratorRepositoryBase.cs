using Accessors;
using Configurator.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Configurator.Repository
{
    public abstract class ConfiguratorRepositoryBase<T>
    {
        private readonly IFileHelper fileHelper;
        public ConfiguratorRepositoryBase(IFileHelper fileHelper)
        {
            this.fileHelper = fileHelper;
        }
        public async Task<IEnumerable<T>> GetAsync()
        {
            return (await Task.Run(() => fileHelper.Read<ITable<T>>())).Items;
        }
    }
}

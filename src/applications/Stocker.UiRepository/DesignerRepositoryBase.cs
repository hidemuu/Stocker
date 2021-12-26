using Accessors;
using Designer.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Designer.Repository
{
    public abstract class DesignerRepositoryBase<T>
    {
        private readonly IFileHelper fileHelper;
        public DesignerRepositoryBase(IFileHelper fileHelper)
        {
            this.fileHelper = fileHelper;
        }
        public T Get()
        {
            return fileHelper.Read<T>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Accessors
{
    public abstract class FileAccessor<T>
    {
        private readonly IFileHelper fileHelper;
        public FileAccessor(IFileHelper fileHelper)
        {
            this.fileHelper = fileHelper;
        }
        public T Get()
        {
            return fileHelper.Read<T>();
        }
    }
}

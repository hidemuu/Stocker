using Stocker.Accessors;
using Stocker.GuiModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stocker.GuiRepository
{
    public abstract class GuiRepositoryBase<T>
    {
        private readonly IFileHelper fileHelper;
        public GuiRepositoryBase(IFileHelper fileHelper)
        {
            this.fileHelper = fileHelper;
        }
        public T Get()
        {
            return fileHelper.Read<T>();
        }
    }
}

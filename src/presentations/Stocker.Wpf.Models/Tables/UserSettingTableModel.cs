using Mov.Configurator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocker.Wpf.Models.Tables
{
    public class UserSettingTableModel : TableModel
    {
        public UserSettingTableModel(UserSetting userSetting)
        {
            Id.Value = userSetting.Id;
            Category.Value = userSetting.Category;
            Name.Value = userSetting.Name;
            Code.Value = userSetting.Code;
            Description.Value = userSetting.Description;
            Reference.Value = userSetting.Value;
        }
    }
}

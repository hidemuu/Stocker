using Mov.Authorizer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocker.Wpf.Models.Tables
{
    public class UserTableModel : TableModel
    {
        public UserTableModel(User user)
        {
            Id.Value = user.Id;
            Name.Value = user.Password;
            Code.Value = user.LoginId;
        }
    }
}

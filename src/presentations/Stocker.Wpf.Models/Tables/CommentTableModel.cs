using Language.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocker.Wpf.Models.Tables
{
    public class CommentTableModel : TableModel
    {
        public CommentTableModel(Comment comment)
        {
            Id.Value = comment.Id;
            Category.Value = comment.Category;
            Code.Value = comment.Code;
            Name.Value = comment.JP;
        }
    }
}

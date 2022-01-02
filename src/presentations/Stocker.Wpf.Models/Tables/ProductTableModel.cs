using Reactive.Bindings;
using Stocker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocker.Wpf.Models.Tables
{
    public class ProductTableModel : TableModel
    {
        
        /// <summary>
        /// コンストラクター 
        /// </summary>
        public ProductTableModel(Product product)
        {
            Id.Value = (int)product.Index;
            Category.Value = product.Category;
            Name.Value = product.Name;
            Code.Value = product.Code;
            Description.Value = product.Maker;
            Reference.Value = product.Url;
        }
    }
}

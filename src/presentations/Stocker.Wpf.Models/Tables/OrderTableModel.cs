using Reactive.Bindings;
using Stocker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocker.Wpf.Models.Tables
{
    public class OrderTableModel : TableModel
    {
        
        /// <summary>
        /// コンストラクター 
        /// </summary>
        public OrderTableModel(Order order)
        {
            Id.Value = order.InvoiceNumber;
            Name.Value = order.CustomerName;
            Description.Value = order.Address;
        }
    }
}

using Reactive.Bindings;
using Stocker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocker.Wpf.Models.Tables
{
    public class CustomerTableModel : TableModel
    {
        /// <summary>
        /// コンストラクター 
        /// </summary>
        public CustomerTableModel(Customer customer)
        {
            Name.Value = customer.ToString();
            Description.Value = customer.Company + customer.Email + customer.Phone + customer.Address;
        }
    }
}

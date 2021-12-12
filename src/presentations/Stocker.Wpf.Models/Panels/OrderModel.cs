using Reactive.Bindings;
using Stocker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocker.Wpf.Models.Panels
{
    public class OrderModel
    {
        /// <summary>
        /// Gets or sets the name of the customer placing the order.
        /// </summary>
        public ReactivePropertySlim<string> CustomerName { get; } = new ReactivePropertySlim<string>();

        /// <summary>
        /// Gets or sets the invoice number.
        /// </summary>
        public ReactivePropertySlim<int> InvoiceNumber { get; } = new ReactivePropertySlim<int>();

        /// <summary>
        /// Gets or sets the order shipping address.
        /// </summary>
        public ReactivePropertySlim<string> Address { get; } = new ReactivePropertySlim<string>();

        /// <summary>
        /// コンストラクター 
        /// </summary>
        public OrderModel(Order order)
        {
            CustomerName.Value = order.CustomerName;
            InvoiceNumber.Value = order.InvoiceNumber;
            Address.Value = order.Address;
        }
    }
}

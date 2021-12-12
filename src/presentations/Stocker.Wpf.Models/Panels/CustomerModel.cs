using Reactive.Bindings;
using Stocker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocker.Wpf.Models.Panels
{
    public class CustomerModel
    {
        /// <summary>
        /// Gets or sets the customer's first name.
        /// </summary>
        public ReactivePropertySlim<string> FirstName { get; } = new ReactivePropertySlim<string>();

        /// <summary>
        /// Gets or sets the customer's last name.
        /// </summary>
        public ReactivePropertySlim<string> LastName { get; } = new ReactivePropertySlim<string>();

        /// <summary>
        /// Gets or sets the customer's company.
        /// </summary>
        public ReactivePropertySlim<string> Company { get; } = new ReactivePropertySlim<string>();

        /// <summary>
        /// Gets or sets the customer's email.
        /// </summary>
        public ReactivePropertySlim<string> Email { get; } = new ReactivePropertySlim<string>();

        /// <summary>
        /// Gets or sets the customer's phone number.
        /// </summary>
        public ReactivePropertySlim<string> Phone { get; } = new ReactivePropertySlim<string>();

        /// <summary>
        /// Gets or sets the customer's address. 
        /// </summary>
        public ReactivePropertySlim<string> Address { get; } = new ReactivePropertySlim<string>();

        /// <summary>
        /// コンストラクター 
        /// </summary>
        public CustomerModel(Customer customer)
        {
            FirstName.Value = customer.FirstName;
            LastName.Value = customer.LastName;
            Company.Value = customer.Company;
            Email.Value = customer.Email;
            Phone.Value = customer.Phone;
            Address.Value = customer.Address;
        }
    }
}

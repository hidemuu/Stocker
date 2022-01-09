using Stocker.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stocker.Service
{
    public class CustomerService
    {
        private readonly ICustomerRepository repository;

        public CustomerService(ICustomerRepository repository)
        {
            this.repository = repository;
        }
    }
}

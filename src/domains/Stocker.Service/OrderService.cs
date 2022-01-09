using Stocker.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stocker.Service
{
    public class OrderService
    {
        private readonly IOrderRepository repository;

        public OrderService(IOrderRepository repository)
        {
            this.repository = repository;
        }
    }
}

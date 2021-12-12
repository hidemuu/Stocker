using Stocker.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stocker.Repository.Rest
{
    public class RestStockerRepository : IStockerRepository
    {
        private readonly string _url;

        public RestStockerRepository(string url)
        {
            _url = url;
        }

        public ICustomerRepository Customers => new RestCustomerRepository(_url);

        public IOrderRepository Orders => new RestOrderRepository(_url);

        public IProductRepository Products => new RestProductRepository(_url);
    }
}

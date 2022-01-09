using Stocker.Models;
using System;

namespace Stocker.Service
{
    public class ProductService
    {
        private readonly IProductRepository repository;

        public ProductService(IProductRepository repository)
        {
            this.repository = repository;
        }
    }
}

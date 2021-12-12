using Stocker.Accessors;
using Stocker.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stocker.Repository.Rest
{
    /// <summary>
    /// Contains methods for interacting with the customers backend using REST. 
    /// </summary>
    public class RestCustomerRepository : ICustomerRepository
    {
        private readonly HttpHelper _http;

        public RestCustomerRepository(string baseUrl)
        {
            _http = new HttpHelper(baseUrl);
        }

        public async Task<IEnumerable<Customer>> GetAsync() =>
            await _http.GetAsync<IEnumerable<Customer>>("customer");

        public async Task<IEnumerable<Customer>> GetAsync(string search) =>
            await _http.GetAsync<IEnumerable<Customer>>($"customer/search?value={search}");

        public async Task<Customer> GetAsync(Guid id) =>
            await _http.GetAsync<Customer>($"customer/{id}");

        public async Task<Customer> UpsertAsync(Customer customer) =>
            await _http.PostAsync<Customer, Customer>("customer", customer);

        public async Task DeleteAsync(Guid customerId) =>
            await _http.DeleteAsync("customer", customerId);
    }
}

using Mov.Accessors;
using Stocker.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stocker.Repository.Rest
{
    /// <summary>
    /// Contains methods for interacting with the orders backend using REST. 
    /// </summary>
    public class RestOrderRepository : IOrderRepository
    {
        private readonly HttpHelper _http;

        public RestOrderRepository(string baseUrl)
        {
            _http = new HttpHelper(baseUrl);
        }

        public async Task<IEnumerable<Order>> GetAsync() =>
            await _http.GetAsync<IEnumerable<Order>>("order");

        public async Task<Order> GetAsync(Guid id) =>
            await _http.GetAsync<Order>($"order/{id}");

        public async Task<IEnumerable<Order>> GetForCustomerAsync(Guid customerId) =>
            await _http.GetAsync<IEnumerable<Order>>($"order/customer/{customerId}");

        public async Task<IEnumerable<Order>> GetAsync(string search) =>
            await _http.GetAsync<IEnumerable<Order>>($"order/search?value={search}");

        public async Task<Order> UpsertAsync(Order order) =>
            await _http.PostAsync<Order, Order>("order", order);

        public async Task DeleteAsync(Guid orderId) =>
            await _http.DeleteAsync("order", orderId);
    }
}

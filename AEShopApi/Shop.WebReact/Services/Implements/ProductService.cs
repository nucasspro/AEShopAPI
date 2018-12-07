using Newtonsoft.Json;
using RestSharp;
using Shop.Domain.Entities;
using Shop.WebReact.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shop.WebReact.Services.Implements
{
    public class ProductService : IProductService
    {
        #region Implements

        public async Task<IEnumerable<Category>> GetCategories()
        {
            var client = new RestClient($"http://localhost:8878/api/categories");
            var request = new RestRequest(Method.GET);

            request.AddHeader("Content-Type", "application/json");
            IRestResponse response = await client.ExecuteGetTaskAsync(request);
            var data = JsonConvert.DeserializeObject<IEnumerable<Category>>(response.Content);
            return data;
        }

        public async Task<IEnumerable<Product>> GetProducts(int PageSize, int GetNumber)
        {
            var client = new RestClient($"http://localhost:8878/api/products/get/1?PageSize={PageSize}&GetNumber={GetNumber}");
            var request = new RestRequest(Method.GET);

            request.AddHeader("Content-Type", "application/json");
            IRestResponse response = await client.ExecuteGetTaskAsync(request);
            var data = JsonConvert.DeserializeObject<IEnumerable<Product>>(response.Content);
            return data;
        }

        public async Task<IEnumerable<Product>> GetProductsByCategory(int CategoryId, int PageSize, int GetNumber)
        {
            var client = new RestClient("https://localhost:5001/api/products");
            var request = new RestRequest(Method.GET);
            request.AddHeader("Content-Type", "application/json");
            IRestResponse response = await client.ExecuteGetTaskAsync(request);
            var data = JsonConvert.DeserializeObject<IEnumerable<Product>>(response.Content);

            return data;
        }

        #endregion Implements
    }
}
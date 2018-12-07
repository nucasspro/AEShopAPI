using Newtonsoft.Json;
using RestSharp;
using Shop.Domain.Entities;
using Shop.WebReact.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shop.WebReact.Services
{
    public class HomeService : IHomeService
    {
        public async Task<IEnumerable<Product>> GetProducts(int number)
        {
            var client = new RestClient("https://localhost:5001/api/products");
            var request = new RestRequest(Method.GET);
            request.AddHeader("Content-Type", "application/json");
            IRestResponse response = await client.ExecuteGetTaskAsync(request);
            var data = JsonConvert.DeserializeObject<IEnumerable<Product>>(response.Content);
            //var mapData = _mapper.Map<IEnumerable<ProductViewModel>>(data);
            //IEnumerable<Post> data = response.Content.ToList();

            return data;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;
using Shop.Domain.Entities;

namespace Shop.WebRedux.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        //[HttpGet]
        //public IEnumerable<TestModel> getProduct()
        //{
        //    var client = new RestClient("https://jsonplaceholder.typicode.com/posts");
        //    var request = new RestRequest(Method.GET);
        //    request.AddHeader("Content-Type", "application/json");
        //    IRestResponse response = client.Execute(request);
        //    var data = JsonConvert.DeserializeObject<IEnumerable<TestModel>>(response.Content);

        //    //var mapData = _mapper.Map<IEnumerable<ProductViewModel>>(data);
        //    //IEnumerable<Post> data = response.Content.ToList();

        //    return data;
        //}
        [HttpGet]
        public IEnumerable<Product> getProduct()
        {
            var client = new RestClient("https://localhost:5001/api/products");
            var request = new RestRequest(Method.GET);
            request.AddHeader("Content-Type", "application/json");
            IRestResponse response = client.Execute(request);
            var data = JsonConvert.DeserializeObject<IEnumerable<Product>>(response.Content);

            //var mapData = _mapper.Map<IEnumerable<ProductViewModel>>(data);
            //IEnumerable<Post> data = response.Content.ToList();

            return data;
        }
    }
}
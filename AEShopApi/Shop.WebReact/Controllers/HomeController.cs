using Microsoft.AspNetCore.Mvc;
using Shop.Domain.Entities;
using Shop.WebReact.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shop.WebReact.Controllers
{
    [Route("api/home")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        public readonly IHomeService _homeService;

        public HomeController(IHomeService homeService)
        {
            _homeService = homeService;
        }

        [HttpGet]
        [Route("getall")]
        public async Task<IEnumerable<Product>> GetProduct()
        {
            var products = await _homeService.GetProducts(10);
            return products;
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Shop.Domain.Entities;
using Shop.WebReact.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shop.WebReact.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        #region Variables

        public readonly IProductService _productService;

        #endregion Variables

        #region Constructor

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        #endregion Constructor

        #region GET: api/products

        [HttpGet]
        public async Task<IEnumerable<Product>> GetProducts(int PageSize = 0, int GetNumber = 12)
        {
            var data = await _productService.GetProducts(PageSize, GetNumber);
            return data;
        }

        #endregion GET: api/products

        #region GET: api/products/getbycategory/1?PageSize=0&GetNumber=12

        // List product by category
        [HttpGet("{CategoryId}")]
        public async Task<IEnumerable<Product>> GetByCategory([FromRoute] int CategoryId, [FromQuery(Name = "PageSize")] int PageSize = 0, [FromQuery(Name = "GetNumber")] int GetNumber = 12)
        {
            var data = await _productService.GetProductsByCategory(CategoryId, PageSize, GetNumber);
            return data;
        }

        #endregion GET: api/products/getbycategory/1?PageSize=0&GetNumber=12

        #region GET: api/products/getcategories

        [HttpGet]
        public async Task<IEnumerable<Category>> GetCategories()
        {
            var data = await _productService.GetCategories();
            return data;
        }

        #endregion GET: api/products/getcategories
    }
}
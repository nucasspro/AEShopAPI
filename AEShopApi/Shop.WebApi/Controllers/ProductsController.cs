using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Serilog;
using Shop.Domain.Commons;
using Shop.Domain.Entities;
using Shop.Service.Implements;
using System;
using System.Threading.Tasks;

namespace Shop.WebApi.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        #region Variables

        private readonly IProductService _productService;
        private ILogger<ProductsController> _logger;

        #endregion Variables

        #region Constructor

        public ProductsController(IProductService productService, ILogger<ProductsController> logger)
        {
            _productService = productService;
            _logger = logger;
        }

        #endregion Constructor

        #region Rest API

        #region GET: api/Products

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            _logger.LogInformation("In GetProducts(), method HttpGet ProductController");
            var products = await _productService.GetAllAsync();
            if (products == null)
            {
                _logger.LogInformation("Product null");
                return NotFound();
            }
            _logger.LogInformation("Return OK");
            return Ok(products);
        }

        #endregion GET: api/Products

        #region GET: api/Products/5

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var product = await _productService.GetByIdAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        #endregion GET: api/Products/5

        #region PUT: api/Products/5

        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct([FromRoute] int id, [FromBody] Product updateProduct)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (id != updateProduct.Id)
            {
                return BadRequest();
            }

            var product = await _productService.GetByIdAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            try
            {
                await _productService.UpdateAsync(updateProduct);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest($"Error! {e.Message}");
            }
        }

        #endregion PUT: api/Products/5

        #region POST: api/Products

        [HttpPost]
        public async Task<IActionResult> PostProduct([FromBody] Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                product.InsertedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now);
                product.UpdatedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now);
                await _productService.InsertAsync(product);
                return CreatedAtAction("GetProduct", new { id = product.Id }, product);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        #endregion POST: api/Products

        #region DELETE: api/Products/5

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var product = await _productService.GetByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            await _productService.DeleteAsync(product);

            return Ok(product);
        }

        #endregion DELETE: api/Products/5

        #endregion Rest API
    }
}
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using Shop.Common.Commons;
using Shop.Domain.Entities;
using Shop.Service.Implements;
using System;
using System.Threading.Tasks;

namespace Shop.WebApi.Controllers
{
    [Route("api/Products")]
    [ApiController]
    //[Authorize]
    public class ProductController : ControllerBase
    {
        #region Variables

        private readonly IProductService _productService;

        #endregion Variables

        #region Constructor

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        #endregion Constructor

        #region Rest API

        #region GET: api/Products

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            Log.Information("Start HttpGet GetProducts() - ProductController");
            var products = await _productService.GetAllAsync();
            if (products == null)
            {
                Log.Information("Product null");
                return NotFound();
            }
            Log.Information("End HttpGet GetProducts() - ProductController");
            return Ok(products);
        }

        #endregion GET: api/Products

        #region GET: api/Products/5

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            Log.Information($"Start HttpGet GetProduct({id}) - ProductController");
            if (!ModelState.IsValid)
            {
                Log.Information($"End HttpGet GetProduct({id}) - ProductController - BadRequest");
                return BadRequest(ModelState);
            }

            var product = await _productService.GetByIdAsync(id);

            if (product == null)
            {
                Log.Information($"End HttpGet GetProduct({id}) - ProductController - NotFound");
                return NotFound();
            }
            Log.Information($"End HttpGet GetProduct({id}) - ProductController - Done");
            return Ok(product);
        }

        #endregion GET: api/Products/5

        #region PUT: api/Products/5

        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct([FromRoute] int id, [FromBody] Product updateProduct)
        {
            if (!ModelState.IsValid)
            {
                Log.Information($"End HttpPut PutProduct({id}) - ProductController - BadRequest");
                return BadRequest(ModelState);
            }
            if (id != updateProduct.Id)
            {
                Log.Information($"End HttpPut PutProduct({id}) - ProductController - BadRequest: {id} != {updateProduct.Id}");
                return BadRequest();
            }

            var product = await _productService.GetByIdAsync(id);

            if (product == null)
            {
                Log.Information($"End HttpPut PutProduct({id}) - ProductController - NotFound");
                return NotFound();
            }

            try
            {
                await _productService.UpdateAsync(updateProduct);
                Log.Information($"End HttpPut PutProduct({id}) - ProductController - Done");
                return Ok();
            }
            catch (Exception e)
            {
                Log.Information($"End HttpPut PutProduct({id}) - ProductController - BadRequest: {e.Message}");
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
                Log.Information($"End HttpPost PostProduct({product}) - ProductController - BadRequest");
                return BadRequest(ModelState);
            }

            try
            {
                product.InsertedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now);
                product.UpdatedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now);
                await _productService.InsertAsync(product);
                Log.Information($"End HttpPost PostProduct({product}) - ProductController - Done");
                return CreatedAtAction("GetProduct", new { id = product.Id }, product);
            }
            catch (Exception e)
            {
                Log.Information($"End HttpPost PostProduct({product}) - BadRequest: {e.Message}");
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
                Log.Information($"End HttpDelete DeleteProduct({id}) - ProductController - BadRequest");
                return BadRequest(ModelState);
            }

            var product = await _productService.GetByIdAsync(id);
            if (product == null)
            {
                Log.Information($"End HttpDelete DeleteProduct({id}) - ProductController - NotFound");
                return NotFound();
            }

            await _productService.DeleteAsync(product);
            Log.Information($"End HttpDelete DeleteProduct({id}) - ProductController - Done");
            return Ok(product);
        }

        #endregion DELETE: api/Products/5

        #endregion Rest API
    }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shop.Domain;
using Shop.Domain.Entities;
using Shop.Service.Implements;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shop.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        #region Variables

        private readonly AeDbContext _context;
        private readonly IProductService _productService;

        #endregion Variables

        #region Constructor

        public ProductsController(AeDbContext context, IProductService productService)
        {
            _context = context;
            _productService = productService;
        }

        #endregion Constructor

        #region Rest API

        #region GET: api/Products

        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return _context.Products;
        }

        #endregion GET: api/Products

        #region GET: api/Products/5

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        #endregion GET: api/Products/5

        #region PUT: api/Products/5

        [HttpPut("{id}")]
        public IActionResult PutProduct([FromRoute] int id, [FromBody] Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != product.Id)
            {
                return BadRequest();
            }

            try
            {
                _productService.Update(product);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_productService.CheckExistsById(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok("Update Successfully!");
        }

        #endregion PUT: api/Products/5

        #region POST: api/Products

        [HttpPost]
        public IActionResult PostProduct([FromBody] Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _productService.Insert(product);
            return CreatedAtAction("GetProduct", new { id = product.Id }, product);
        }

        #endregion POST: api/Products

        #region DELETE: api/Products/5

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var product = _productService.GetById(id);
            if (product == null)
            {
                return NotFound();
            }

            _productService.Delete(product);

            return Ok(product);
        }

        #endregion DELETE: api/Products/5

        #endregion Rest API
    }
}
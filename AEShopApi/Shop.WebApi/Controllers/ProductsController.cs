using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Shop.Domain;
using Shop.Domain.Commons;
using Shop.Domain.Entities;
using Shop.Domain.Enumerations;
using Shop.Service.Implements;
using Shop.WebApi.FormModels;
using Shop.WebApi.ViewModels;
using Shop.WebApi.ViewModels.ModelExtensions;
using System;
using System.Collections.Generic;

namespace Shop.WebApi.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        #region Variables

        private readonly AeDbContext _context;
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        #endregion Variables

        #region Constructor

        public ProductsController(AeDbContext context, IProductService productService, IMapper mapper)
        {
            _context = context;
            _productService = productService;
            _mapper = mapper;
        }

        #endregion Constructor

        #region Rest API

        #region GET: api/Products

        [HttpGet]
        public IActionResult GetProducts()
        {
            //var products = _productService.GetAll();
            var products = _productService.GetAll();
            var newProduct = _mapper.Map<IEnumerable<ProductViewModel>>(products);
            return products == null ? NotFound() : (IActionResult)Ok(newProduct);
        }

        #endregion GET: api/Products

        #region GET: api/Products/5

        [HttpGet("{id}")]
        public IActionResult GetProduct([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var product = _mapper.Map<ProductViewModel>(_productService.GetById(id));

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        #endregion GET: api/Products/5

        #region PUT: api/Products/5

        [HttpPut("{id}")]
        public IActionResult PutProduct([FromRoute] int id, [FromBody] EditProductViewModel productViewModel)
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

            try
            {
                var updateProduct = _mapper.Map(productViewModel, product);
                _productService.Update(updateProduct);
                return Ok("Update Successfully!");
            }
            catch (Exception e)
            {
                return BadRequest($"Error! {e.Message}");
            }
        }

        #endregion PUT: api/Products/5

        #region POST: api/Products

        [HttpPost]
        public IActionResult PostProduct([FromBody] EditProductViewModel productViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var product = _mapper.Map<Product>(productViewModel);
                product.InsertedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now);
                _productService.Insert(product);
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
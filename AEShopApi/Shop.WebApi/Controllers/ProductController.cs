using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shop.Common.Commons;
using Shop.Domain.Entities;
using Shop.Service.Interfaces;
using Shop.ViewModel.ViewModels;
using System;
using System.Collections.Generic;
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
        private readonly IMapper _mapper;
        private readonly IValidator<ProductViewModel> _validator;
        //private readonly ILogger<ProductController> _logger;

        #endregion Variables

        #region Constructor

        public ProductController(IProductService productService, IMapper mapper, IValidator<ProductViewModel> validator/*, ILogger<ProductController> logger*/)
        {
            _productService = productService;
            _mapper = mapper;
            _validator = validator;
            //_logger = logger;
        }

        #endregion Constructor

        #region Rest API

        #region GET: api/Products

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            //_logger.LogInformation("Start HttpGet GetProducts() - ProductController");
            var products = await _productService.GetAllAsync();

            if (products == null)
            {
                //_logger.LogInformation("Product null");
                return NotFound();
            }

            var productsMapping = _mapper.Map<IEnumerable<ProductViewModel>>(products);
            //_logger.LogInformation("End HttpGet GetProducts() - ProductController");
            return Ok(productsMapping);
        }

        #endregion GET: api/Products

        //#region GET: api/products/get/1?pageSize=0&getNumber=2

        //[HttpGet("get/{id}")]
        //public async Task<IActionResult> GetProductsByCategory([FromRoute]int id, [FromQuery(Name = "pageSize")] int pageSize = 0, [FromQuery(Name = "getNumber")]int getNumber = 5)
        //{
        //    //_logger.Information("Start HttpGet GetProducts() - ProductController");
        //    var products = await _productService.GetByCategoryAsync(id, pageSize, getNumber);

        //    if (products == null)
        //    {
        //        //_logger.Information("Product null");
        //        return NotFound();
        //    }

        //    //_logger.Information("End HttpGet GetProducts() - ProductController");
        //    return Ok(products);
        //}

        //#endregion GET: api/products/get/1?pageSize=0&getNumber=2

        //#region GET: api/products/GetWithPagination?PageSize=0&GetNumber=2

        //[HttpGet("GetWithPagination")]
        //public async Task<IActionResult> GetProductsWithPagination([FromQuery(Name = "PageSize")] int PageSize = 0, [FromQuery(Name = "GetNumber")] int GetNumber = 12)
        //{
        //    var data = await _productService.GetProductsWithPagination(PageSize, GetNumber);
        //    return Ok(data);
        //}

        //#endregion GET: api/products/GetWithPagination?PageSize=0&GetNumber=2

        #region GET: api/Products/5

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            //_logger.LogInformation($"Start HttpGet GetProduct({id}) - ProductController");
            if (!ModelState.IsValid)
            {
                //_logger.LogInformation($"End HttpGet GetProduct({id}) - ProductController - BadRequest");
                return BadRequest(ModelState);
            }

            var product = await _productService.GetByIdAsync(id);

            if (product == null)
            {
                //_logger.LogInformation($"End HttpGet GetProduct({id}) - ProductController - NotFound");
                return NotFound();
            }
            var productViewModel = _mapper.Map<ProductViewModel>(product);

            //_logger.LogInformation($"End HttpGet GetProduct({id}) - ProductController - Done");
            return Ok(productViewModel);
        }

        #endregion GET: api/Products/5

        //#region GET: api/Products?sku=sku05

        //[HttpGet("{sku}")]
        //public async Task<IActionResult> GetBySku(string sku)
        //{
        //    _logger.Information($"Start HttpGet GetProduct({sku}) - ProductController");
        //    if (!ModelState.IsValid)
        //    {
        //        _logger.Information($"End HttpGet GetProduct({sku}) - ProductController - BadRequest");
        //        return BadRequest(ModelState);
        //    }

        //    var product = await _productService.GetBySkuAsync(sku);

        //    if (product == null)
        //    {
        //        _logger.Information($"End HttpGet GetProduct({sku}) - ProductController - NotFound");
        //        return NotFound();
        //    }
        //    _logger.Information($"End HttpGet GetProduct({sku}) - ProductController - Done");
        //    return Ok(product);
        //}

        //#endregion GET: api/Products?sku=sku05

        #region PUT: api/Products/5

        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct([FromRoute] int id, [FromBody] ProductViewModel updateProductViewModel)
        {
            if (!ModelState.IsValid)
            {
                //_logger.LogInformation($"End HttpPut PutProduct({id}) - ProductController - BadRequest");
                return BadRequest(ModelState);
            }

            if (id != updateProductViewModel.Id)
            {
                //_logger.LogInformation($"End HttpPut PutProduct({id}) - ProductController - BadRequest: {id} != {updateProductViewModel.Id}");
                return BadRequest();
            }

            var result = _validator.Validate(updateProductViewModel);
            if (!result.IsValid)
            {
                return BadRequest(result.ToString("~"));
            }

            var product = await _productService.GetByIdAsync(id);

            if (product == null)
            {
                //_logger.LogInformation($"End HttpPut PutProduct({id}) - ProductController - NotFound");
                return NotFound();
            }

            try
            {
                var updateProduct = _mapper.Map<Product>(updateProductViewModel);
                updateProduct.InsertedAt = product.InsertedAt;
                updateProduct.UpdatedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now);
                await _productService.UpdateAsync(updateProduct);
                //_logger.LogInformation($"End HttpPut PutProduct({id}) - ProductController - Done");
                return Ok();
            }
            catch (Exception e)
            {
                //_logger.LogError($"End HttpPut PutProduct({id}) - ProductController - BadRequest: {e.Message}");
                return BadRequest($"Error! {e.Message}");
            }
        }

        #endregion PUT: api/Products/5

        #region POST: api/Products

        [HttpPost]
        public async Task<IActionResult> PostProduct([FromBody] ProductViewModel productViewModel)
        {
            if (!ModelState.IsValid)
            {
                //_logger.LogInformation($"End HttpPost PostProduct({productViewModel}) - ProductController - BadRequest");
                return BadRequest(ModelState);
            }

            var result = _validator.Validate(productViewModel);
            if (!result.IsValid)
            {
                return BadRequest(result.ToString("~"));
            }

            try
            {
                var product = _mapper.Map<Product>(productViewModel);

                var datetime = ConvertDatetime.ConvertToTimeSpan(DateTime.Now);

                product.InsertedAt = datetime;
                product.UpdatedAt = datetime;

                await _productService.InsertAsync(product);
                //_logger.LogInformation($"End HttpPost PostProduct({productViewModel}) - ProductController - Done");

                var newProductViewModel = _mapper.Map<ProductViewModel>(product);
                return CreatedAtAction("GetProduct", new { id = newProductViewModel.Id }, newProductViewModel);
            }
            catch (Exception e)
            {
                //_logger.LogError($"End HttpPost PostProduct({productViewModel}) - BadRequest: {e.Message}");
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
                //_logger.LogInformation($"End HttpDelete DeleteProduct({id}) - ProductController - BadRequest");
                return BadRequest(ModelState);
            }

            await _productService.DeleteAsync(id);
            //_logger.LogInformation($"End HttpDelete DeleteProduct({id}) - ProductController - Done");
            return Ok();
        }

        #endregion DELETE: api/Products/5

        //#region DELETE: api/Products?sku=5

        //[HttpDelete]
        //public async Task<IActionResult> DeleteBySku([FromQuery] string sku)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        _logger.Information($"End HttpDelete DeleteBySku({sku}) - ProductController - BadRequest");
        //        return BadRequest(ModelState);
        //    }

        //    //var product = await _productService.getbysku(id);
        //    //if (product == null)
        //    //{
        //    //_logger.Information($"End HttpDelete DeleteBySku({sku}) - ProductController - NotFound");
        //    //return NotFound();
        //    //}

        //    await _productService.DeleteBySku(sku);
        //    _logger.Information($"End HttpDelete DeleteBySku({sku}) - ProductController - Done");
        //    return Ok();
        //}

        //#endregion DELETE: api/Products?sku=5

        #endregion Rest API
    }
}
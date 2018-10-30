using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Shop.Domain.Entities;
using Shop.Domain.SeedWork;
using Shop.Service;
using System;
using System.Collections.Generic;

namespace Shop.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ValuesController(IProductService productService, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _productService = productService;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public IActionResult PostProduct([FromBody] Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                _productService.Insert(product);
                _unitOfWork.SaveChange();

                //_context.Products.Add(product);
                //_context.SaveChangesAsync();
                return Ok("OK");
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
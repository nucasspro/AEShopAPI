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
    [Route("api/Categories")]
    [ApiController]
    //[Authorize]
    public class CategoriesController : ControllerBase
    {
        #region Variables

        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        private readonly IValidator<CategoryViewModel> _validator;
        private readonly ILogger<CategoriesController> _logger;

        #endregion Variables

        #region Constructor

        public CategoriesController(ICategoryService categoryService, IMapper mapper, IValidator<CategoryViewModel> validator, ILogger<CategoriesController> logger)
        {
            _categoryService = categoryService;
            _mapper = mapper;
            _validator = validator;
            _logger = logger;
        }

        #endregion Constructor

        #region Rest API

        #region GET: api/Categories

        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {
            //_logger.LogInformation("Start HttpGet GetCategories() - CategoryController");
            var categories = await _categoryService.GetAllAsync();
            if (categories == null)
            {
                //_logger.LogInformation("Categories null");
                return NotFound();
            }
            var categoriesMapping = _mapper.Map<IEnumerable<CategoryViewModel>>(categories);
            //_logger.LogInformation("End HttpGet GetCategories() - CategoryController");

            return Ok(categoriesMapping);
        }

        #endregion GET: api/Categories

        #region GET: api/Categories/5

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategory(int id)
        {
            //_logger.LogInformation($"Start HttpGet GetCategory({id}) - ProductController");

            if (!ModelState.IsValid)
            {
                //_logger.LogInformation($"End HttpGet GetProduct({id}) - ProductController - BadRequest");
                return BadRequest(ModelState);
            }

            var category = await _categoryService.GetByIdAsync(id);

            if (category == null)
            {
                //_logger.LogInformation($"End HttpGet GetProduct({id}) - ProductController - NotFound");
                return NotFound();
            }

            return Ok(_mapper.Map<CategoryViewModel>(category));
        }

        #endregion GET: api/Categories/5

        #region PUT: api/Categories/5

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategory([FromRoute] int id, [FromBody] CategoryViewModel updateCategoryViewModel)
        {
            if (!ModelState.IsValid)
            {
                //_logger.LogInformation($"End HttpPut PutProduct({id}) - ProductController - BadRequest");
                return BadRequest(ModelState);
            }

            if (id != updateCategoryViewModel.Id)
            {
                //_logger.LogInformation($"End HttpPut PutProduct({id}) - ProductController - BadRequest: {id} != {updateProductViewModel.Id}");
                return BadRequest();
            }

            var result = _validator.Validate(updateCategoryViewModel);
            if (!result.IsValid)
            {
                return BadRequest(result.ToString("~"));
            }

            var category = await _categoryService.GetByIdAsync(id);

            if (category == null)
            {
                //_logger.LogInformation($"End HttpPut PutProduct({id}) - ProductController - NotFound");
                return NotFound();
            }

            try
            {
                var updateCategory = _mapper.Map<Category>(updateCategoryViewModel);
                updateCategory.InsertedAt = category.InsertedAt;
                updateCategory.UpdatedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now);
                await _categoryService.UpdateAsync(updateCategory);
                //_logger.LogInformation($"End HttpPut PutProduct({id}) - ProductController - Done");
                return Ok();
            }
            catch (Exception e)
            {
                //_logger.LogError($"End HttpPut PutProduct({id}) - ProductController - BadRequest: {e.Message}");
                return BadRequest($"Error! {e.Message}");
            }
        }

        #endregion PUT: api/Categories/5

        #region POST: api/Categories

        [HttpPost]
        public async Task<IActionResult> PostCategory([FromBody] CategoryViewModel categoryViewModel)
        {
            if (!ModelState.IsValid)
            {
                //_logger.LogInformation($"End HttpPost PostProduct({productViewModel}) - ProductController - BadRequest");
                return BadRequest(ModelState);
            }

            var resuilt = _validator.Validate(categoryViewModel);
            if (!resuilt.IsValid)
            {
                return BadRequest(resuilt.ToString("~"));
            }

            try
            {
                var category = _mapper.Map<Category>(categoryViewModel);

                var datetime = ConvertDatetime.ConvertToTimeSpan(DateTime.Now);

                category.InsertedAt = datetime;
                category.UpdatedAt = datetime;

                await _categoryService.InsertAsync(category);
                //_logger.LogInformation($"End HttpPost PostProduct({productViewModel}) - ProductController - Done");

                var newCategoryViewModel = _mapper.Map<CategoryViewModel>(category);
                return CreatedAtAction("GetCategory", new { id = newCategoryViewModel.Id }, newCategoryViewModel);
            }
            catch (Exception e)
            {
                //_logger.LogError($"End HttpPost PostProduct({productViewModel}) - BadRequest: {e.Message}");
                return BadRequest(e.Message);
            }
        }

        #endregion POST: api/Categories

        #region DELETE: api/Categories/5

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                //_logger.LogInformation($"End HttpDelete DeleteProduct({id}) - ProductController - BadRequest");
                return BadRequest(ModelState);
            }

            await _categoryService.DeleteAsync(id);
            //_logger.LogInformation($"End HttpDelete DeleteProduct({id}) - ProductController - Done");
            return Ok();
        }

        #endregion DELETE: api/Categories/5

        #endregion Rest API
    }
}
using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Shop.Common.Commons;
using Shop.Domain.Entities;
using Shop.Service.Interfaces;
using Shop.ViewModel.ViewModels;
using System;
using System.Threading.Tasks;

namespace Shop.WebApi.Controllers
{
    [Route("api/Categories")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        #region Variables

        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        private readonly IValidator<CategoryViewModel> _validator;

        #endregion Variables

        #region Constructor

        public CategoriesController(ICategoryService categoryService, IMapper mapper, IValidator<CategoryViewModel> validator)
        {
            _categoryService = categoryService;
            _mapper = mapper;
            _validator = validator;
        }

        #endregion Constructor

        #region Rest API

        #region GET: api/Categories

        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {
            var categories = await _categoryService.GetAllAsync();
            return categories == null ? NotFound() : (IActionResult)Ok(categories);
        }

        #endregion GET: api/Categories

        #region GET: api/Categories/5

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategory(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var category = await _categoryService.GetByIdAsync(id);

            if (category == null)
            {
                return NotFound();
            }

            return Ok(category);
        }

        #endregion GET: api/Categories/5

        #region PUT: api/Categories/5

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategory([FromRoute] int id, [FromBody] CategoryViewModel updateCategoryViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != updateCategoryViewModel.Id)
            {
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
                return NotFound();
            }

            try
            {
                var updateCategory = _mapper.Map<Category>(updateCategoryViewModel);
                updateCategory.InsertedAt = category.InsertedAt;
                updateCategory.UpdatedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now);
                await _categoryService.UpdateAsync(updateCategory);
                return Ok();
            }
            catch (Exception e)
            {
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

                var newCategoryViewModel = _mapper.Map<CategoryViewModel>(category);
                return CreatedAtAction("GetCategory", new { id = newCategoryViewModel.Id }, newCategoryViewModel);
            }
            catch (Exception e)
            {
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
                return BadRequest(ModelState);
            }

            var category = await _categoryService.GetByIdAsync(id);
            if (category == null)
            {
                return NotFound();
            }

            await _categoryService.DeleteAsync(category);

            return Ok(category);
        }

        #endregion DELETE: api/Categories/5

        #endregion Rest API
    }
}
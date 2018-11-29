using Microsoft.AspNetCore.Mvc;
using Shop.Domain.Commons;
using Shop.Domain.Entities;
using Shop.Service.Interfaces;
using System;
using System.Threading.Tasks;

namespace Shop.WebApi.Controllers
{
    [Route("api/Category")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        #region Variables

        private readonly ICategoryService _categoryService;

        #endregion Variables

        #region Constructor

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        #endregion Constructor

        #region Rest API

        #region GET: api/Category

        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {
            var categories = await _categoryService.GetAllAsync();
            return categories == null ? NotFound() : (IActionResult)Ok(categories);
        }

        #endregion GET: api/Category

        #region GET: api/Category/5

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

        #endregion GET: api/Category/5

        #region PUT: api/Category/5

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategory([FromRoute] int id, [FromBody] Category updateCategory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (id != updateCategory.Id)
            {
                return BadRequest();
            }

            var category = await _categoryService.GetByIdAsync(id);

            if (category == null)
            {
                return NotFound();
            }

            try
            {
                await _categoryService.UpdateAsync(updateCategory);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest($"Error! {e.Message}");
            }
        }

        #endregion PUT: api/Category/5

        #region POST: api/Category

        [HttpPost]
        public async Task<IActionResult> PostCategory([FromBody] Category category)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                category.InsertedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now);
                category.UpdatedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now);
                await _categoryService.InsertAsync(category);
                return CreatedAtAction("GetCategory", new { id = category.Id }, category);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        #endregion POST: api/Category

        #region DELETE: api/Category/5

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

        #endregion DELETE: api/Category/5

        #endregion Rest API
    }
}
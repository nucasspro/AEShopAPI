using Microsoft.AspNetCore.Mvc;
using Shop.Domain.Commons;
using Shop.Domain.Entities;
using Shop.Service.Interfaces;
using System;
using System.Threading.Tasks;

namespace Shop.WebApi.Controllers
{
    [Route("api/categories")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        #region Variables

        private readonly ICategoryService _categoryService;

        #endregion Variables

        #region Constructor

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
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

        #endregion PUT: api/Categories/5

        #region POST: api/Categories

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
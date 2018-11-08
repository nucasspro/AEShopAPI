using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Shop.Domain;
using Shop.Domain.Commons;
using Shop.Domain.Entities;
using Shop.Service.Interfaces;
using Shop.WebApi.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shop.WebApi.Controllers
{
    [Route("api/categories")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        #region Variables

        private readonly AeDbContext _context;
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        #endregion Variables

        #region Constructor

        public CategoriesController(AeDbContext context, ICategoryService categoryService, IMapper mapper)
        {
            _context = context;
            _categoryService = categoryService;
            _mapper = mapper;
        }

        #endregion Constructor

        #region Rest API

        #region GET: api/Categories

        [HttpGet]
        public IActionResult GetCategories()
        {
            var category = _categoryService.GetAll();
            return category == null ? NotFound() : (IActionResult)Ok(_mapper.Map<IEnumerable<CategoryViewModel>>(category));
        }

        #endregion GET: api/Categories

        #region GET: api/Categories/5

        [HttpGet("{id}")]
        public IActionResult GetCategory([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var category = _mapper.Map<CategoryViewModel>(_categoryService.GetById(id));

            if (category == null)
            {
                return NotFound();
            }

            return Ok(category);
        }

        #endregion GET: api/Categories/5

        #region PUT: api/Categories/5

        [HttpPut("{id}")]
        public IActionResult PutCategory([FromRoute] int id, [FromBody] CategoryViewModel categoryViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var category = _categoryService.GetById(id);

            if (category == null)
            {
                return NotFound();
            }

            try
            {
                var updateCategory = _mapper.Map(categoryViewModel, category);
                updateCategory.UpdatedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now);
                _categoryService.Update(updateCategory);
                return Ok("Update Successfully!");
            }
            catch (Exception e)
            {
                return BadRequest($"Error! {e.Message}");
            }
        }

        #endregion PUT: api/Categories/5

        #region POST: api/Categories

        [HttpPost]
        public IActionResult PostCategory([FromBody] CategoryViewModel categoryViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var category = _mapper.Map<Category>(categoryViewModel);
                category.InsertedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now);
                category.UpdatedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now);

                _categoryService.Insert(category);
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
        public IActionResult DeleteCategory([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var category = _categoryService.GetById(id);
            if (category == null)
            {
                return NotFound();
            }

            _categoryService.Delete(category);

            return Ok(category);
        }

        #endregion DELETE: api/Categories/5

        #endregion Rest API
    }
}
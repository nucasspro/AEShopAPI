using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shop.Domain.Commons;
using Shop.Domain.Entities;
using Shop.Service.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shop.WebApi.Controllers
{
    [Route("api/abouts")]
    [ApiController]
    public class AboutsController : ControllerBase
    {
        #region Variables

        private readonly IAboutService _aboutService;

        #endregion Variables

        #region Constructor

        public AboutsController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        #endregion Constructor

        #region Rest API

        #region GET: api/Abouts

        [HttpGet]
        public async Task<IActionResult> GetAbouts()
        {
            var abouts = await _aboutService.GetAllAsync();
            return abouts == null ? NotFound() : (IActionResult)Ok(abouts);
        }

        #endregion GET: api/Abouts

        #region GET: api/Abouts/5

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAbout([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var about = await _aboutService.GetByIdAsync(id);

            if (about == null)
            {
                return NotFound();
            }

            return Ok(about);
        }

        #endregion GET: api/Abouts/5

        #region PUT: api/Abouts/5

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAbout([FromRoute] int id, [FromBody] About updateAbout)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != updateAbout.Id)
            {
                return BadRequest();
            }


            var about = await _aboutService.GetByIdAsync(id);

            if (about == null)
            {
                return NotFound();
            }

            try
            {
                await _aboutService.UpdateAsync(updateAbout);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest($"Error! {e.Message}");
            }
        }

        #endregion PUT: api/Abouts/5

        #region POST: api/Abouts

        [HttpPost]
        public async Task<IActionResult> PostAbout([FromBody] About about)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                about.InsertedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now);
                about.UpdatedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now);
                await _aboutService.InsertAsync(about);
                return CreatedAtAction("GetProduct", new { id = about.Id }, about);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        #endregion POST: api/Abouts

        #region DELETE: api/Abouts/5

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAbout([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var about = await _aboutService.GetByIdAsync(id);
            if (about == null)
            {
                return NotFound();
            }

            await _aboutService.DeleteAsync(about);

            return Ok(about);
        }

        #endregion DELETE: api/Abouts/5

        #endregion Rest API
    }
}
using Microsoft.AspNetCore.Mvc;
using Serilog;
using Shop.Domain.Commons;
using Shop.Domain.Entities;
using Shop.Service.Interfaces;
using System;
using System.Threading.Tasks;

namespace Shop.WebApi.Controllers
{
    [Route("api/Contact")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        #region Variables

        private readonly IContactService _contactService;

        #endregion Variables

        #region Constructor

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        #endregion Constructor

        #region Rest API

        #region GET: api/Contact

        [HttpGet]
        public async Task<IActionResult> GetContacts()
        {
            Log.Information("Start HttpGet GetContacts() - ContactController");
            var contacts = await _contactService.GetAllAsync();
            if (contacts == null)
            {
                Log.Information("End HttpGet GetContacts() - ContactController - NotFound: Contact null");
                return NotFound();
            }
            Log.Information("End HttpGet GetContacts() - ContactController - Done");
            return Ok(contacts);
        }

        #endregion GET: api/Contact

        #region GET: api/Contact/1

        [HttpGet("{id}")]
        public async Task<IActionResult> GetContact(int id)
        {
            Log.Information($"Start HttpGet GetContact({id}) - ContactController");
            if (!ModelState.IsValid)
            {
                Log.Information($"End HttpGet GetContact({id}) - ContactController - BadRequest");
                return BadRequest(ModelState);
            }

            var product = await _contactService.GetByIdAsync(id);

            if (product == null)
            {
                Log.Information($"End HttpGet GetContact({id}) - ContactController - NotFound");
                return NotFound();
            }
            Log.Information($"End HttpGet GetContact({id}) - ContactController - Done");
            return Ok(product);
        }

        #endregion GET: api/Contact/1

        #region PUT: api/Contact/1

        [HttpPut("{id}")]
        public async Task<IActionResult> PutContact([FromRoute] int id, [FromBody] Contact updateContact)
        {
            if (!ModelState.IsValid)
            {
                Log.Information($"End HttpPut PutContact({id}) - ContactController - BadRequest");
                return BadRequest(ModelState);
            }
            if (id != updateContact.Id)
            {
                Log.Information($"End HttpPut PutContact({id}) - ContactController - BadRequest: {id} != {updateContact.Id}");
                return BadRequest();
            }

            var contact = await _contactService.GetByIdAsync(id);

            if (contact == null)
            {
                Log.Information($"End HttpPut PutContact({id}) - ContactController - NotFound");
                return NotFound();
            }

            try
            {
                await _contactService.UpdateAsync(updateContact);
                Log.Information($"End HttpPut PutContact({id}) - ContactController - Done");
                return Ok();
            }
            catch (Exception e)
            {
                Log.Information($"End HttpPut PutContact({id}) - ContactController - BadRequest: {e.Message}");
                return BadRequest($"Error! {e.Message}");
            }
        }

        #endregion PUT: api/Contact/1

        #region POST: api/Contact

        [HttpPost]
        public async Task<IActionResult> PostContact([FromBody] Contact contact)
        {
            if (!ModelState.IsValid)
            {
                Log.Information($"End HttpPost PostContact({contact}) - ContactController - BadRequest");
                return BadRequest(ModelState);
            }

            try
            {
                contact.InsertedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now);
                contact.UpdatedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now);
                await _contactService.InsertAsync(contact);
                Log.Information($"End HttpPost PostContact({contact}) - ContactController - Done");
                return CreatedAtAction("GetProduct", new { id = contact.Id }, contact);
            }
            catch (Exception e)
            {
                Log.Information($"End HttpPost PostContact({contact}) - BadRequest: {e.Message}");
                return BadRequest(e.Message);
            }
        }

        #endregion POST: api/Contact

        #region DELETE: api/Contact/1

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContact([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                Log.Information($"End HttpDelete DeleteContact({id}) - ContactController - BadRequest");
                return BadRequest(ModelState);
            }

            var contact = await _contactService.GetByIdAsync(id);
            if (contact == null)
            {
                Log.Information($"End HttpDelete DeleteContact({id}) - ContactController - NotFound");
                return NotFound();
            }

            await _contactService.DeleteAsync(contact);
            Log.Information($"End HttpDelete DeleteContact({id}) - ContactController - Done");
            return Ok(contact);
        }

        #endregion DELETE: api/Contact/1

        #endregion Rest API
    }
}
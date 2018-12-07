using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Serilog;
using Shop.Common.Commons;
using Shop.Domain.Entities;
using Shop.Service.Interfaces;
using Shop.WebApi.Models;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Threading.Tasks;

namespace Shop.WebApi.Controllers
{
    [Route("api/Users")]
    [ApiController]
    [Authorize]
    public class UsersController : ControllerBase
    {
        #region Variables

        private readonly IUserService _userService;
        private IConfiguration _configuration;
        private IMapper _mapper;

        #endregion Variables

        #region Constructor

        public UsersController(IUserService userService, IConfiguration configuration, IMapper mapper)
        {
            _userService = userService;
            _configuration = configuration;
            _mapper = mapper;
        }

        #endregion Constructor

        #region Rest API

        #region GET: api/Users

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetUsers()
        {
            Log.Information("Start HttpGet GetUsers() - UsersController");
            var users = await _userService.GetAllAsync();
            if (users == null)
            {
                Log.Information("User null");
                return NotFound();
            }
            Log.Information("End HttpGet GetUsers() - UsersController");
            return Ok(users);
        }

        #endregion GET: api/Users

        #region GET: api/Users/5

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser([FromRoute] int id)
        {
            Log.Information($"Start HttpGet GetUser({id}) - UsersController");
            if (!ModelState.IsValid)
            {
                Log.Information($"End HttpGet GetUser({id}) - UsersController - BadRequest");
                return BadRequest(ModelState);
            }

            var product = await _userService.GetByIdAsync(id);

            if (product == null)
            {
                Log.Information($"End HttpGet GetUser({id}) - UsersController - NotFound");
                return NotFound();
            }
            Log.Information($"End HttpGet GetUser({id}) - UsersController - Done");
            return Ok(product);
        }

        #endregion GET: api/Users/5

        #region PUT: api/Users/5

        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser([FromRoute] int id, [FromBody] User updateUser)
        {
            Log.Information($"Start HttpPut PutUser({id}) - UsersController");

            if (!ModelState.IsValid)
            {
                Log.Information($"End HttpPut PutUser({id}) - UsersController - BadRequest");
                return BadRequest(ModelState);
            }
            if (id != updateUser.Id)
            {
                Log.Information($"End HttpPut PutUser({id}) - UsersController - BadRequest: {id} != {updateUser.Id}");
                return BadRequest();
            }

            var product = await _userService.GetByIdAsync(id);

            if (product == null)
            {
                Log.Information($"End HttpPut PutUser({id}) - UsersController - NotFound");
                return NotFound();
            }

            try
            {
                await _userService.UpdateAsync(updateUser);
                Log.Information($"End HttpPut PutUser({id}) - UsersController - Done");
                return Ok();
            }
            catch (Exception e)
            {
                Log.Information($"End HttpPut PutUser({id}) - UsersController - BadRequest: {e.Message}");
                return BadRequest($"Error! {e.Message}");
            }
        }

        #endregion PUT: api/Users/5

        #region POST: api/Users

        [HttpPost]
        public async Task<IActionResult> PostUser([FromBody] User user)
        {
            Log.Information($"Start HttpPost PostUser({user}) - UsersController");
            if (!ModelState.IsValid)
            {
                Log.Information($"End HttpPost PostUser({user}) - UsersController - BadRequest");
                return BadRequest(ModelState);
            }

            try
            {
                user.InsertedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now);
                user.UpdatedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now);
                await _userService.InsertAsync(user);
                Log.Information($"End HttpPost PostUser({user}) - UsersController - Done");
                return CreatedAtAction("GetProduct", new { id = user.Id }, user);
            }
            catch (Exception e)
            {
                Log.Information($"End HttpPost PostUser({user}) - BadRequest: {e.Message}");
                return BadRequest(e.Message);
            }
        }

        #endregion POST: api/Users

        #region POST: api/Users/login

        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [HttpPost]
        [Route("login")]
        public IActionResult CreateToken([FromBody]LoginModel login)
        {
            IActionResult response = Unauthorized();
            var user = Authenticate(login);

            if (user != null)
            {
                var tokenString = BuildToken(user);
                response = Ok(new { token = tokenString });
            }

            return response;
        }

        #endregion POST: api/Users/login

        #region POST: api/Users/register

        [AllowAnonymous]
        [HttpPost("register")]
        public IActionResult Register([FromBody]UserViewModel userViewModel)
        {
            var user = _mapper.Map<User>(userViewModel);

            try
            {
                _userService.AddNew(user, userViewModel.Password);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        #endregion POST: api/Users/register

        #region DELETE: api/Users/5

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser([FromRoute] int id)
        {
            Log.Information($"Start HttpDelete DeleteUser({id}) - UsersController");

            if (!ModelState.IsValid)
            {
                Log.Information($"End HttpDelete DeleteUser({id}) - UsersController - BadRequest");
                return BadRequest(ModelState);
            }

            var product = await _userService.GetByIdAsync(id);
            if (product == null)
            {
                Log.Information($"End HttpDelete DeleteUser({id}) - UsersController - NotFound");
                return NotFound();
            }

            await _userService.DeleteAsync(product);
            Log.Information($"End HttpDelete DeleteUser({id}) - UsersController - Done");
            return Ok(product);
        }

        #endregion DELETE: api/Users/5

        #endregion Rest API

        #region Methods

        private string BuildToken(User user)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            
            var token = new JwtSecurityToken(
                _configuration["Jwt:Issuer"],
                _configuration["Jwt:Issuer"],
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        private User Authenticate(LoginModel login)
        {
            var user = _userService.Authenticate(login.Username, login.Password);
            return user;
        }
            #endregion Methods
    }
}
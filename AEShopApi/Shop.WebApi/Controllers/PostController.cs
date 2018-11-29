using Microsoft.AspNetCore.Mvc;
using Serilog;
using Shop.Domain.Commons;
using Shop.Domain.Entities;
using Shop.Service.Interfaces;
using System;
using System.Threading.Tasks;

namespace Shop.WebApi.Controllers
{
    [Route("api/Post")]
    [ApiController]
    public class PostController : ControllerBase
    {
        #region Variables

        private readonly IPostService _postService;

        #endregion Variables

        #region Constructor

        public PostController(IPostService postService)
        {
            _postService = postService;
        }

        #endregion Constructor

        #region Rest API

        #region GET: api/Post

        [HttpGet]
        public async Task<IActionResult> GetPosts()
        {
            Log.Information("Start HttpGet GetPosts() - PostController");
            var posts = await _postService.GetAllAsync();
            if (posts == null)
            {
                Log.Information("Product null");
                return NotFound();
            }
            Log.Information("End HttpGet GetPosts() - PostController");
            return Ok(posts);
        }

        #endregion GET: api/Post

        #region GET: api/Post/5

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPost(int id)
        {
            Log.Information($"Start HttpGet GetPost({id}) - PostController");
            if (!ModelState.IsValid)
            {
                Log.Information($"End HttpGet GetPost({id}) - PostController - BadRequest");
                return BadRequest(ModelState);
            }

            var post = await _postService.GetByIdAsync(id);

            if (post == null)
            {
                Log.Information($"End HttpGet GetPost({id}) - PostController - NotFound");
                return NotFound();
            }
            Log.Information($"End HttpGet GetPost({id}) - PostController - Done");
            return Ok(post);
        }

        #endregion GET: api/Post/5

        #region PUT: api/Post/5

        [HttpPut("{id}")]
        public async Task<IActionResult> PutPost([FromRoute] int id, [FromBody] Post updatePost)
        {
            if (!ModelState.IsValid)
            {
                Log.Information($"End HttpPut PutPost({id}) - PostController - BadRequest");
                return BadRequest(ModelState);
            }
            if (id != updatePost.Id)
            {
                Log.Information($"End HttpPut PutPost({id}) - PostController - BadRequest: {id} != {updatePost.Id}");
                return BadRequest();
            }

            var product = await _postService.GetByIdAsync(id);

            if (product == null)
            {
                Log.Information($"End HttpPut PutPost({id}) - PostController - NotFound");
                return NotFound();
            }

            try
            {
                await _postService.UpdateAsync(updatePost);
                Log.Information($"End HttpPut PutPost({id}) - PostController - Done");
                return Ok();
            }
            catch (Exception e)
            {
                Log.Information($"End HttpPut PutPost({id}) - PostController - BadRequest: {e.Message}");
                return BadRequest($"Error! {e.Message}");
            }
        }

        #endregion PUT: api/Post/5

        #region POST: api/Post

        [HttpPost]
        public async Task<IActionResult> PostPost([FromBody] Post post)
        {
            if (!ModelState.IsValid)
            {
                Log.Information($"End HttpPost PostPost({post}) - PostController - BadRequest");
                return BadRequest(ModelState);
            }

            try
            {
                post.InsertedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now);
                post.UpdatedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now);
                await _postService.InsertAsync(post);
                Log.Information($"End HttpPost PostPost({post}) - PostController - Done");
                return CreatedAtAction("GetPost", new { id = post.Id }, post);
            }
            catch (Exception e)
            {
                Log.Information($"End HttpPost PostPost({post}) - BadRequest: {e.Message}");
                return BadRequest(e.Message);
            }
        }

        #endregion POST: api/Post

        #region DELETE: api/Post/5

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePost([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                Log.Information($"End HttpDelete DeletePost({id}) - PostController - BadRequest");
                return BadRequest(ModelState);
            }

            var post = await _postService.GetByIdAsync(id);
            if (post == null)
            {
                Log.Information($"End HttpDelete DeletePost({id}) - PostController - NotFound");
                return NotFound();
            }

            await _postService.DeleteAsync(post);
            Log.Information($"End HttpDelete DeletePost({id}) - PostController - Done");
            return Ok(post);
        }

        #endregion DELETE: api/Post/5

        #endregion Rest API
    }
}
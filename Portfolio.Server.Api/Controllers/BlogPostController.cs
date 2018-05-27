using System;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Portfolio.Server.Core;
using Portfolio.Server.Core.Dtos;

namespace Portfolio.Server.Api.Controllers
{ 
    [Produces("application/json")]
    [Route("api/blogpost")]
    public class BlogPostController : Controller
    {
        private readonly IBlogPostService _blogPostService;

        public BlogPostController(IBlogPostService blogPostService)
        {
            _blogPostService = blogPostService;
        }

        // GET: api/BlogPost
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _blogPostService.GetAllBlogPosts();
            return Ok(data);
        }

        // GET: api/BlogPost/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<IActionResult> Get(Guid id)
        {
            var data = await _blogPostService.GetBlogPostById(id);
            return Ok(data);
        }
        
        // POST: api/BlogPost 
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]BlogPostDto blogPost)
        {
            var id = await _blogPostService.AddBlogPost(blogPost);
            return Ok(id);
        }
        
        // PUT: api/BlogPost/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

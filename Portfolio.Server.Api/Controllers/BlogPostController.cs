using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Server.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/BlogPost")]
    public class BlogPostController : Controller
    {
        // GET: api/BlogPost
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/BlogPost/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/BlogPost
        [HttpPost]
        public void Post([FromBody]string value)
        {
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

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PhaceApi.Controllers
{
    [Route("api")]
    [ApiController]
    public class DetectFace : ControllerBase
    {
        // GET: api/<DetectFace>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<DetectFace>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DetectFace>
        [HttpPost("DetectFace")]
        public async Task<ActionResult> Create(string url)
        {
           
        }

        // PUT api/<DetectFace>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DetectFace>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

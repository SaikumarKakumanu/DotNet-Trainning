﻿using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web_API_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public string Post()
        {
            return "This is a POST Request";
        }

        // PUT api/<ValuesController>/5
        [HttpPut]
        public string Put()
        {
            return "This is a PUT Request";
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete]
        public string Delete()
        {
            return "This is a DELETE Request";
        }
    }
}

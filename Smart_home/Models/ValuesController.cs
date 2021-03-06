using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Smart_home.Models;
using System.Collections.Generic;
using Smart_home.Data;
using Smart_home.Controllers;
using System.Threading.Tasks;
using System.Configuration;
using Smart_home.Service;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Smart_home
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IulozDbService _ulozDbService;

        public ValuesController(IulozDbService ulozDbService)
        {
            _ulozDbService = ulozDbService;
        }

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
        public async Task<IActionResult> IndexAsync([FromBody] Teploty teploty)
        {
            teploty.cas = DateTime.Now.ToString("dd.MM.yyyy");
            if (await _ulozDbService.ulozDoDBAsync(teploty))
            {
                return Ok();
            }
            return BadRequest();
        }
        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

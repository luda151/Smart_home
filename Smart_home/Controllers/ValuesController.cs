﻿using Microsoft.AspNetCore.Mvc;
using Smart_home.Models;
using System.Threading.Tasks;
using Smart_home.Service;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Smart_home
{
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IDbService _DbService;

        public ValuesController(IDbService DbService)
        {
            _DbService = DbService;
        }

        // POST api/<ValuesController>
        [Route("api/[controller]")]
        
        [HttpPost]
        public async Task<IActionResult> IndexAsync([FromBody] Teploty teploty)
        {
            teploty.cas = DateTime.Now.ToString("dd.MM.yyyy, HH:mm:ss");
            if (await _DbService.ulozDoDBAsync(teploty))
            {
                return Ok();
            }
            return BadRequest();
        }

        [Route("api/co2")]
        [HttpPost]
        public async Task<IActionResult> GetCo2Async([FromBody] Co2 co2)
        {
            co2.Cas = DateTime.Now.ToString("dd.MM.yyyy, HH:mm:ss");
            if (await _DbService.ulozCo2DoDBAsync(co2))
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}

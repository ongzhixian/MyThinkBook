﻿using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyThinkBook.Web.Api;

[Route("Investment/api/[controller]")]
[ApiController]
public class PortfolioController : ControllerBase
{
    [HttpGet]
    public IEnumerable<string> Get(byte page = 1, byte pageSize = 10, string sort = "")
    {
        return new string[] { "PortfolioController", "value2" };
    }

    //// GET api/<ApplicationController>/5
    //[HttpGet("{id}")]
    //public string Get(int id)
    //{
    //    return "value";
    //}

    //// POST api/<ApplicationController>
    //[HttpPost]
    //public void Post([FromBody] string value)
    //{
    //}

    //// PUT api/<ApplicationController>/5
    //[HttpPut("{id}")]
    //public void Put(int id, [FromBody] string value)
    //{
    //}

    //// DELETE api/<ApplicationController>/5
    //[HttpDelete("{id}")]
    //public void Delete(int id)
    //{
    //}
}

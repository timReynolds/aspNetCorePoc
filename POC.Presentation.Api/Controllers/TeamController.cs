﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace POC.Presentation.Api.Controllers
{
    [Route("api/[controller]")]
    public class TeamController : Controller
    {
        public TeamController()
        {
                
        }

        [HttpGet]
        public IEnumerable<Team> Get()
        {
            return new List<Team>();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
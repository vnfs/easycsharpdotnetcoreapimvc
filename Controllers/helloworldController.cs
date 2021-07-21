﻿using Microsoft.AspNetCore.Mvc;

namespace mvcCase.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class helloworldController : ControllerBase
    {
        // GET
        [HttpGet()]
        public ActionResult<helloworld> Get()
        {
            var result = new helloworld
            {
                message = "Hello World"
            };
            return result;
        }
    }
}
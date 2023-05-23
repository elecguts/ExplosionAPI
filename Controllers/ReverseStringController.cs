using System;
using Microsoft.AspNetCore.Mvc;

namespace BasicApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReverseStringController : ControllerBase
    {
        [HttpGet("{str}")]
        public string ReverseString(string str)
        {
            var strArray = str.ToCharArray();
            Array.Reverse(strArray);
            return new string(strArray);
        }
    }
}
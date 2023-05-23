using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace BasicApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExplosionController : ControllerBase
    {
        [HttpGet("{s}")]
        public string Explode(string s)
        {
            var sArray = s.ToArray();
            var exploded = "";
            foreach (var c in sArray)
            {
                var numberOfExplosions = Char.GetNumericValue(c);
                for (var counter = 0; counter < numberOfExplosions; counter++)
                {
                    exploded = exploded + c;
                }
            }
            return exploded;
        }
    }
}
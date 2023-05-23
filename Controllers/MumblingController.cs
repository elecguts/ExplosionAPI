using System;
using Microsoft.AspNetCore.Mvc;

namespace BasicApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MumblingController : ControllerBase
    {
        [HttpGet("{str}")]
        public string MumbleString(string str)
        {
            var sArray = str.ToLower().ToCharArray();
            var stopArray = sArray.Length;
            var mumbling = "";
            var index = 0;
            foreach (var c in sArray)
            {
                mumbling = mumbling + c.ToString().ToUpper();
                for (var repeat = 0; repeat < index; repeat++)
                {
                    mumbling = mumbling + c.ToString();
                }
                if (index != stopArray - 1)
                {
                    mumbling = mumbling + "-";
                }
                index = index + 1;
            }
            return mumbling;
        }
    }
}
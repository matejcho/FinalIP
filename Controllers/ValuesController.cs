using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalIP.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        [Route("{input}")]
        public string GetFahrenheit(double input)
        {
            double result = ((input - 32) * ((double)5 / (double)9));
            return result.ToString();
        }
    }
}

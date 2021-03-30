using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace JurosRestDDDAPI.Controllers
{
    [Route("Home")]
    [ApiController]
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("Showmethecode")]
        public ActionResult<string> Showmethecode()
        {
            return Ok("https://github.com/tiagoOsantista/ProjetoAPIJuros");
        }
    }
}

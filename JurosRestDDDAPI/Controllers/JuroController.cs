using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JurosRestDDDApplication.DTOs;
using JurosRestDDDDomain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace JurosRestDDDAPI.Controllers
{
    [Route("Juro")]
    [ApiController]
    public class JuroController : Controller
    {
        private readonly IApplicationServiceJuro _applicationServiceJuro;


        public JuroController(IApplicationServiceJuro applicationServiceJuro)
        {
            _applicationServiceJuro = applicationServiceJuro;
        }


        [HttpPost]
        [Route("calculajuros")]    
        public ActionResult<decimal> Calculajuros([FromBody] JuroDto juro)
        {
            return Ok(_applicationServiceJuro.Calculajuros(juro));
        }

    
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JurosRestDDDApplication.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace JurosRestDDDAPI.Controllers
{
    [Route("Taxa")]
    [ApiController]
    public class TaxaController : ControllerBase
    {
        private readonly IApplicationServiceTaxa _applicationServiceTaxa;


        public TaxaController(IApplicationServiceTaxa applicationServiceTaxa)
        {
            _applicationServiceTaxa = applicationServiceTaxa;
        }


        [HttpGet]
        [Route("taxaJuros")]
        public ActionResult<string> GetTaxaFixa()
        {
            var taxa = _applicationServiceTaxa.GetTaxaFixa();
            return Ok(taxa);
        }
    }

    
}

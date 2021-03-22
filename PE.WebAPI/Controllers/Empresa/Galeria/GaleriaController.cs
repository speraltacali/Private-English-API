using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PE.IService.Galeria.Dto;

namespace PE.WebAPI.Controllers.Empresa.Galeria
{
    [Route("api/[controller]")]
    [ApiController]
    public class GaleriaController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> GaleriaPost([FromBody]GaleriaDto galeria)
        {


            return Ok();
        }
    }
}
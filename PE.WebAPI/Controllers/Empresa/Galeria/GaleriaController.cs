using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PE.IService.Galeria;
using PE.IService.Galeria.Dto;
using PE.Model.Response;

namespace PE.WebAPI.Controllers.Empresa.Galeria
{
    [Route("api/[controller]")]
    [ApiController]
    public class GaleriaController : ControllerBase
    {
        private readonly IGaleriaService _galeriaService;

        public GaleriaController(IGaleriaService galeriaService)
        {
            _galeriaService = galeriaService;
        }

        [HttpPost]
        public async Task<IActionResult> GaleriaPost([FromBody]GaleriaDto galeria)
        {
            Response respuesta = new Response();

            var galeriaResponse = _galeriaService.Add(galeria);

            if (galeriaResponse== null)
            {
                respuesta.Exito = 0;
                respuesta.Mensaje = "La galeria no se registro , vuelva a intentar.";
                return BadRequest(respuesta);
            }

            respuesta.Exito = 1;
            respuesta.Data = galeriaResponse;

            return Ok(respuesta);
        }
    }
}
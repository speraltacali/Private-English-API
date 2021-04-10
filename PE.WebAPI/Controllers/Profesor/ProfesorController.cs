using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PE.IService.Profesor;
using PE.Service.Profesor;

namespace PE.WebAPI.Controllers.Profesor
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfesorController : ControllerBase
    {
        private readonly ProfesorService _profesorService = new ProfesorService();

        [HttpGet]
        public IEnumerable<ProfesorDto> Get()
        {
            return _profesorService.GetAll();
        }

        [HttpPost]
        public async Task<IActionResult> PostProfesor([FromBody] ProfesorDto persona)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var Profesor = _profesorService.Add(persona);

            return Ok(Profesor);
        }
    }
}

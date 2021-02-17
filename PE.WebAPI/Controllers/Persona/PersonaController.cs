using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PE.IService.Persona;
using PE.IService.Persona.Dto;
using PE.Service.Persona;

namespace PE.WebAPI.Controllers.Persona
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PersonaController : ControllerBase
    {
        private readonly IPersonaService _personaService = new PersonaService();

        [HttpGet]
        public IEnumerable<PersonaDto> Get()
        {
            return _personaService.GetAll();
        }

        [HttpPost]
        public async Task<IActionResult> PostPersona([FromBody]PersonaDto persona)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var Persona = _personaService.Add(persona);

            return Ok(Persona);
        }
    }
}
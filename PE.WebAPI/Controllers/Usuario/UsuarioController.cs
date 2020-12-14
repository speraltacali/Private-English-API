using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PE.IService.Usuario;
using PE.IService.Usuario.Dto;
using PE.Service.Usuario;

namespace PE.WebAPI.Controllers.Usuario
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService = new UsuarioService();


        [HttpGet]
        public IEnumerable<UsuarioDto> GetUsuario()
        {
            return _usuarioService.GetAll();
        }


        [HttpPost]
        public async Task<IActionResult> PostUsuario([FromBody]UsuarioDto usuario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

             var Usuario =_usuarioService.Add(usuario);

            return Ok(Usuario);
        }
    }
}

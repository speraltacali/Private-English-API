using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PE.IService.Usuario;
using PE.IService.Usuario.Dto;
using PE.Model.Request;
using PE.Model.Response;
using PE.Service.Usuario;

namespace PE.WebAPI.Controllers.Usuario
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioServicio)
        {
            _usuarioService = usuarioServicio;
        }

        [HttpGet]
        public IEnumerable<UsuarioDto> GetUsuario()
        {
            return _usuarioService.GetAll();
        }


        [HttpPost("login")]
        public async Task<IActionResult> Autentificar([FromBody] AuthRequest model)
        {
            Response respuesta = new Response();

            var userRespones = _usuarioService.Auth(model);

            if (userRespones == null)
            {
                respuesta.Exito = 0;
                respuesta.Mensaje = "Usuario o Contraseña incorracta";
                return BadRequest(respuesta);
            }

            respuesta.Exito = 1;
            respuesta.Data = userRespones;

            return Ok(respuesta);
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

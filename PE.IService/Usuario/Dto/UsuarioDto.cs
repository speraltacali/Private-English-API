using PE.Domain.Base.Tipo;
using PE.Service.Base.BaseDto;
using System;
using System.Collections.Generic;
using System.Text;

namespace PE.IService.Usuario.Dto
{
    public class UsuarioDto : BaseDto
    {
        public string User { get; set; }

        public string Password { get; set; }

        public bool Estado { get; set; }

        public bool Eliminado { get; set; }

        public long PersonaId { get; set; }

        public long EmpresaId { get; set; }

        public Cargo Cargo { get; set; }
    }
}

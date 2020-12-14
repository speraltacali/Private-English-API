using PE.Domain.Base.EntityBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace PE.Domain.Entity.Usuario
{
    public class Usuario : EntityBase
    {
        public string User { get; set; }

        public string Password { get; set; }

        public bool Estado { get; set; }

        public bool Eliminado { get; set; }
    }
}

using PE.Domain.Base.EntityBase;
using PE.Domain.Entity.Perfil;
using PE.Domain.Entity.Persona;
using System;
using System.Collections.Generic;
using System.Text;

namespace PE.Domain.Entity.Empleado
{
    public class Empleado : EntityBase
    {
        public string Legajo { get; set; }

        public DateTime FechaAlta { get; set; }

        public DateTime FehcaBaja { get; set; }

        public long PersonaId { get; set; }

        //public virtual IEnumerable<PerfilEmpleado> PerfilEmpleado { get; set; }

        public virtual Persona.Persona Persona { get; set; }
    }
}

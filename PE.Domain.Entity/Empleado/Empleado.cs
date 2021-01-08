using PE.Domain.Base.EntityBase;
using PE.Domain.Entity.Perfil;
using System;
using System.Collections.Generic;
using System.Text;

namespace PE.Domain.Entity.Empleado
{
    public class Empleado : PE.Domain.Entity.Persona.Persona
    {
        public string Legajo { get; set; }

        public DateTime FechaAlta { get; set; }

        public DateTime FehcaBaja { get; set; }

        //public virtual IEnumerable<PerfilEmpleado> PerfilEmpleado { get; set; }
    }
}

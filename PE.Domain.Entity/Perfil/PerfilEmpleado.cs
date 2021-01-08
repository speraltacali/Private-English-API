using PE.Domain.Entity.Empleado;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PE.Domain.Entity.Perfil
{
    public class PerfilEmpleado : Perfil
    {
        [ForeignKey("Empleado")]
        public long EmpleadoId { get; set; }

        public virtual Empleado.Empleado Empleado { get; set; }
    }
}

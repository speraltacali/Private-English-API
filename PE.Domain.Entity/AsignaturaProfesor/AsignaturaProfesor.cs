using PE.Domain.Base.EntityBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace PE.Domain.Entity.AsignaturaProfesor
{
    public class AsignaturaProfesor : EntityBase
    {
        public int AsignaturaId { get; set; }

        public int ProfesorId { get; set; }

        public bool Habilitado { get; set; }
    }
}

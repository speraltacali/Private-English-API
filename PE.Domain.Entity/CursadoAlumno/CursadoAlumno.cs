using PE.Domain.Base.EntityBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace PE.Domain.Entity.CursadoAlumno
{
    public class CursadoAlumno : EntityBase
    {
        public int CursadoId { get; set; }

        public int AlumnoId { get; set; }

        public bool Finalizado { get; set; }
    }
}

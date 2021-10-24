using PE.Domain.Base.EntityBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace PE.Domain.Entity.CursadoProfesor
{
    public class CursadoProfesor : EntityBase
    {
        public int CursadoId { get; set; }

        public int ProfesorId { get; set; }

        public bool Finalizado { get; set; }
    }
}

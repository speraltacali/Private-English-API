using PE.Domain.Base.EntityBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace PE.Domain.Entity.Cursado
{
    public class Cursado : EntityBase
    {
        public int AlumnoId { get; set; }

        public int ComisionId { get; set; }

        public int Asignatura { get; set; }

        public int CicloId { get; set; }

        public int Turno { get; set; }


    }
}

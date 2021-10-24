using PE.Domain.Base.EntityBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace PE.Domain.Entity.Ciclo
{
    public class Ciclo : EntityBase
    {
        public int Anio { get; set; }

        public bool Eliminado { get; set; }
    }
}

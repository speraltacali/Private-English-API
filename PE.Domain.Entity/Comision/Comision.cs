using PE.Domain.Base.EntityBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace PE.Domain.Entity.Comision
{
    public class Comision : EntityBase
    {
        public int Numero { get; set; }

        public bool Estado { get; set; }

        public bool Eliminado { get; set; }
    }
}

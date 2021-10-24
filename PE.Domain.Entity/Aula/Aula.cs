using PE.Domain.Base.EntityBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace PE.Domain.Entity.Aula
{
    public class Aula : EntityBase
    {
        public int Numero { get; set; }

        public int Capacidad { get; set; }

        public bool Estado { get; set; }

        public bool Eliminado { get; set; }
    }
}

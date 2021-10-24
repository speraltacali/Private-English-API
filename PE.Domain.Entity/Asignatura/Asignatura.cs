using PE.Domain.Base.EntityBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace PE.Domain.Entity.Asignatura
{
    public class Asignatura : EntityBase
    {
        public string Descripcion { get; set; }

        public bool Estado { get; set; }

        public bool Eliminado { get; set; }

    }
}

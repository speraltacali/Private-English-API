using PE.Domain.Base.EntityBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace PE.Domain.Entity.Empresa
{
    public class Empresa : EntityBase
    {
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public bool Eliminado { get; set; }
    }
}

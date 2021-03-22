using PE.Domain.Base.EntityBase;
using PE.Domain.Entity.Empresa;
using System;
using System.Collections.Generic;
using System.Text;

namespace PE.Domain.Entity.Galeria
{
    public class Galeria : EntityBase
    {
        public string Titulo { get; set; }

        public byte[] Imagen { get; set; }

        public bool Estado { get; set; }

        public bool Eliminado { get; set; }

        public int EmpresaId { get; set; }

        //***********************************************************//

        public virtual Empresa.Empresa Empresa { get; set; }
    }
}

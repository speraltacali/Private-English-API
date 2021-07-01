using PE.Domain.Base.EntityBase;
using PE.Domain.Entity.Empresa;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PE.Domain.Entity.Galeria
{
    public class Galeria : EntityBase
    {
        public string Titulo { get; set; }

        public string Imagen { get; set; }

        public bool Estado { get; set; }

        public bool Eliminado { get; set; }

        [ForeignKey("Empresa")]
        public long EmpresaId { get; set; }

        //***********************************************************//

        public virtual Empresa.Empresa Empresa { get; set; }
    }
}

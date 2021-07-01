using PE.Domain.Base.EntityBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PE.Domain.Entity.PerfilHome
{
    public class PerfilHome : EntityBase
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Cargo { get; set; }

        public string Descripcion { get; set; }

        public string Foto { get; set; }

        public bool Estado { get; set; }

        public bool Eliminado { get; set; }

        [ForeignKey("Empresa")]
        public long EmpresaId { get; set; }

        //***********************************************************//

        public virtual Empresa.Empresa Empresa { get; set; }
    }
}

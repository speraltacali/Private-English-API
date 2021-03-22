using PE.Domain.Base.EntityBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace PE.Domain.Entity.PerfilHome
{
    public class PerfilHome : EntityBase
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Cargo { get; set; }

        public string Descripcion { get; set; }

        public byte[] Foto { get; set; }

        public bool Estado { get; set; }

        public bool Eliminado { get; set; }

        public int EmpresaId { get; set; }

        //***********************************************************//

        public virtual Empresa.Empresa Empresa { get; set; }
    }
}

using PE.Domain.Base.EntityBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace PE.Domain.Entity.Novedades
{
    public class Novedades : EntityBase
    {
        public string Titulo { get; set; }

        public string SubTitulo { get; set; }

        public string Descripcion { get; set; }

        public byte[] Foto { get; set; }

        public DateTime Fecha { get; set; }

        public bool Estado { get; set; }

        public bool Eliminado { get; set; }

        public int EmpresaId { get;set; }

        //***********************************************************//

        public virtual Empresa.Empresa Empresa { get; set; }
    }
}

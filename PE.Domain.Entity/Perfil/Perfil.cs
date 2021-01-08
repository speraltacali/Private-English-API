using PE.Domain.Base.EntityBase;
using PE.Domain.Base.Tipo;
using System;
using System.Collections.Generic;
using System.Text;

namespace PE.Domain.Entity.Perfil
{
    public class Perfil : EntityBase
    {
        public string Descripcion { get; set; }

        public byte[] Imagen { get; set; }

    }
}

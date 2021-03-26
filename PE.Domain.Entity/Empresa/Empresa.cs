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

        public string Cuit { get; set; }

        public string FechaAlta { get; set; }

        public string Direccion { get; set; }

        public bool Eliminado { get; set; }



        //****************************************************//

        public virtual IEnumerable<Usuario.Usuario> Usuario { get; set; }

        public virtual IEnumerable<Galeria.Galeria> Galeria { get; set; }

        public virtual IEnumerable<Novedades.Novedades> Novedades { get; set; }

        public virtual IEnumerable<PerfilHome.PerfilHome> PerfilHome { get; set; }
    }
}

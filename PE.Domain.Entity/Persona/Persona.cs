using PE.Domain.Base.EntityBase;
using PE.Domain.Base.Tipo;
using PE.Domain.Entity.Usuario;
using System;
using System.Collections.Generic;
using System.Text;

namespace PE.Domain.Entity.Persona
{
    public class Persona : EntityBase
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Dni { get; set; }

        public string Cuil { get; set; }

        public string Domicilio { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public Sexo Sexo { get; set; }

        public string EMail { get; set; }

        //**********************************************************************//

        public virtual IEnumerable<Usuario.Usuario> Usuarios { get; set; }

    }
}

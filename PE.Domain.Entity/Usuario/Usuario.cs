using PE.Domain.Base.EntityBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PE.Domain.Entity.Usuario
{
    public class Usuario : EntityBase
    {
        public string User { get; set; }

        public string Password { get; set; }

        public bool Estado { get; set; }

        public bool Eliminado { get; set; }

        [ForeignKey("Persona")]
        public long PersonaId { get; set; }

        [ForeignKey("Empresa")]
        public long EmpresaId { get; set; }

        [ForeignKey("Perfil")]
        public long PerfilId { get; set; }

        //*****************************************************//

        public virtual Persona.Persona  Persona { get; set; }

        public virtual Empresa.Empresa Empresa { get; set; }

        public virtual Perfil.Perfil Perfil { get; set; }
    }


}

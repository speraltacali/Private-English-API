using PE.Domain.Base.EntityBase;
using PE.Domain.Base.Tipo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PE.Domain.Entity.Profesor
{
    public class Profesor : EntityBase
    {
        public string Legajo { get; set; }

        public bool Eliminado { get; set; }

        
        [ForeignKey("Persona")]
        public long PersonaId { get; set; }


        public virtual Persona.Persona Persona { get; set; }

    }
}

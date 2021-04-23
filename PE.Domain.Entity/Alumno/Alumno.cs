using PE.Domain.Base.EntityBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PE.Domain.Entity.Alumno
{
    public class Alumno : EntityBase
    {
        public DateTime FechaInscripcion { get; set; }

        public string Legajo { get; set; }

        public bool Eliminado { get; set; }


        [ForeignKey("Persona")]
        public long PersonaId { get; set; }

        public virtual Persona.Persona Persona { get; set; }
    }
}

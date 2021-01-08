using PE.Domain.Base.EntityBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace PE.Domain.Entity.Alumno
{
    public class Alumno : PE.Domain.Entity.Persona.Persona
    {
        public DateTime FechaInscripcion { get; set; }

        public string Legajo { get; set; }

        public bool Eliminado { get; set; }

    }
}

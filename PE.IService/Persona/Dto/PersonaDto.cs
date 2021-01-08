using PE.Domain.Base.Tipo;
using PE.Service.Base.BaseDto;
using System;
using System.Collections.Generic;
using System.Text;

namespace PE.IService.Persona.Dto
{
    public class PersonaDto : BaseDto
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Dni { get; set; }

        public string Cuil { get; set; }

        public string Domicilio { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public Sexo Sexo { get; set; } 

        public string EMail { get; set; }

    }
}

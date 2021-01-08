using PE.Service.Base.BaseDto;
using System;
using System.Collections.Generic;
using System.Text;

namespace PE.IService.Empleado.Dto
{
    public class EmpleadoDto : BaseDto
    {
        public string Legajo { get; set; }

        public DateTime FechaAlta { get; set; }

        public DateTime FehcaBaja { get; set; }
    }
}

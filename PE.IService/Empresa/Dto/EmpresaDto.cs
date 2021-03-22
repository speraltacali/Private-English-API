using PE.Service.Base.BaseDto;
using System;
using System.Collections.Generic;
using System.Text;

namespace PE.IService.Empresa.Dto
{
    public class EmpresaDto : BaseDto
    {
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public string Cuit { get; set; }

        public string FechaAlta { get; set; }

        public string Direccion { get; set; }

        public bool Eliminado { get; set; }


    }
}

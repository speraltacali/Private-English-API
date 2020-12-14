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

        public bool Eliminado { get; set; }
    }
}

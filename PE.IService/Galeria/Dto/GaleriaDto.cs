using PE.Service.Base.BaseDto;
using System;
using System.Collections.Generic;
using System.Text;

namespace PE.IService.Galeria.Dto
{
    public class GaleriaDto : BaseDto
    {
        public string Titulo { get; set; }

        public string Imagen { get; set; }

        public bool Estado { get; set; }

        public bool Eliminado { get; set; }

        public long EmpresaId { get; set; }

    }
}

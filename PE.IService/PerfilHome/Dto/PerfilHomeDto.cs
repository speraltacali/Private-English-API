using PE.Service.Base.BaseDto;
using System;
using System.Collections.Generic;
using System.Text;

namespace PE.IService.PerfilHome.Dto
{
    public class PerfilHomeDto : BaseDto
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Cargo { get; set; }

        public string Descripcion { get; set; }

        public string Foto { get; set; }

        public bool Estado { get; set; }

        public bool Eliminado { get; set; }

        public long EmpresaId { get; set; }

    }
}

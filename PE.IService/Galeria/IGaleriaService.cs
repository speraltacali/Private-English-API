using PE.IService.Galeria.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace PE.IService.Galeria
{
    public interface IGaleriaService
    {
        GaleriaDto Add(GaleriaDto dto);

        GaleriaDto Update(GaleriaDto dto);

        void Delete(long id);

        void Save();


        IEnumerable<GaleriaDto> GetAll();

        IEnumerable<GaleriaDto> GetByFilter(string query);

        IEnumerable<GaleriaDto> GetById(long id);

    }
}

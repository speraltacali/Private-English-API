using PE.IService.Novedades.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace PE.IService.Novedades
{
    public interface INovedadesService
    {
        NovedadesDto Add(NovedadesDto dto);

        NovedadesDto Update(NovedadesDto dto);

        void Delete(long id);

        void Save();


        IEnumerable<NovedadesDto> GetAll();

        IEnumerable<NovedadesDto> GetByFilter(string query);

        IEnumerable<NovedadesDto> GetById(long id);
    }
}

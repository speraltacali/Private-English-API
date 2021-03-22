using PE.IService.PerfilHome.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace PE.IService.PerfilHome
{
    public interface IPerfilHomeService
    {
        PerfilHomeDto Add(PerfilHomeDto dto);

        PerfilHomeDto Update(PerfilHomeDto dto);

        void Delete(long id);

        void Save();


        IEnumerable<PerfilHomeDto> GetAll();

        IEnumerable<PerfilHomeDto> GetByFilter(string query);

        IEnumerable<PerfilHomeDto> GetById(long id);
    }
}

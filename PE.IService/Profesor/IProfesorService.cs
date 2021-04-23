using System;
using System.Collections.Generic;
using System.Text;

namespace PE.IService.Profesor
{
    public interface IProfesorService
    {
        ProfesorDto Add(ProfesorDto dto);

        ProfesorDto Update(ProfesorDto dto);

        void Delete(long id);

        void Save();

        IEnumerable<ProfesorDto> GetAll();

        IEnumerable<ProfesorDto> GetByFilter(string query);

        ProfesorDto GetById(long id);
    }
}

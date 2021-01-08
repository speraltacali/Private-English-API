using PE.IService.Persona.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace PE.IService.Persona
{
    public interface IPersonaService
    {
        PersonaDto Add(PersonaDto dto);

        PersonaDto Update(PersonaDto dto);

        void Delete(long id);

        void Save();


        IEnumerable<PersonaDto> GetAll();

        IEnumerable<PersonaDto> GetByFilter(string query);

        IEnumerable<PersonaDto> GetById(long id);
    }
}

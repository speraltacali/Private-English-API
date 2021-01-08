using PE.Domain.Repository.Persona;
using PE.Infrastructure.Repository.Persona;
using PE.IService.Persona;
using PE.IService.Persona.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PE.Service.Persona
{
    public class PersonaService : IPersonaService
    {
        private readonly IPersonaRepository _personaRepository = new PersonaRepository();

        public PersonaDto Add(PersonaDto dto)
        {
            var obj = new PE.Domain.Entity.Persona.Persona()
            {
                Nombre = dto.Nombre,
                Apellido = dto.Apellido,
                Dni = dto.Dni,
                Cuil = dto.Cuil,
                Domicilio = dto.Domicilio,
                FechaNacimiento = dto.FechaNacimiento,
                Sexo = dto.Sexo,
                EMail = dto.EMail,
            };

            _personaRepository.Add(obj);
            Save();

            dto.Id = obj.Id;
            return dto;
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public PersonaDto Update(PersonaDto dto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PersonaDto> GetAll()
        {
            return _personaRepository.GetAll()
                .Select(x => new PersonaDto
                {
                    Id = x.Id,
                    Nombre = x.Nombre,  
                    Apellido = x.Apellido,
                    Dni = x.Dni,
                    Cuil = x.Cuil,
                    Domicilio = x.Domicilio,
                    FechaNacimiento = x.FechaNacimiento,
                    Sexo = x.Sexo,
                    EMail = x.EMail,
                }).ToList();
        }

        public IEnumerable<PersonaDto> GetByFilter(string query)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PersonaDto> GetById(long id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            _personaRepository.Save();
        }


    }
}

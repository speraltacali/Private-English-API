using System.Collections.Generic;
using System.Linq;
using PE.Domain.Repository.Profesor;
using PE.Infrastructure.Repository.Profesor;
using PE.IService.Profesor;

namespace PE.Service.Profesor
{
    public class ProfesorService : IProfesorServicio
    {
        private readonly IProfesorRepository _profesorRepository = new ProfesorRepository();

        public ProfesorDto Add(ProfesorDto dto)
        {
            var obj = new Domain.Entity.Profesor.Profesor
            {
                Nombre = dto.Nombre,
                Apellido = dto.Apellido,
                Cuil = dto.Cuil,
                Dni = dto.Dni,
                Domicilio = dto.Domicilio,
                EMail = dto.EMail,
                FechaNacimiento = dto.FechaNacimiento,
                Sexo = dto.Sexo,

            };

            _profesorRepository.Add(obj);
            Save();

            dto.Id = obj.Id;
            return dto;
        }

        public void Delete(long id)
        {
            var obj = _profesorRepository.GetById(id);

            if (obj != null)
            {

                obj.Eliminado = true;

                _profesorRepository.Update(obj);
                Save();
            }
        }

        public IEnumerable<ProfesorDto> GetAll()
        {
            return _profesorRepository.GetAll()
                .Select(x => new ProfesorDto
                {
                    Id = x.Id,
                    Nombre = x.Nombre,
                    Apellido = x.Apellido,
                    Cuil = x.Cuil,
                    Dni = x.Dni,
                    Domicilio = x.Domicilio,
                    EMail = x.EMail,
                    FechaNacimiento = x.FechaNacimiento,
                    Sexo = x.Sexo

                });
        }

        public IEnumerable<ProfesorDto> GetByFilter(string query)
        {
            return _profesorRepository.GetByFilter(x => x.Apellido.Contains(query) ||
                                                x.Dni.Contains(query))
                .Select(x => new ProfesorDto
                {
                    Id = x.Id,
                    Nombre = x.Nombre,
                    Apellido = x.Apellido,
                    Cuil = x.Cuil,
                    Dni = x.Dni,
                    Domicilio = x.Domicilio,
                    EMail = x.EMail,
                    FechaNacimiento = x.FechaNacimiento,
                    Sexo = x.Sexo

                });
        }

        public ProfesorDto GetById(long id)
        {
            var profesor = _profesorRepository.GetById(id);

            if (profesor == null)
                return null;

            return new ProfesorDto
            {
                Id = profesor.Id,
                Nombre = profesor.Nombre,
                Apellido = profesor.Apellido,
                Cuil = profesor.Cuil,
                Dni = profesor.Dni,
                Domicilio = profesor.Domicilio,
                EMail = profesor.EMail,
                FechaNacimiento = profesor.FechaNacimiento,
                Sexo = profesor.Sexo

            };
        }

        public void Save()
        {
            _profesorRepository.Save();
        }

        public ProfesorDto Update(ProfesorDto dto)
        {
            var obj = _profesorRepository.GetById(dto.Id);

            if (obj != null)
            {

                obj.Nombre = dto.Nombre;
                obj.Apellido = dto.Apellido;
                obj.Cuil = dto.Cuil;
                obj.Dni = dto.Dni;
                obj.Domicilio = dto.Domicilio;
                obj.EMail = dto.EMail;
                obj.FechaNacimiento = dto.FechaNacimiento;
                obj.Sexo = dto.Sexo;

                _profesorRepository.Update(obj);
                Save();

                return dto;
            }
            else
            {
                return null;
            }
        }

    }
}

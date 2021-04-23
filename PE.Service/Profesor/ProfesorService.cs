using System.Collections.Generic;
using System.Linq;
using PE.Domain.Repository.Profesor;
using PE.Infrastructure.Repository.Profesor;
using PE.IService.Profesor;

namespace PE.Service.Profesor
{
    public class ProfesorService : IProfesorService
    {
        private readonly IProfesorRepository _profesorRepository = new ProfesorRepository();

        public ProfesorDto Add(ProfesorDto dto)
        {
            var obj = new Domain.Entity.Profesor.Profesor
            {

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

                });
        }

        public IEnumerable<ProfesorDto> GetByFilter(string query)
        {
            return _profesorRepository.GetAll()

                .Select(x => new ProfesorDto
                {

                });
        }

        public ProfesorDto GetById(long id)
        {
            var profesor = _profesorRepository.GetById(id);

            if (profesor == null)
                return null;

            return new ProfesorDto
            {

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

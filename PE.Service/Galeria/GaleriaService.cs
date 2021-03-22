using PE.Domain.Entity.Galeria;
using PE.Domain.Repository.Galeria;
using PE.Infrastructure.Repository.Galeria;
using PE.IService.Galeria;
using PE.IService.Galeria.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PE.Service.Galeria
{
    public class GaleriaService : IGaleriaService
    {
        private readonly IGaleriaRepository _galeriaService = new GaleriaRepository();

        public GaleriaDto Add(GaleriaDto dto)
        {
            var obj = new Domain.Entity.Galeria.Galeria
            {
                Titulo = dto.Titulo,
                Imagen = dto.Imagen,
                Estado = dto.Estado,
                Eliminado = false,
                EmpresaId = dto.EmpresaId
            };

            _galeriaService.Add(obj);
            Save();

            dto.Id = obj.Id;
            return dto;
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GaleriaDto> GetAll()
        {
            return _galeriaService.GetAll()
                .Select(x => new GaleriaDto
                {
                    Id = x.Id,
                    Titulo = x.Titulo,
                    Imagen = x.Imagen,
                    Estado = x.Estado,
                    Eliminado = x.Estado,
                    EmpresaId = x.EmpresaId
                }).ToList();
        }

        public IEnumerable<GaleriaDto> GetByFilter(string query)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GaleriaDto> GetById(long id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public GaleriaDto Update(GaleriaDto dto)
        {
            throw new NotImplementedException();
        }
    }
}

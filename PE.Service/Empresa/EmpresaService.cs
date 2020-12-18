using PE.Domain.Repository.Empresa;
using PE.Infrastructure.Repository.Empresa;
using PE.IService.Empresa;
using PE.IService.Empresa.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace PE.Service.Empresa
{
    public class EmpresaService : IEmpresaService
    {
        private readonly IEmpresaRepository _empresaRepository = new EmpresaRepository();


        public EmpresaDto Add(EmpresaDto dto)
        {
            var obj = new PE.Domain.Entity.Empresa.Empresa
            {
                Nombre = dto.Nombre,
                Descripcion = dto.Descripcion,
                Eliminado = dto.Eliminado
            };

            _empresaRepository.Add(obj);
            _empresaRepository.Save();

            dto.Id = obj.Id;
            return dto;
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmpresaDto> GetAll()
        {
            return _empresaRepository.GetAll()
                .Select(x => new EmpresaDto
                {
                    Id = x.Id,
                    Nombre = x.Nombre,
                    Descripcion = x.Descripcion,
                    Eliminado = x.Eliminado
                }).ToList();
        }

        public IEnumerable<EmpresaDto> GetByFilter(string query)
        {
            return _empresaRepository.GetByFilter(x=> x.Descripcion.Contains(query) || x.Nombre.Contains(query))
                .Select(x => new EmpresaDto
                {
                    Id = x.Id,
                    Nombre = x.Nombre,
                    Descripcion = x.Descripcion,
                    Eliminado = x.Eliminado
                }).ToList();
        }

        public IEnumerable<EmpresaDto> GetById(long id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            _empresaRepository.Save();
        }

        public EmpresaDto Update(EmpresaDto dto)
        {
            throw new NotImplementedException();
        }
    }
}

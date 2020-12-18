using PE.IService.Empresa.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace PE.IService.Empresa
{
    public interface IEmpresaService
    {
        EmpresaDto Add(EmpresaDto dto);

        EmpresaDto Update(EmpresaDto dto);

        void Delete(long id);

        void Save();


        IEnumerable<EmpresaDto> GetAll();

        IEnumerable<EmpresaDto> GetByFilter(string query);

        IEnumerable<EmpresaDto> GetById(long id);

    }
}

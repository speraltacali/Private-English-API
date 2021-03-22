using PE.IService.Empleado.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace PE.IService.Empleado
{
    public interface IEmpleadoService 
    {
        EmpleadoDto Add(EmpleadoDto dto);

        EmpleadoDto Update(EmpleadoDto dto);

        void Delete(long id);

        void Save();


        IEnumerable<EmpleadoDto> GetAll();

        IEnumerable<EmpleadoDto> GetByFilter(string query);

        IEnumerable<EmpleadoDto> GetById(long id);
    }
}

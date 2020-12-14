using PE.IService.Usuario.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace PE.IService.Usuario
{
    public interface IUsuarioService
    {
        UsuarioDto Add(UsuarioDto dto);

        UsuarioDto Update(UsuarioDto dto);

        void Delete(long id);

        void Save();


        IEnumerable<UsuarioDto> GetAll();

        IEnumerable<UsuarioDto> GetByFilter();

        IEnumerable<UsuarioDto> GetById(long id);
    }
}

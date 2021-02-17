using PE.IService.Usuario.Dto;
using PE.Model.Request;
using PE.Model.Response;
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

        IEnumerable<UsuarioDto> GetByFilter(string query);

        UsuarioDto GetById(long id);

        UserResponse Auth(AuthRequest model); 
    }
}

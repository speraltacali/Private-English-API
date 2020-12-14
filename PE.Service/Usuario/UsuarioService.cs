using PE.Domain.Repository.Usuario;
using PE.Infrastructure.Repository.Usuario;
using PE.IService.Usuario;
using PE.IService.Usuario.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PE.Service.Usuario
{
    public class UsuarioService : IUsuarioService
    {

        private readonly IUsuarioRepository _usuarioRepository = new UsuarioRepository();

        public UsuarioDto Add(UsuarioDto dto)
        {
            var obj = new Domain.Entity.Usuario.Usuario
            {
                User = dto.User,
                Password = dto.Password,
                Estado = dto.Estado
            };

            _usuarioRepository.Add(obj);
            Save();

            dto.Id = obj.Id;
            return dto;

        }

        public void Save()
        {
            _usuarioRepository.Save();
        }

        public UsuarioDto Update(UsuarioDto dto)
        {
            var obj = _usuarioRepository.GetById(dto.Id);

            if(obj != null)
            {

                obj.User = dto.User;
                obj.Password = dto.Password;
                obj.Estado = dto.Estado;

                _usuarioRepository.Update(obj);
                Save();

                return dto;
            }
            else
            {
                return null;
            }

        }

        public void Delete(long id)
        {
            var obj = _usuarioRepository.GetById(id);

            if (obj != null)
            {

                obj.Eliminado = true;

                _usuarioRepository.Update(obj);
                Save();
            }
        }

        public IEnumerable<UsuarioDto> GetAll()
        {
            return _usuarioRepository.GetAll()
                .Select(x=> new UsuarioDto
                {
                    Id = x.Id,
                    User = x.User,
                    Password = x.Password,
                    Estado = x.Estado,
                    Eliminado = x.Eliminado
                });
        }

        public IEnumerable<UsuarioDto> GetByFilter()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UsuarioDto> GetById(long id)
        {
            throw new NotImplementedException();
        }


    }
}

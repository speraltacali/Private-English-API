using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using PE.Domain.Repository.Usuario;
using PE.Infrastructure.Repository.Usuario;
using PE.IService.Usuario;
using PE.IService.Usuario.Dto;
using PE.Model.Common;
using PE.Model.Request;
using PE.Model.Response;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Claims;
using System.Text;

namespace PE.Service.Usuario
{
    public class UsuarioService : IUsuarioService
    {

        private readonly IUsuarioRepository _usuarioRepository = new UsuarioRepository();
        private readonly AppSettings _appSettings;

        public UsuarioService(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }
        

        public UsuarioDto Add(UsuarioDto dto)
        {
            var obj = new Domain.Entity.Usuario.Usuario
            {
                User = dto.User,
                Password = dto.Password,
                Estado = dto.Estado,
                EmpresaId = dto.EmpresaId
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
                obj.EmpresaId = dto.EmpresaId;

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
                    Eliminado = x.Eliminado,
                    EmpresaId = x.EmpresaId
                });
        }

        public IEnumerable<UsuarioDto> GetByFilter(string query)
        {
            return _usuarioRepository.GetByFilter(x => x.User.Contains(query))
                .Select(x => new UsuarioDto
                {
                    Id = x.Id,
                    User = x.User,
                    Password = x.Password,
                    Estado = x.Estado,
                    Eliminado = x.Eliminado,

                    EmpresaId = x.EmpresaId
                });
        }

        public UsuarioDto GetById(long id)
        {
            var Usuario = _usuarioRepository.GetById(id);

            if (Usuario == null)
                return null;

            return new UsuarioDto
            {
                Id = Usuario.Id,
                User = Usuario.User,
                Password = Usuario.Password,
                Estado = Usuario.Estado,
                Eliminado = Usuario.Eliminado,
                EmpresaId = Usuario.EmpresaId
            };

        }

        public UsuarioDto ValidarUsuario(string user , string pass)
        {
            var Usuario = _usuarioRepository.GetAll().FirstOrDefault(x => x.User == user &&
                            x.Password == pass);

            if (Usuario == null) return null;

            return new UsuarioDto
            {
                Id = Usuario.Id,
                User = Usuario.User,
                Password = Usuario.Password,
                Estado = Usuario.Estado,
                Eliminado = Usuario.Eliminado,
                EmpresaId = Usuario.EmpresaId

            };
        }

        public UserResponse Auth(AuthRequest model)
        {
            UserResponse userResponse = new UserResponse();

            var usuario = ValidarUsuario(model.Usuario, model.Password);

            if (usuario == null) return null;

            userResponse.Usuario = usuario.User;
            userResponse.Token = GetToken(usuario);
            userResponse.Cargo = usuario.Cargo;
    
            return userResponse;

        }

        
        private string GetToken(UsuarioDto user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();

            var llave = Encoding.ASCII.GetBytes(_appSettings.Secreto);
            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(
                    new Claim[]
                    {
                        new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                        new Claim(ClaimTypes.Email, user.User.ToString())
                    }),
                Expires = DateTime.UtcNow.AddDays(60),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(llave), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        public string Encriptar(string password)
        {
            return null;
        }


    }
}

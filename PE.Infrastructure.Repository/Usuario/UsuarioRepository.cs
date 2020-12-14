using PE.Domain.Entity.Usuario;
using PE.Domain.Repository.Usuario;
using PE.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace PE.Infrastructure.Repository.Usuario
{
    public class UsuarioRepository : Repository<Domain.Entity.Usuario.Usuario> , IUsuarioRepository
    {

    }
}

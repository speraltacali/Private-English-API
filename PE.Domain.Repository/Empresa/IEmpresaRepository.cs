using PE.Domain.Entity.Empresa;
using PE.Repository.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace PE.Domain.Repository.Empresa
{
    public interface IEmpresaRepository : IRepository<Domain.Entity.Empresa.Empresa> 
    {
    }
}

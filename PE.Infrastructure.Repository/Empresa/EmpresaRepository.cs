using PE.Domain.Repository.Empresa;
using PE.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace PE.Infrastructure.Repository.Empresa
{
    public class EmpresaRepository : Repository<Domain.Entity.Empresa.Empresa> , IEmpresaRepository
    {
    }
}

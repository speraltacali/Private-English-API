using PE.Domain.Repository.Empleado;
using PE.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace PE.Infrastructure.Repository.Empleado
{
    public class EmpleadoRepository : Repository<PE.Domain.Entity.Empleado.Empleado> , IEmpleadoRepository
    {
    }
}

using PE.Domain.Repository.Profesor;
using PE.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace PE.Infrastructure.Repository.Profesor
{
    public class ProfesorRepository : Repository<PE.Domain.Entity.Profesor.Profesor>, IProfesorRepository
    {
    }
}

using PE.Domain.Entity.Novedades;
using PE.Domain.Repository.Novedades;
using PE.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace PE.Infrastructure.Repository.Novedades
{
    public class NovedadesRepository : Repository<Domain.Entity.Novedades.Novedades> , INovedadesRepository
    {
    }
}

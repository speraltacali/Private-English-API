using PE.Domain.Repository.Galeria;
using PE.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace PE.Infrastructure.Repository.Galeria
{
    public class GaleriaRepository : Repository<Domain.Entity.Galeria.Galeria> , IGaleriaRepository
    {
    }
}

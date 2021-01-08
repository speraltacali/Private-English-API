using PE.Domain.Repository.Persona;
using PE.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace PE.Infrastructure.Repository.Persona
{
    public class PersonaRepository : Repository<PE.Domain.Entity.Persona.Persona> , IPersonaRepository
    {
    }
}

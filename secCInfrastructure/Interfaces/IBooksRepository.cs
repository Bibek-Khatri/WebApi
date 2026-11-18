using secCDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace secCInfrastructure.Interfaces
{
    internal interface Interface1
    {
        Task<List<Book>> GetAllAsync();
    }
}

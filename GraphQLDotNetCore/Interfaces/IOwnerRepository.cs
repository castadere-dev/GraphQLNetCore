using System;
using GraphQLDotNetCore.Entities;
using System.Collections.Generic;

namespace GraphQLDotNetCore.Interfaces
{
    public interface IOwnerRepository
    {
        IEnumerable<Owner> GetAll();
        Owner GetById(Guid id);
    }
}

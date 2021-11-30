using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;
using GraphQLDotNetCore.Entities;

namespace GraphQLDotNetCore.GraphQL.Types
{
    public class AccountTypeEnumType : EnumerationGraphType<TypeOfAccount>
    {
        public AccountTypeEnumType()
        {
            //One important thing to mention is that the value for the Name property must mache the name
            //of the same enumeration property inside the Account 
            Name = "Type";
            Description = "Enumeration for the account type object.";
        }
    }
}

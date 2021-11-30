using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;
using GraphQLDotNetCore.Entities;

namespace GraphQLDotNetCore.GraphQL.Types
{
    public class AccountType : ObjectGraphType<Account>
    {
        public AccountType()
        {
            Field(x => x.Id, type: typeof(IdGraphType)).Description("Id from the account.");

            Field(x => x.Description).Description("Description from the account.");

            Field(x => x.OwnerId, type: typeof(IdGraphType)).Description("OwnerId property from the account object.");

            Field<AccountTypeEnumType>("Type", "Enumeration for the account type object.");
        }
    }
}

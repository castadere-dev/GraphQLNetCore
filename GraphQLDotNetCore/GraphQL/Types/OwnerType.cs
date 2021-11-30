using System;
using GraphQL.DataLoader;
using GraphQL.Types;
using GraphQLDotNetCore.Entities;
using GraphQLDotNetCore.Interfaces;

namespace GraphQLDotNetCore.GraphQL.Types
{
    public class OwnerType : ObjectGraphType<Owner>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountRepository"></param>
        /// <param name="dataLoader">Context.GetOrAddCollectionBatchLoader</param>
        public OwnerType(IAccountRepository accountRepository, IDataLoaderContextAccessor dataLoader)
        {
            Field(x => x.Id, type: typeof(IdGraphType)).Description("Id property from the owner");
            Field(x => x.Name).Description("Name of Owner.");
            Field(x => x.Address).Description("Address of the owner");

            //Field<ListGraphType<AccountType>>(
            //    "accounts",
            //    resolve: context => accountRepository.GetAllAccountsPerOwner(context.Source.Id)
            //);
            
            Field<ListGraphType<AccountType>>(
                "accounts",
                resolve: context =>
                {
                    var loader = dataLoader.Context.GetOrAddCollectionBatchLoader<Guid, Account>
                                            ("GetAccountsByOwnerIds", accountRepository.GetAccountsByOwnerIds);
                  
                    return loader.LoadAsync(context.Source.Id);
                });


        }
    }
}

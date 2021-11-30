using System;
using GraphQL;
using GraphQL.Types;
using GraphQLDotNetCore.Interfaces;
using GraphQLDotNetCore.GraphQL.Types;

namespace GraphQLDotNetCore.GraphQL.Queries
{
    public class AppQuery : ObjectGraphType
    {
        public AppQuery(IOwnerRepository repository)
        {
            Field<ListGraphType<OwnerType>>(
               "owners",
               resolve: context => repository.GetAll()
           );


            //Field<OwnerType>(
            //    "owner",
            //    arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "ownerId" }),
            //    resolve: context =>
            //    {
            //        var id = context.GetArgument<Guid>("ownerId");
            //        return repository.GetById(id);
            //    }
            //);

            
            Field<OwnerType>(
                "owner",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "ownerId" }),
                resolve: context =>
                {
                    Guid id;
                    if (!Guid.TryParse(context.GetArgument<string>("ownerId"), out id))
                    {
                        //error id is wrong
                        context.Errors.Add(new ExecutionError("Wrong value for guid"));
                        return null;
                    }

                    return repository.GetById(id);
                }
            );
        }
    }
}

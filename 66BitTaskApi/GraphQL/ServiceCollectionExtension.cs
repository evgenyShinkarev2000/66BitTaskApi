using _66BitTaskApi.GraphQL.Mappers;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _66BitTaskApi.GraphQL
{
    public static class ServiceCollectionExtension
    {
        public static void AddAppGraphQl(this IServiceCollection services)
        {
            services.AddScoped<IAddFootbalIernputToData, AddFootbalIernputToData>();
            services.AddScoped<IUpdateFootballerInputToData, UpdateFootballerInputToData>();

            services.AddScoped<IAddTeamInputToData, AddTeamInputToData>();

            services.AddAutoMapper(typeof(GraphQlToDataAutoMapperProfile));

            services.AddGraphQLServer()
                .AddInMemorySubscriptions()
                .AddQueryType<Queries>()
                .AddMutationType<Mutations>()
                .AddSubscriptionType<Subscriptions>()
                .AddProjections();
        }
    }
}

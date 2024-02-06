using _66BitTaskApi.Data;
using _66BitTaskApi.Data.Models;
using _66BitTaskApi.Data.Repositories;
using HotChocolate;
using HotChocolate.Data;
using HotChocolate.Types;
using System.Linq;

namespace _66BitTaskApi.GraphQL
{
    public class Queries
    {
        [UseServiceScope]
        [UseProjection]
        public IQueryable<Footballer> Footballers([Service(ServiceKind.Resolver)] IFootballerRepository footballerRepository)
            => footballerRepository.Raw;

        [UseServiceScope]
        [UseProjection]
        public IQueryable<Team> Teams([Service(ServiceKind.Resolver)] ITeamRepository teamRepository)
            => teamRepository.Raw;

        [UseServiceScope]
        [UseProjection]
        public IQueryable<Country> Countries([Service(ServiceKind.Resolver)] ICountryRepository countryRepository)
            => countryRepository.Raw;
    }
}

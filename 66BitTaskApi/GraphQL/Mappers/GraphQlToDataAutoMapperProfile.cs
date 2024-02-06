using _66BitTaskApi.Data.Models;
using _66BitTaskApi.GraphQL.Schema;
using AutoMapper;

namespace _66BitTaskApi.GraphQL.Mappers
{
    public class GraphQlToDataAutoMapperProfile : Profile
    {
        public GraphQlToDataAutoMapperProfile()
        {
            CreateMap<IdInput, Footballer>();
            CreateMap<IdInput, Country>();
            CreateMap<IdInput, Team>();
            CreateMap<AddFootballerInput, Footballer>();
            CreateMap<UpdateFootballerInput, Footballer>();
            CreateMap<AddTeamInput, Team>();
        }
    }
}

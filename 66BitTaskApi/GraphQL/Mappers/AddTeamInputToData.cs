using _66BitTaskApi.Data.Models;
using _66BitTaskApi.GraphQL.Schema;
using AutoMapper;

namespace _66BitTaskApi.GraphQL.Mappers
{
    public interface IAddTeamInputToData : IInputToDataMapper<AddTeamInput, Team>
    {
    }

    public class AddTeamInputToData : IAddTeamInputToData
    {
        private readonly IMapper mapper;

        public AddTeamInputToData(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public Team Map(AddTeamInput input)
            => mapper.Map<Team>(input);
    }
}

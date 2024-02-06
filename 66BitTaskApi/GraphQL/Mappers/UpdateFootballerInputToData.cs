using _66BitTaskApi.Data.Models;
using _66BitTaskApi.GraphQL.Schema;
using AutoMapper;

namespace _66BitTaskApi.GraphQL.Mappers
{
    public interface IUpdateFootballerInputToData : IInputToDataMapper<UpdateFootballerInput, Footballer>
    {
    }

    public class UpdateFootballerInputToData : IUpdateFootballerInputToData
    {
        private readonly IMapper mapper;

        public UpdateFootballerInputToData(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public Footballer Map(UpdateFootballerInput input)
            => mapper.Map<Footballer>(input);
    }
}

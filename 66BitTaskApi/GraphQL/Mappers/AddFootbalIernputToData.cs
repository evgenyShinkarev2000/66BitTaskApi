using _66BitTaskApi.Data.Models;
using _66BitTaskApi.GraphQL.Schema;
using AutoMapper;

namespace _66BitTaskApi.GraphQL.Mappers
{
    public interface IAddFootbalIernputToData : IInputToDataMapper<AddFootballerInput, Footballer>
    {
    }

    public class AddFootbalIernputToData : IAddFootbalIernputToData
    {
        private readonly IMapper mapper;

        public AddFootbalIernputToData(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public Footballer Map(AddFootballerInput input)
            => mapper.Map<Footballer>(input);
    }
}

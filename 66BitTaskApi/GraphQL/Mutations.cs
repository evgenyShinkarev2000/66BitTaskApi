using _66BitTaskApi.Data.Models;
using _66BitTaskApi.Data.Repositories;
using _66BitTaskApi.GraphQL.Mappers;
using _66BitTaskApi.GraphQL.Schema;
using HotChocolate;
using HotChocolate.Data;
using HotChocolate.Subscriptions;
using HotChocolate.Types;
using System.Threading.Tasks;

namespace _66BitTaskApi.GraphQL
{
    public class Mutations
    {
        [UseServiceScope]
        [UseProjection]
        public async Task<Footballer> AddFootballer(
            [Service(ServiceKind.Resolver)] IFootballerRepository footballerRepository,
            [Service] IAddFootbalIernputToData addFootbalIernputToData,
            [Service] ITopicEventSender topicEventSender,
            AddFootballerInput addFootballerInput)
        {
            var footballerData = addFootbalIernputToData.Map(addFootballerInput);

            footballerData = await footballerRepository.Add(footballerData);
            await topicEventSender.SendAsync(nameof(this.AddFootballer), footballerData);

            return footballerData;
        }

        [UseServiceScope]
        [UseProjection]
        public async Task<Footballer> UpdateFootballer(
            [Service(ServiceKind.Resolver)] IFootballerRepository footballerRepository,
            [Service] IUpdateFootballerInputToData updateFootballerInputToData,
            [Service] ITopicEventSender topicEventSender,
            UpdateFootballerInput updateFootballerInput)
        {
            var footballerData = updateFootballerInputToData.Map(updateFootballerInput);

            footballerData = await footballerRepository.Update(footballerData);
            await topicEventSender.SendAsync(nameof(this.UpdateFootballer), footballerData);

            return footballerData;
        }

        [UseServiceScope]
        [UseProjection]
        public async Task<Team> AddTeam(
            [Service(ServiceKind.Resolver)] ITeamRepository teamRepository,
            [Service] IAddTeamInputToData addTeamInputToData,
            [Service] ITopicEventSender topicEventSender,
            AddTeamInput addTeamInput)
        {
            var teamData = addTeamInputToData.Map(addTeamInput);

            teamData = await teamRepository.Add(teamData);
            await topicEventSender.SendAsync(nameof(this.AddTeam), teamData);

            return teamData;
        }
    }
}

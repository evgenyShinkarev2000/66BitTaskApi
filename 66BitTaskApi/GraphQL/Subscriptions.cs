using _66BitTaskApi.Data.Models;
using HotChocolate;
using HotChocolate.Types;

namespace _66BitTaskApi.GraphQL
{
    public class Subscriptions
    {
        [Subscribe]
        [Topic(nameof(Mutations.AddFootballer))]
        public Footballer OnFootballerAdded([EventMessage] Footballer addedFootballer)
            => addedFootballer;

        [Subscribe]
        [Topic(nameof(Mutations.UpdateFootballer))]
        public Footballer OnFootballerUpdated([EventMessage] Footballer updatedFootBaller)
            => updatedFootBaller;

        [Subscribe]
        [Topic(nameof(Mutations.AddTeam))]
        public Team OnTeamAdded([EventMessage] Team addedTeam)
            => addedTeam;
    }
}

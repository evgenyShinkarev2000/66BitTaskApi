using _66BitTaskApi.Data.Models;
using System.Linq;
using System.Threading.Tasks;

namespace _66BitTaskApi.Data.Repositories
{
    public interface ITeamRepository
    {
        IQueryable<Team> Raw { get; }

        Task<Team> Add(Team team);
    }

    public class TeamRepository : ITeamRepository
    {
        public IQueryable<Team> Raw => appDbContext.Teams;

        private readonly AppDbContext appDbContext;

        public TeamRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<Team> Add(Team team)
        {
            appDbContext.Teams.Add(team);

            await appDbContext.SaveChangesAsync();

            return team;
        }
    }
}

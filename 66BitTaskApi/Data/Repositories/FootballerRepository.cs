using _66BitTaskApi.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace _66BitTaskApi.Data.Repositories
{
    public interface IFootballerRepository
    {
        IQueryable<Footballer> Raw { get; }

        Task<Footballer> Add(Footballer footballer);
        Task<Footballer> Update(Footballer footballer);
    }

    public class FootballerRepository : IFootballerRepository
    {
        public IQueryable<Footballer> Raw => appDbContext.Footballers;

        private readonly AppDbContext appDbContext;

        public FootballerRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<Footballer> Add(Footballer footballer)
        {
            if (footballer.Team != null)
            {
                footballer.Team = await appDbContext.Teams.FindAsync(footballer.Team.Id) ?? throw new Exception();
            }
            if (footballer.Country != null)
            {
                footballer.Country = await appDbContext.Countries.FindAsync(footballer.Country.Id) ?? throw new Exception();
            }

            appDbContext.Footballers.Add(footballer);

            await appDbContext.SaveChangesAsync();

            return footballer;
        }

        public async Task<Footballer> Update(Footballer footballer)
        {
            var oldFootballer = await appDbContext.Footballers.FindAsync(footballer.Id) ?? throw new Exception();
            if (footballer.Team != null)
            {
                footballer.Team = await appDbContext.Teams.FindAsync(footballer.Team.Id) ?? throw new Exception();
            }

            if (footballer.Country != null)
            {
                footballer.Country = await appDbContext.Countries.FindAsync(footballer.Country.Id) ?? throw new Exception();
            }

            appDbContext.Entry(oldFootballer).State = EntityState.Detached;
            appDbContext.Update(footballer);

            await appDbContext.SaveChangesAsync();

            return footballer;
        }
    }
}

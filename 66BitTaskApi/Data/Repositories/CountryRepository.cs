using _66BitTaskApi.Data.Models;
using System.Linq;
using System.Threading;

namespace _66BitTaskApi.Data.Repositories
{
    public interface ICountryRepository
    {
        IQueryable<Country> Raw { get; }
    }

    public class CountryRepository : ICountryRepository
    {
        public IQueryable<Country> Raw => appDbContext.Countries;

        private readonly AppDbContext appDbContext;

        public CountryRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
    }
}

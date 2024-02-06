using _66BitTaskApi.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace _66BitTaskApi.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Footballer> Footballers { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Country> Countries { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
}

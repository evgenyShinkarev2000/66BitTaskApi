
using Microsoft.AspNetCore.Builder;
using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using _66BitTaskApi.Data;
using Microsoft.Extensions.Configuration;
using _66BitTaskApi.Data.Repositories;
using _66BitTaskApi.GraphQL;

namespace _66BitTaskApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContextPool<AppDbContext>(options =>
            {
                options.UseSqlite(builder.Configuration.GetConnectionString("Sqlite") ?? throw new NullReferenceException());
            });

            builder.Services.AddScoped<ICountryRepository, CountryRepository>();
            builder.Services.AddScoped<IFootballerRepository, FootballerRepository>();
            builder.Services.AddScoped<ITeamRepository, TeamRepository>();

            builder.Services.AddCors();
            builder.Services.AddAppGraphQl();

            var app = builder.Build();

            app.UseCors(options =>
            {
                options.AllowAnyOrigin();
                options.AllowAnyHeader();
                options.AllowAnyMethod();
            });
            app.UseHttpsRedirection();
            app.UseWebSockets();
            app.MapGraphQL();


            app.Run();
        }
    }
}

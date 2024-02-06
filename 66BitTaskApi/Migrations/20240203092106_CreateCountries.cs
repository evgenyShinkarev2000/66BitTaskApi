using _66BitTaskApi.Data.Models;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _66BitTaskApi.Migrations
{
    /// <inheritdoc />
    public partial class CreateCountries : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData($"{nameof(Data.AppDbContext.Countries)}", $"{nameof(Country.Name)}", new string[]
            {
                "Россия",
                "США",
                "Италия",
            });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData($"{nameof(Data.AppDbContext.Countries)}", $"{nameof(Country.Name)}", new string[]
            {
                "Россия",
                "США",
                "Италия",
            });
        }
    }
}

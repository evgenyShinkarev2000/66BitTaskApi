using _66BitTaskApi.Data.Models;
using System;

namespace _66BitTaskApi.GraphQL.Schema
{
    public record UpdateFootballerInput(int Id, string Name, string Surname, Gender Gender, DateOnly Bithday, IdInput Team, IdInput Country);
}

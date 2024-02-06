using System;

namespace _66BitTaskApi.Data.Models
{
    public class Footballer : Entity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Gender Gender { get; set; }
        public DateOnly Bithday { get; set; }
        public Team Team { get; set; }
        public Country Country { get; set; }

    }

    public enum Gender
    {
        Male,
        Female,
    }
}

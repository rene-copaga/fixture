using System;

namespace Fixture.Model
{
    public class Player : Participant
    {
        public Player(string names, string lastNames, DateTime birthDate) : base()
        {
            Names = names;
            LastNames = lastNames;
            BirthDate = birthDate;
        }

        public string Names { get; set; }

        public string LastNames { get; set; }

        public DateTime BirthDate { get; set; }

        public int Height { get; set; }

        public int Weight { get; set; }
    }
}

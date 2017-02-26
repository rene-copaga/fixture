using System.Collections.Generic;

namespace Fixture.Model
{
    public class Team : Participant
    {
        public Team(string teamName) : base()
        {
            TeamName = teamName;
            //players = new List<Player>();
        }

        public string TeamName { get; set; }

        //public ICollection<Player> players;
    }
}

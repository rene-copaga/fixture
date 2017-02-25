using System.Collections.Generic;

namespace Fixture.Model
{
    public class Team : Participant
    {
        private string teamName;
        private IList<Player> players;

        public Team(string teamName) : base()
        {
            this.teamName = teamName;
            players = new List<Player>();
        }

        public string TeamName
        {
            get { return teamName; }
            set { teamName = value; }
        }
    }
}

using System;

namespace Fixture.Model
{
    public class Player : Participant
    {
        private string names;
        private string lastNames;
        private int height;
        private int weight;
        DateTime birthDate;

        public Player(string names, string lastNames, DateTime birthDate) : base()
        {
            this.names = names;
            this.lastNames = lastNames;
            this.birthDate = birthDate;
        }

        public string Names
        {
            get { return names; }
            set { names = value; }
        }

        public string LastNames
        {
            get { return lastNames; }
            set { lastNames = value; }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
    }
}

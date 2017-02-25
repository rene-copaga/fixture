using System;
using System.Collections.Generic;

namespace Fixture.Model
{
    public class Championship
    {
        private DateTime    startDate;
        private string      name;
        private Place       place;
        private int         id;
        private IList<Participant> participants;

        public Championship(DateTime startDate)
        {
            this.startDate = startDate;
            participants = new List<Participant>();
        }

        public Championship(string name, DateTime startDate) : this(startDate)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Place Place
        {
            get { return place; }
            set { place = value; }
        }

        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        public void RegisterParticipant(Participant participant)
        {
            participants.Add(participant);
        }

        public void RemoveParticipant(Participant participant)
        {
            participants.Remove(participant);
        }
    }
}

using System;
using System.Collections.Generic;

namespace Fixture.Model
{
    public class Championship
    {
        public Championship(DateTime startDate)
        {
            StartDate = startDate;
            Participants = new List<Participant>();
        }

        public Championship(string name, DateTime startDate) : this(startDate)
        {
            Name = name;
        }

        public int ChampionshipId { get; set; }

        public string Name { get; set; }

        public Place Place { get; set; }

        public DateTime StartDate { get; set; }

        private ICollection<Participant> Participants { get; set; }

        public void RegisterParticipant(Participant participant)
        {
            Participants.Add(participant);
        }

        public void RemoveParticipant(Participant participant)
        {
            Participants.Remove(participant);
        }
    }
}

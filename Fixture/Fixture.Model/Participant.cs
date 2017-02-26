using System;

namespace Fixture.Model
{
    public abstract class Participant
    {
        public Participant()
        {
            RegisterDate = DateTime.Now;
        }

        public int ParticipantId { get; set; }

        public DateTime RegisterDate { get; set; }

        public int ChampionshipId { get; set; }

        public Championship Championship { get; set; }
    }
}

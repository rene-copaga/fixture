using System;

namespace Fixture.Model
{
    public abstract class Participant
    {
        DateTime registerDate;

        public Participant()
        {
            registerDate = DateTime.Now;
        }

        public DateTime RegisterDate
        {
            get { return registerDate; }
            set { registerDate = value; }
        }
    }
}

using System;
using System.Collections.Generic;

namespace Fixture.Model
{
    public class ChampionshipsManager
    {
        IList<Championship> championships;

        public ChampionshipsManager()
        {
            championships = new List<Championship>();
        }

        public void RegisterChampionship(Championship championship)
        {
            championships.Add(championship);
        }

        public IList<Championship> GetChampionships(string championshipName)
        {
            List<Championship> result = new List<Championship>();

            foreach (Championship championship in championships)
            {
                if (championship.Name == championshipName)
                {
                    result.Add(championship);
                }
            }

            return result;
        }

        public IList<Championship> GetChampionships(DateTime startDate, DateTime endDate)
        {
            List<Championship> result = new List<Championship>();

            foreach (Championship championship in championships)
            {
                if (championship.StartDate >= startDate && championship.StartDate <= endDate)
                {
                    result.Add(championship);
                }
            }

            return result;
        }
    }
}

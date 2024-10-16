using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damian1RacingEvent1
{
    public class RaceEvent : Event
    {

        public List<Race> races = new List<Race>();
        public RaceEvent(string name, string location) : base(name, location) { }

        public List<Race> Races
        {
            get { return races; }
            set { races = value; }
        }
        public void AddRace(Race r)
        {
            Races.Add(r);
        }
    }
}
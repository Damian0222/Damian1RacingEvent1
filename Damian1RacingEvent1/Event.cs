using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damian1RacingEvent1
{
    public abstract class Event
    {
        public string name;
        public string location;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        public Event(string name, string location)
        {
            Name = name;
            Location = location;
        }
    }

}


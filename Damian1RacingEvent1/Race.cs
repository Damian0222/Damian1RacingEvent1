using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damian1RacingEvent1 { 
 public class Race

  {
    public string name;
    public DateTime startTime;
    public List<Horse> horses = new List<Horse>();

        //setters and getters, Constructorss
        public string Name
    {
            get { return name; }
            set { name = value; }

        }
     public DateTime StartTime
        {
            get { return startTime; }
            set { startTime = value; }
        }
    public List<Horse> Horses
    {
        get { return horses; }
        set { horses = value; }
    }

    public Race(string name, DateTime startTime)
        {
            Name = name;
            StartTime = startTime;
        }

        public void AddHorse(Horse horse)
        {
            Horses.Add(horse);
            }
    }

 }


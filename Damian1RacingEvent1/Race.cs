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

        public override string? ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object? obj)
        {
            return obj is Race race &&
                   name == race.name &&
                   startTime == race.startTime &&
                   EqualityComparer<List<Horse>>.Default.Equals(horses, race.horses) &&
                   Name == race.Name &&
                   StartTime == race.StartTime &&
                   EqualityComparer<List<Horse>>.Default.Equals(Horses, race.Horses);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(name, startTime, horses, Name, StartTime, Horses);
        }
    }

 }


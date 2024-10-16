using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damian1RacingEvent1
{
    public class RacecourseMan
    {
       public void createRaceEv(List<RaceEvent> raceEv)
        {
            Console.WriteLine("Create the name of your event: ");
            string Ename = Console.ReadLine();
            Console.WriteLine("Enter the location of your event: ");
            string eventloc = Console.ReadLine();

            RaceEvent newEv = new RaceEvent(Ename,eventloc);
            raceEv.Add(newEv);
           
            Console.WriteLine($"New event '{Ename}' has been created in '{eventloc}'.");

        }
    }
}

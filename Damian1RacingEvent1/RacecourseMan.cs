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

            RaceEvent newEv = new RaceEvent(Ename, eventloc);
            raceEv.Add(newEv);

            Console.WriteLine($"New event '{Ename}' has been created in '{eventloc}'.");

        }

       
        
        public void AddRaceeToE(List<RaceEvent> raceEv1)
        {
            if (raceEv1.Count == 0)
            {
                Console.WriteLine("No events created yet.");
                return;
            }
            Console.WriteLine("Please select an event to add a race to:");
            for (int i = 0; i < raceEv1.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {raceEv1[i].Name} at {raceEv1[i].Location}");
            }
            int info = int.Parse(Console.ReadLine()) - 1;

            Console.Write("The name of the race: ");
            string raceName = Console.ReadLine();
            Console.Write("Choose the start time (yyyy-mm-dd hh:mm");
            DateTime raceStart = DateTime.Parse(Console.ReadLine());
            Race newR = new Race(raceName, raceStart);
            raceEv1[info].AddRace(newR);

            Console.WriteLine($"Race'{raceName}' added to event' {raceEv1[info].Name}'.");

        }

    }
}
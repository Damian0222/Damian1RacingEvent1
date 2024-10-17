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


        public void AddhorsesToR(List<RaceEvent> raceEv2)
        {
            if (raceEv2.Count == 0)
            {
                Console.WriteLine("No events available here.");
                return;
            }
            Console.WriteLine("Select an event to add a horse  to:");
            for (int i = 0; i < raceEv2.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {raceEv2[i].Name} at {raceEv2[i].Location}");
            }
            int eventPos = int.Parse(Console.ReadLine()) - 1;
            RaceEvent events = raceEv2[eventPos];
            if (events.races.Count == 0)
            {
                Console.WriteLine("No race");
                return;
            }
            Console.WriteLine("Which race would you like to add horse to");
            for (int i = 0; i < events.races.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {events.Races[i].Name}");
            }
            int racePos = int.Parse(Console.ReadLine()) - 1;
            Race uChoice = events.Races[racePos];
            Console.WriteLine("ID");
            string h1 = Console.ReadLine();
            Console.WriteLine("Name");
            string h2 = Console.ReadLine();
            Console.Write("Enter the horse D.O.B (YYYY-MM-DD): ");
            DateTime h3 = DateTime.Parse(Console.ReadLine());

            Horse newH = new Horse(h1, h2, h3);
            uChoice.AddHorse(newH);
            Console.WriteLine($"Horse {newH.Name} has been added to the race {uChoice.Name}.");



        }
    }

    }
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damian1RacingEvent1
{
    public class HorseOwner
    {
        public void AddhorsesToR1(List<RaceEvent> raceEv4)
        {
            if (raceEv4.Count == 0)
            {
                Console.WriteLine("No events available here.");
                return;
            }
            Console.WriteLine("Select an event to add a horse  to:");
            for (int i = 0; i < raceEv4.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {raceEv4[i].Name} at {raceEv4[i].Location}");
            }
            int eventPos = int.Parse(Console.ReadLine()) - 1;
            RaceEvent events = raceEv4[eventPos];
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
            Console.WriteLine("ID:");
            string h1 = Console.ReadLine();
            Console.WriteLine("Name");
            string h2 = Console.ReadLine();
            Console.Write("Enter the horse D.O.B (YYYY-MM-DD): ");
            DateTime h3 = DateTime.Parse(Console.ReadLine());

            Horse newH = new Horse(h1, h2, h3);
            uChoice.AddHorse(newH);
            Console.WriteLine($"Horse {newH.Name} has been added to {uChoice.Name}.");



        }
    }

}

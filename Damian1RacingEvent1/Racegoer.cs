using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Damian1RacingEvent1
{
    public class Racegoer
    {
    public void viewUpcomingEv(List<RaceEvent> raceEve4)
        { 
        if( raceEve4.Count == 0)
           {
                Console.WriteLine("\nNo events created yet");
                return;
            }
            Console.WriteLine("\n Upcoming race events:");
            for(int i = 0; i < raceEve4.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {raceEve4[i].Name} at {raceEve4[i].Location}");

            }
            Console.WriteLine("Select a event");
            if(int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= raceEve4.Count) {


}

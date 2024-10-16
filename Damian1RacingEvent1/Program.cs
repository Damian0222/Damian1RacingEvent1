using System.Runtime.CompilerServices;

namespace Damian1RacingEvent1
{
    class Program
    {
        static List<RaceEvent> raceEvent = new List<RaceEvent>();
        static RacecourseMan Rmanager = new RacecourseMan();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine($"\nWelcome to the horse racing event!");
                Console.WriteLine("1. Racecourse manager");
                Console.WriteLine("Select your role: ");
                string choice = Console.ReadLine(); ;

                switch (choice)
                {
                    case "1":
                        RmanagerMenu();
                        break;
                }
            }
        } 
            static void RmanagerMenu()
                {
                    while (true)
                    {
                        Console.WriteLine("1. Create a new event");
                        Console.Write("Enter your choice");
                        string num = Console.ReadLine();

                        switch (num)
                        {
                            case "1":
                                Rmanager.createRaceEv(raceEvent);
                                break;
                        }
                    }
                }
            }
        }
    
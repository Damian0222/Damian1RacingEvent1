using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
using System.Xml.Serialization;

namespace Damian1RacingEvent1
{
    class Program
    {
        static List<RaceEvent> raceEvent = new List<RaceEvent>();
        static RacecourseMan Rmanager = new RacecourseMan();
        static Racegoer Rgoer = new Racegoer();
        static HorseOwner Howner = new HorseOwner();
        static string User1;
       
        static void Main(string[] args)
        {
           user();
            while (true)
            {
                Console.WriteLine($"\nWelcome To The Racing Event!");
                Console.WriteLine("1. Racecourse manager");
                Console.WriteLine("2. Race goer");
                Console.WriteLine("3. Horse owner");
                Console.WriteLine("Select your role: ");
                string choice = Console.ReadLine(); ;

                switch (choice)
                {
                    case "1":
                        RmanagerMenu(); 
                        break;
                    case "2":
                        RGoerMenu();
                        break;
                    case "3":
                        Horseowner();
                        break;
                }
            }
        }
        static void RmanagerMenu()
        {
            while (true)
            {
                Console.WriteLine("\nWelcome To The Race Manager Menu!");
                Console.WriteLine("1. Would you like to create a new event?");
                Console.WriteLine("2. Would you like to add races to an event?");
                Console.WriteLine("3. Would you like to add horses to a race?");
                Console.WriteLine("4. Back to main menu");
                Console.Write("\nEnter your choice:");
                string num = Console.ReadLine();

                switch (num)
                {
                    case "1":
                        Rmanager.createRaceEv(raceEvent);
                        break;
                    case "2":
                        Rmanager.AddRaceeToE(raceEvent);
                        break;
                    case "3":
                        Rmanager.AddhorsesToR(raceEvent);
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid! Please try again.");
                        break;

                }
            }
        }
        static void RGoerMenu()
        {
            while (true)
            {
                Console.WriteLine("\nWelcome To The Race Goer Menu!");
                Console.WriteLine("1. View all upcoming events");
                Console.WriteLine("2. Back to the main menu");
                Console.Write("\nEnter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Rgoer.viewUpcomingEv(raceEvent);
                        break;
                    case "2":
                        return;
                    default:
                        Console.WriteLine("Invalid! Please try again.");
                        break;
                }
            }
        }

        static void Horseowner()
    {
        while (true)
        {
            Console.WriteLine("\nWelcome To The Horse Owner Menu!");
            Console.WriteLine("1. Add horses to a race);");
            Console.WriteLine("2. Back to the main menu");
            Console.Write("\nEnter your choice (1-2): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                   Howner.AddhorsesToR1(raceEvent);
                    break;
                case "2":
                     return;
                  default:
                 Console.WriteLine("Invalid! Please try again.");
                        break;
                }
        }
    }
static void user()
        {
            string[] userInfo = File.ReadAllLines("C:\\CollegeY3\\Frameworks\\Damian1RacingEvent1\\Damian1RacingEvent1\\users.txt");
            List<string> user = new List<string>();

            Console.WriteLine("\nRACING EVENT SYSTEM: ");

            foreach (string line in userInfo)
            {
                if (line.StartsWith("Please select User 1"))
                {
                    user.Add(line);
                }
            }
            for (int i = 0; i < user.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {user[i]}");
            }
            Console.Write("\nEnter the number of the user on display: ");
            int pos = int.Parse(Console.ReadLine()) - 1;

            User1 = userInfo[pos + 1].Split(':')[1].Trim();
            Console.WriteLine($"\nWelcome {User1} To Race Event Menu!");
        }
}
}


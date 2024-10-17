﻿using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Damian1RacingEvent1
{
    class Program
    {
        static List<RaceEvent> raceEvent = new List<RaceEvent>();
        static RacecourseMan Rmanager = new RacecourseMan();
        static Racegoer Rgoer = new Racegoer();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine($"\nWelcome to the horse racing event!");
                Console.WriteLine("1. Racecourse manager");
                Console.WriteLine("2. Racecgoer");
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
                Console.WriteLine("2. Add races to event");
                Console.WriteLine("3. Add horses to a race");
                Console.Write("Enter your choice");
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
                }
            }
        }
        static void RGoerMenu()
        {
            while (true)
            {

                Console.WriteLine("\nRacegoer Menu");
                Console.WriteLine("1. View all upcoming events");
                Console.Write("\nEnter your choice (1-2): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Rgoer.viewUpcomingEv(raceEvent);
                        break;
                }
            }
        }

    }
}
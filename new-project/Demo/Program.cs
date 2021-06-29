using System;
using System.Collections.Generic;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            BusRepository repository = new BusRepository();

            Console.Write("Where are you? ");
            string startingFrom = Console.ReadLine();
            Console.Write("Where do you want to go? ");
            string goingTo = Console.ReadLine();

            BusRoute[] originRoutes = repository.FindBusesTo(location: startingFrom);
            BusRoute[] destinationRoutes = repository.FindBusesTo(location: goingTo);
            HashSet<BusRoute> routes = new HashSet<BusRoute>(originRoutes);
            routes.IntersectWith(destinationRoutes);

            // BusRoute[] routes = repository.FindBusesBetween(from: startingFrom, to: goingTo);

            if (routes.Count > 0)
            {
                foreach (var route in routes)
                {
                    Console.WriteLine($"You can use route {route}");
                }
            }
            else
            {
                Console.WriteLine($"No routes to go to {goingTo} were found");
            }
        }


        public static void PrintRoutes(Dictionary<int, BusRoute> routes)
        {
            Console.WriteLine("All routes");
            foreach (var entry in routes)
            {
                BusRoute route = entry.Value;
                Console.WriteLine($"{route}");
            }
        }

    }
}

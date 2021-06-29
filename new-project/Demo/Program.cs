using System;
using System.Collections.Generic;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            BusRepository repository = new BusRepository();
            string[][] route5Times = repository.BusTimesRoute5.Times;
            string[] route5Locations = repository.BusTimesRoute5.Route.LocationsServed;

            for (int i = 0; i < route5Locations.Length; i++)
            {
                string location = route5Locations[i];
                Console.Write($"{location}:".PadRight(12));

                foreach (string time in route5Times[i])
                {
                    Console.Write($"{time} ");
                }
                Console.WriteLine();
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

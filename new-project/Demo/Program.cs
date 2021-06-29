using System;
using System.Collections.Generic;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            BusRepository repository = new BusRepository();
            BusTimes route5Times = repository.BusTimesRoute5;
            string[] route5Locations = route5Times.Route.LocationsServed;
            string[,] times = route5Times.Times;

            for (int i = 0; i < route5Locations.Length; i++)
            {
                string location = route5Locations[i];

                Console.Write($"{location}:".PadRight(12));
                int numColumns = times.GetLength(1);
                for (int j = 0; j < numColumns; j++)
                {
                    string time = times[i, j];
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

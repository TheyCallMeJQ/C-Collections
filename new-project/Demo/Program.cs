using System;
using System.Collections.Generic;
using System.Linq;


namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, BusRoute> routes = BusRepository.InitializeRoutes();
            Console.Write("Which route would you like? ");
            int routeNo = int.Parse(Console.ReadLine());
            if (routes.ContainsKey(routeNo))
            {
                Console.WriteLine($"You've selected: {routes[routeNo]}");
            }
            else
            {
                Console.WriteLine("That route doesn't exist :(");
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

        // public static List<BusRoute> FindBusesTo(string destination, List<BusRoute> routes)
        // {
        //     return routes.FindAll(r => r.Serves(destination));
        // }
    }
}

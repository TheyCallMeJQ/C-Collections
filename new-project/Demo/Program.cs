using System;
using System.Collections;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            BusRoute[] routes = BusRepository.InitializeRoutes();
            BusRoute[] relevantRoutes = FindBusesTo(destination: "Blackpool", routes);
            foreach (var rr in relevantRoutes)
            {
                Console.WriteLine($"{rr}");
            }
        }



        public static BusRoute[] FindBusesTo(string destination, BusRoute[] routes)
        {
            return Array.FindAll<BusRoute>(routes, r => r.Destination.ToLower() == destination.ToLower());
        }
    }
}

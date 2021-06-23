using System;
using System.Collections;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            BusRoute[] routes = BusRepository.InitializeRoutes();
            BusRoute[] relevantRoutes = FindBusesTo(destination: "Lancaster", routes);
            foreach (var rr in relevantRoutes)
            {
                Console.WriteLine($"{rr}");
            }
        }



        public static BusRoute[] FindBusesTo(string destination, BusRoute[] routes)
        {
            return Array.FindAll(routes, r => r.Serves(destination));
        }
    }
}

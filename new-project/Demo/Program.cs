using System;
using System.Linq;

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
            return routes.Where(r => r.Destination.ToLower() == destination.ToLower()).ToArray();
        }
    }
}

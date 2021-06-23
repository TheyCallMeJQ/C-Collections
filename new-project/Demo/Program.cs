using System;
using System.Linq;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            BusRoute route40 = new BusRoute(route: 40, source: "Morecambe", destination: "Preston");
            BusRoute route42 = new BusRoute(route: 42, source: "Lancaster", destination: "Blackpool");
            BusRoute[] routes = {
                route40, route42
            };
            BusRoute[] relevantRoutes = routes.Where(r => r.Destination.ToLower() == "blackpool").ToArray();
            foreach (var rr in relevantRoutes)
            {
                Console.WriteLine($"{rr}");
            }
        }
    }
}

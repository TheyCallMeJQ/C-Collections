using System;
using System.Collections.Generic;
using System.Linq;


namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BusRoute> routes = BusRepository.InitializeRoutes();
            // string destination = "Lancaster";
            // List<BusRoute> relevantRoutes = FindBusesTo(destination, routes);
            // Console.WriteLine($"Routes to: {destination}");
            // foreach (var rr in relevantRoutes)
            // {
            //     Console.WriteLine($"{rr}");
            // }

            Console.WriteLine("All routes - Before removal");
            foreach (var r in routes)
            {
                Console.WriteLine($"{r}");
            }
            routes.RemoveAll(r => r.LocationsServed.Any(l => l.Contains("test")));
            Console.WriteLine("All routes - After removal of test data");
            foreach (var r in routes)
            {
                Console.WriteLine($"{r}");
            }
        }



        public static List<BusRoute> FindBusesTo(string destination, List<BusRoute> routes)
        {
            return routes.FindAll(r => r.Serves(destination));
        }
    }
}


using System.Collections.Generic;

namespace Demo
{
    public class BusRepository
    {

        // public static BusRoute[] InitializeRoutes()
        // {
        //     return new BusRoute[]{
        //         new BusRoute(route: 40, locationsServed: new string[]{"Morecambe", "Lancaster", "Garstang", "Preston"}),
        //         new BusRoute(route: 42, locationsServed: new string[]{
        //             "Lancaster", "Garstang", "Blackpool"
        //         }),
        //         new BusRoute(route: 100, locationsServed: new string[]{
        //             "University", "Lancaster", "Morecambe"
        //         }),
        //         new BusRoute(route: 555, locationsServed: new string[]{
        //              "Lancaster", "Carnforth", "Kendal", "Windermere", "Keswick"
        //         }),
        //     };
        // }

        public static List<BusRoute> InitializeRoutes()
        {
            return new List<BusRoute>{
                new BusRoute(route: 40, locationsServed: new string[]{"Morecambe", "Lancaster", "Garstang", "Preston"}),
                new BusRoute(route: 42, locationsServed: new string[]{
                    "Lancaster", "Garstang", "Blackpool"
                }),
                new BusRoute(route: 100, locationsServed: new string[]{
                    "University", "Lancaster", "Morecambe"
                }),
                new BusRoute(route: 555, locationsServed: new string[]{
                     "Lancaster", "Carnforth", "Kendal", "Windermere", "Keswick"
                }),
                new BusRoute(route: 69, locationsServed: new string[]{
                    "this", "is", "test", "data"
                }),
            };
        }
    }
}

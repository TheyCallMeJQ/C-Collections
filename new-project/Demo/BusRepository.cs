
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

        public static Dictionary<int, BusRoute> InitializeRoutes()
        {
            return new Dictionary<int, BusRoute>(){
                {40, new BusRoute(route: 40, locationsServed: new string[]{"Morecambe", "Lancaster", "Garstang", "Preston"})},
                {42, new BusRoute(route: 42, locationsServed: new string[]{
                    "Lancaster", "Garstang", "Blackpool"
                })},
                {100, new BusRoute(route: 100, locationsServed: new string[]{
                    "University", "Lancaster", "Morecambe"
                })},
                {555, new BusRoute(route: 555, locationsServed: new string[]{
                     "Lancaster", "Carnforth", "Kendal", "Windermere", "Keswick"
                })},
                {5, new BusRoute(route: 5, locationsServed: new string[]{
                    "Overton", "Morecambe", "Carnforth"
                })},
                {69, new BusRoute(route: 69, locationsServed: new string[]{
                    "this", "is", "test", "data"
                })},
            };
        }
    }
}

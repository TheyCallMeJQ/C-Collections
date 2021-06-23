
using System;

namespace Demo
{
    public class BusRepository
    {

        public static BusRoute[] InitializeRoutes()
        {
            return new BusRoute[]{
                new BusRoute(route: 40, source: "Morecambe", destination: "Preston"),
                new BusRoute(route: 42, source: "Lancaster", destination: "Blackpool")
            };
        }
    }
}

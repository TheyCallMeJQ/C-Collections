
using System.Collections.Generic;
using System;

namespace Demo
{
    public class BusRepository
    {
        private BusRoute[] _busRoutes;

        public BusRoute[] FindBusesTo(string location)
        {
            return Array.FindAll<BusRoute>(this._busRoutes, route => route.Serves(location));
        }

        public BusRoute[] FindBusesBetween(string from, string to)
        {
            return Array.FindAll<BusRoute>(this._busRoutes, route => route.Serves(from) && route.Serves(to));
        }

        public BusRepository()
        {
            this._busRoutes = new BusRoute[] {
                new BusRoute(route: 40, locationsServed: new string[] { "Morecambe", "Lancaster", "Garstang", "Preston" }),
                new BusRoute(route: 42, locationsServed: new string[]{
                    "Lancaster", "Garstang", "Blackpool"
                }),
                new BusRoute(route: 100, locationsServed: new string[]{
                    "University", "Lancaster", "Morecambe"
                }),
                new BusRoute(route: 555, locationsServed: new string[]{
                     "Lancaster", "Carnforth", "Kendal", "Windermere", "Keswick"
                }),
                new BusRoute(route: 5, locationsServed: new string[]{
                    "Overton", "Morecambe", "Carnforth"
                }),
                new BusRoute(route: 69, locationsServed: new string[]{
                    "this", "is", "test", "data"
                })
            };
        }
    }
}

using System;

namespace Demo
{
    public class BusRoute
    {
        public int Route { get; }
        public string Destination
        {
            get
            {
                return LocationsServed[^1];
            }
        }
        public string Source
        {
            get
            {
                return LocationsServed[0];
            }
        }

        public string[] LocationsServed { get; }

        public BusRoute(int route, string[] locationsServed)
        {
            this.Route = route;
            this.LocationsServed = locationsServed;
        }

        public bool Serves(string location)
        {
            return Array.Exists(this.LocationsServed, route => route.ToLower() == location.ToLower());
        }

        public override string ToString() => $"{this.Route}: {this.Source} ->{(this.LocationsServed.Length > 2 ? " ... -> " : "")} {this.Destination}";
    }
}

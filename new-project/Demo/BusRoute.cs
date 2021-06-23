using System;

namespace Demo
{
    public class BusRoute
    {
        public int Route { get; }
        public string Destination { get; }
        public string Source { get; }
        public BusRoute(int route, string source, string destination)
        {
            this.Route = route;
            this.Source = source;
            this.Destination = destination;
        }

        public override string ToString() => $"{this.Route}: {this.Source} -> {this.Destination}";
    }
}

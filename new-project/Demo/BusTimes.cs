
using System.Collections.Generic;
using System;

namespace Demo
{
    public class BusTimes
    {
        public string[][] Times { get; }
        public BusRoute Route { get; }

        public BusTimes(string[][] times, BusRoute route)
        {
            this.Times = times;
            this.Route = route;
        }

        //TODO
        // public override string ToString()
        // {
        //     string msg = "";
        //     foreach(string time in Times){

        //     }
        //     return base.ToString();
        // }

    }
}

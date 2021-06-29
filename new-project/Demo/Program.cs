using System;
using System.Collections.Generic;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            BusStop stop = new BusStop();
            Bus bus = new Bus();
            const int NUM_PEOPLE = 6;

            for (int i = 0; i < NUM_PEOPLE; i++)
            {
                stop.NewPersonWaiting(PassengerGenerator.CreatePassenger());
            }

            stop.BusArrive(bus);
        }

    }
}

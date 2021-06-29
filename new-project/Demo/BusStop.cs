using System.Collections.Generic;
using System;

namespace Demo
{
    public class BusStop
    {
        private Queue<Passenger> _peopleWaiting = new Queue<Passenger>();
        public void NewPersonWaiting(Passenger p)
        {
            this._peopleWaiting.Enqueue(p);
            System.Console.WriteLine($"{p} arrived at the bus stop");
        }

        public void BusArrive(Bus b)
        {
            Console.WriteLine("The bus has arrived at the bus stop");

            Func<bool> thereIsSpaceOnTheBus = () => b.Space > 0;
            Func<bool> thereArePeopleWaiting = () => this._peopleWaiting.Count > 0;

            while (thereIsSpaceOnTheBus() && thereArePeopleWaiting())
            {
                Passenger p = this._peopleWaiting.Dequeue();
                b.Load(p);
            }
        }
    }
}
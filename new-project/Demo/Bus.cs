using System.Collections.Generic;
using System;
namespace Demo
{
    public class Bus
    {
        private Stack<Passenger> _passengers = new Stack<Passenger>();
        public readonly int Capacity = 5;
        public int Space { get => this.Capacity - this._passengers.Count; }

        public void Load(Passenger passenger)
        {
            if (Space < 1) throw new System.Exception("There is no more room on this bus!");
            this._passengers.Push(passenger);
            Console.WriteLine($"{passenger} got on the bus");
        }

        public void ReachTerminus()
        {
            Func<bool> thereArePassengers = () => this._passengers.Count > 0;
            while (thereArePassengers())
            {
                Passenger p = this._passengers.Pop();
                Console.WriteLine($"{p} got off the bus");
            }
            Console.WriteLine($"There is nobody left in the bus");

        }
    }
}
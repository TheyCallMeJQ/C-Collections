using System.Collections.Generic;
using System;
namespace Demo
{
    public class Bus
    {
        private List<Passenger> _passengers = new List<Passenger>();
        public readonly int Capacity = 5;
        public int Space { get => this.Capacity - this._passengers.Count; }

        public void Load(Passenger passenger)
        {
            if (Space < 1) throw new System.Exception("There is no more room on this bus!");
            this._passengers.Add(passenger);
            Console.WriteLine($"{passenger} got on the bus");
        }
    }
}
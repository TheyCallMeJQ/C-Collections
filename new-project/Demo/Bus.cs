using System.Collections.Generic;
using System;
namespace Demo
{
    public class Bus
    {
        private LinkedList<Passenger> _passengers = new LinkedList<Passenger>();
        public readonly int Capacity = 5;
        public int Space { get => this.Capacity - this._passengers.Count; }

        public void Load(Passenger passenger)
        {
            if (Space < 1) throw new System.Exception("There is no more room on this bus!");
            this._passengers.AddLast(passenger);
            Console.WriteLine($"{passenger} got on the bus");
        }

        public void ArriveAt(string location)
        {
            Console.WriteLine($"Bus arrived at {location}");
            LinkedListNode<Passenger> currentNode = this._passengers.First;

            while (currentNode != null)
            {
                LinkedListNode<Passenger> nextNode = currentNode.Next;
                Passenger passenger = currentNode.Value;
                if (passenger.Destination == location)
                {
                    Console.WriteLine($"{passenger} got off the bus");
                }
                currentNode = nextNode;
            }
        }
    }
}
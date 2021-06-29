using System.Collections.Generic;

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
            bool thereIsSpaceOnTheBus = b.Space > 0;
            bool thereArePeopleWaiting = this._peopleWaiting.Count > 0;
            while (thereIsSpaceOnTheBus && thereArePeopleWaiting)
            {
                Passenger p = this._peopleWaiting.Dequeue();
                b.Load(p);

                thereIsSpaceOnTheBus = b.Space > 0;
                thereArePeopleWaiting = this._peopleWaiting.Count > 0;
            }
        }
    }
}
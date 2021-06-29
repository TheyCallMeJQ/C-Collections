using System;
namespace Demo
{
    public class PassengerGenerator
    {
        private static int _count = 0;
        private static Random _rnd = new Random();
        public static Passenger CreatePassenger()
        {
            string destination = _rnd.Next(2) == 0 ? "Lancaster" : "Morecambe";
            int newCount = _count + 1;

            Passenger newPassenger = new Passenger(destination: destination, name: $"Person {newCount}");
            _count = newCount;

            return newPassenger;
        }
    }
}
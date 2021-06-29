namespace Demo
{
    public class PassengerGenerator
    {
        private static int _count = 0;
        public static Passenger CreatePassenger()
        {
            string destination = "Lancaster";
            int newCount = _count + 1;

            Passenger newPassenger = new Passenger(destination: destination, name: $"Person {newCount}");
            _count = newCount;

            return newPassenger;
        }
    }
}
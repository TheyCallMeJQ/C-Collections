namespace Demo
{
    public class Passenger
    {
        public string Destination { get; }
        public string Name { get; }

        public Passenger(string destination, string name)
        {
            this.Destination = destination;
            this.Name = name;
        }

        public override string ToString()
        {
            return $"{Name} going to {Destination}";
        }
    }
}
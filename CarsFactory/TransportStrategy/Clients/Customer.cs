using TransportStrategy.TransportStrategies;

namespace TransportStrategy
{
    public class Customer
    {
        public ITransportStrategy Strategy { get; set; }

        public Customer(ITransportStrategy strategy)
        {
            Strategy = strategy;
        }

        public int CalculateTime(int distance)
        {
            var speed = Strategy.GetTransportSpeed();
            var estimatedTimeTaken = distance / speed;
            return estimatedTimeTaken;
        }
    }
}
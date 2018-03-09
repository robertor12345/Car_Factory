using TransportStrategy.TransportStrategies;

namespace TransportStrategy.TransportStrategies
{
    public class PlaneStrategy : ITransportStrategy
    {
        public int GetTransportSpeed()
        {
            int speed = 200;

            return speed;
        }
    }
}
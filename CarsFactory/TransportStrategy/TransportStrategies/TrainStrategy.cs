namespace TransportStrategy.TransportStrategies
{
    public class TrainStrategy : ITransportStrategy
    {
        public int GetTransportSpeed()
        {
            int speed = 150;

            return speed;
        }
    }
}
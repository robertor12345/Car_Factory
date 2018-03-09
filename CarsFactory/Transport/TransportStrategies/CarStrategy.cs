namespace Transport
{
    internal class CarStrategy : ITransportStrategy
    {
        public int GetTransportSpeed()
        {
            int speed = 60;

            return speed;
        }
    }
}
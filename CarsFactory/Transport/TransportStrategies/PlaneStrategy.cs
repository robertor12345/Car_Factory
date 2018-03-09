namespace Transport
{
    internal class PlaneStrategy : ITransportStrategy
    {
        public int GetTransportSpeed()
        {
            int speed = 200;

            return speed;
        }
    }
}
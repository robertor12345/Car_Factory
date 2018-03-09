namespace Transport
{
    internal class TrainStrategy : ITransportStrategy
    {
        public int GetTransportSpeed()
        {
            int speed = 150;

            return speed;
        }
    }
}
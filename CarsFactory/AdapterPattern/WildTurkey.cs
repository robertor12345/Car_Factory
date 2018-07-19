namespace AdapterPattern
{
    public class WildTurkey : ITurkey
    {
        public string Gobble()
        {
            return "gobble gobble";
        }

        public string Fly()
        {
            return "flap flap";
        }
    }
}
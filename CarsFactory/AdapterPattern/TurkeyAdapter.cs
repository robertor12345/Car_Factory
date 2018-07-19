namespace AdapterPattern
{
    public class TurkeyAdapter : IDuck
    {
        private readonly WildTurkey turkey;

        public TurkeyAdapter(WildTurkey turkey)
        {
            this.turkey = turkey;
        }

        public string Quack()
        {
            return turkey.Gobble();
        }

        public string Fly()
        {
            return turkey.Fly();
        }
    }
}
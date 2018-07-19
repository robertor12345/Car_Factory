namespace AdapterPattern
{
    public class MallardDuck : IDuck
    {
        public string Quack()
        {
            return "Quack";
        }

        public string Fly()
        {
            return "Weeeee";
        }
    }
}
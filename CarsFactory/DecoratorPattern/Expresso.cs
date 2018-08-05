namespace DecoratorPattern
{
    public class Expresso : Beverage
    {
        public Expresso ()
        {
            Description = "This is an Expresso";
        }

        public override double Cost()
        {
            return 1.99;
        }
    }
}
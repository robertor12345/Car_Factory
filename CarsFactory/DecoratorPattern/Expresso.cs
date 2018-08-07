namespace DecoratorPattern
{
    public class Expresso : IBeverage
    {

        public string GetDescription()
        {
            return "This is an Expresso";
        }

        public double Cost()
        {
            return 1.99;
        }
    }
}
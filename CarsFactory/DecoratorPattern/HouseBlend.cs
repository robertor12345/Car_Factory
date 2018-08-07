namespace DecoratorPattern
{
    public class HouseBlend : IBeverage
    {
        public string GetDescription()
        {
            return "This is a HouseBlend";
        }

        public double Cost()
        {
            return 2.60;
        }
  
    }
}
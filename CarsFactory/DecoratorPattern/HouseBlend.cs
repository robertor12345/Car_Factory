namespace DecoratorPattern
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            Description = "This is a HouseBlend";
        }

        public override double Cost()
        {
            return 2.60;
        }
    }
}
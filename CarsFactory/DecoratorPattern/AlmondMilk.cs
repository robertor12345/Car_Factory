using DecoratorPattern;

namespace TestingPatterns
{
    public class AlmondMilk : Condiment
    {
        public Beverage beverage { get; set;}

        public AlmondMilk(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + " with Almond Milk";
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.6;
        }
    }
}
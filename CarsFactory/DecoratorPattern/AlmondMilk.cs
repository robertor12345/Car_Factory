using DecoratorPattern;

namespace TestingPatterns
{
    public class AlmondMilk : Condiment
    { 

        public AlmondMilk(IBeverage beverage)
        :base(beverage)
        {

        }

        public override string GetDescription()
        {
            return base.GetDescription() + " with Almond Milk";
        }

        public override double Cost()
        {
            return base.Cost() + 0.6;
        }
    }
}
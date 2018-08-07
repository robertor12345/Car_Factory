using DecoratorPattern;

namespace TestingPatterns
{
    public abstract class Condiment : IBeverage
    {
        private IBeverage Beverage;

        public Condiment(IBeverage beverage)
        {
            this.Beverage = beverage;
        }

        public virtual string GetDescription()
        {
            return Beverage.GetDescription();
        }

        public virtual double Cost()
        {
            return Beverage.Cost();
        }
    }
}
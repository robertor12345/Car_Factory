using DecoratorPattern;

namespace TestingPatterns
{
    public abstract class Condiment : Beverage
    {
        public abstract string GetDescription();
    }
}
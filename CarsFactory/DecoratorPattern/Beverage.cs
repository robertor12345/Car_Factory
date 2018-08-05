namespace DecoratorPattern
{
    public abstract class Beverage
    {
        public string Description {get;set; }

        public string GetDescription()
        {
            return Description;
        }

        public abstract double Cost();

    }
}
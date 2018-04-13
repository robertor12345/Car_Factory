namespace AbstractCookie
{
    public abstract class AbstractChocolateCookie
    {
        public abstract void CreateDough();
        public abstract void AddChocolateChips();
        public abstract void BakeInOven();

        public AbstractChocolateCookie CreateCookieTemplate()
        {
            CreateDough();
            AddChocolateChips();
            BakeInOven();
            return this;
        }

    }
}
namespace TestingPatterns
{
    public abstract class AbstractChocolateCookie
    {
        public abstract void CreateDough();
        public abstract void AddChocolateChips();
        public abstract void BakeInOven();

        public void CreateCookie()
        {
            CreateDough();
            AddChocolateChips();
        }

    }
}
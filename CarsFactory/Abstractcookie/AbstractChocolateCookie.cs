using System;

namespace AbstractCookie
{
    public abstract class AbstractChocolateCookie
    {
        public string BaseType { get; set; }
        public string Chiptype { get; set; }
        public int BakeTime { get; set; }
        public string CreatedCookie { get; set; }

        public abstract void CreateDough();
        public abstract void AddChocolateChips();
        public abstract void BakeInOven();

        public AbstractChocolateCookie CreateCookieTemplate()
        {
            CreateDough();
            AddChocolateChips();
            BakeInOven();

            CreatedCookie = Chiptype + " " + BaseType + " baked for " + BakeTime + " minutes";

            Console.WriteLine(CreatedCookie);

            return this;
        }
    }
}
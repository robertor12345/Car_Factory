using System;

namespace AbstractCookie
{
    public class ConcreteMilkChocolateCookie: AbstractChocolateCookie
    {

        public override void AddChocolateChips()
        {
            Chiptype = "Milk Chocolate Chips";
        }

        public override void BakeInOven()
        {
           BakeTime=15;

        }

        public override void CreateDough()
        {
            BaseType = "Plain Cookie Base";
        }
    }
}
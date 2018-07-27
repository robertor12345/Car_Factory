using System;

namespace AbstractCookie
{
    internal class ConcreteWhiteChocolateCookie : AbstractChocolateCookie
    {
        public override void AddChocolateChips()
        {
            Console.WriteLine("Add white chocolate chips to the dough and mix");
        }

        public override void BakeInOven()
        {
            Console.WriteLine("place on tray and bake in the oven for 15 mins at 120 degrees");
        }

        public override void CreateDough()
        {
            Console.WriteLine(
                "mix butter and sugar together in bowl, when fully and evenly mixed, pour in the flour and mix to a doughy elastic consistency");
        }
    }
}
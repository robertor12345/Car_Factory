using System;

namespace AdapterPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var expected = "gobble gobble";

            WildTurkey turkey = new WildTurkey();

            TurkeyAdapter turkeyAdapter = new TurkeyAdapter(turkey);

            TestDuck(turkeyAdapter);

            Console.WriteLine(turkeyAdapter.Quack());
        }

        private static void TestDuck(IDuck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}
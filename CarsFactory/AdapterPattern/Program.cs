using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
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

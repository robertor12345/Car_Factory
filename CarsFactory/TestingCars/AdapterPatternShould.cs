using AdapterPattern;
using FluentAssertions;
using NUnit.Framework;

namespace TestingPatterns
{
    [TestFixture]
    public class AdapterPatternShould
    {
        [Test]
        public void DuckShouldQuack()
        {
            var expected = "Quack";

            MallardDuck mallardDuck = new MallardDuck();

           var result= mallardDuck.Quack();

            result.Should().Be(expected);
        }

        [Test]
        public void DuckShouldFly()
        {
            var expected = "Weeeee";

            MallardDuck mallardDuck = new MallardDuck();

           var result= mallardDuck.Fly();

            result.Should().Be(expected);
        }


        [Test]
        public void TurkeyShouldGobble()
        {
            var expected = "gobble gobble";

            WildTurkey wildTurkey = new WildTurkey();

            var result = wildTurkey.Gobble();

            result.Should().Be(expected);
        }

        [Test]
        public void TurkeyShouldFly()
        {
            var expected = "flap flap";

            WildTurkey wildTurkey = new WildTurkey();

            var result = wildTurkey.Fly();

            result.Should().Be(expected);
        }


        [Test]
        public void TurkeyShouldPassAsDuck()
        {
            var expected = "gobble gobble";

            WildTurkey turkey = new WildTurkey();

            TurkeyAdapter turkeyAdapter = new TurkeyAdapter(turkey);

            testDuck(turkeyAdapter);

          var result=  turkeyAdapter.Quack();
     

            result.Should().Be(expected);
        }


        static void testDuck(IDuck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }

    public class TurkeyAdapter : IDuck
    {
        WildTurkey turkey;

       public TurkeyAdapter(WildTurkey turkey)
       {
           this.turkey = turkey;
       }

        public string Quack()
        {
           return turkey.Gobble();
        }

        public string Fly()
        {
           return turkey.Fly();
        }
    }
}
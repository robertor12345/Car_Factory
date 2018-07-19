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
            var expected = "Weeeee";

            WildTurkey wildTurkey = new WildTurkey();

            var result = wildTurkey.Fly();

            result.Should().Be(expected);
        }
    }
}
using DecoratorPattern;
using FluentAssertions;
using NUnit.Framework;

namespace TestingPatterns
{
    [TestFixture]
    class DecoratorShould
    {
        [Test]
        public void BeverageShouldHaveDescription()
        {
            var expected = "This is an Expresso";

            Expresso expresso = new Expresso();
            var result = expresso.GetDescription();

            result.Should().Be(expected);
        }

        [Test]
        public void BeverageShouldHaveCost()
        {
            var expected = 1.99;

            Expresso expresso = new Expresso();
            var result = expresso.Cost();

            result.Should().Be(expected);
        }

        [Test]
        public void CondimentsDescriptionShouldBeApplied()
        {
            var expected = "This is a HouseBlend with almond milk";

            Beverage houseBlend = new HouseBlend();
            houseBlend = new AlmondMilk(houseBlend);

            var result = houseBlend.GetDescription();

            result.Should().Be(expected);

        }
        [Test]
        public void CondimentsCostShouldBeApplied()
        {
            var expected = 3.2;

            Beverage houseBlend = new HouseBlend();
            houseBlend = new AlmondMilk(houseBlend);

            var result = houseBlend.Cost();

            result.Should().Be(expected);

        }


    }
}

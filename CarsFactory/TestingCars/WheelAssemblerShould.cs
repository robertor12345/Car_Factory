using CarsFactory;
using FluentAssertions;
using NUnit.Framework;

namespace TestingCars
{
    [TestFixture]
    public class WheelAssemblerShould
    {
        private Wheel testWheel;

        private Wheel Expectedwheel(int caseNumber)
        {
            switch (caseNumber)
            {
                case 1:
                    testWheel = new Wheel("default");
                    break;

                case 2:
                    testWheel = new Wheel("off road");
                    break;
            }

            return testWheel;
        }


        [TestCase("default", "steel rims")]
        [TestCase("off road", "steel rims")]
        public void WhenWheelAssemblerIsCalled_AndCarTypeIsPassedInReturnAppropriateWheeltype(string carType,
            string expected)
        {
            var wheelAssembler = new WheelAssembler(carType);
            var response = wheelAssembler.CreateComponent();
            var result = response.GetAttributes()[1];
            result.Should().Be(expected);
        }

        [TestCase("default", 1)]
        [TestCase("sports car", 2)]
        public void WhenWheelAssemblerIsCalled_AndCarTypeIsPassedInReturnAppropriateWheelAttributes(string carType,
            int caseNumber)
        {
            Expectedwheel(caseNumber);
            var wheelAssembler = new WheelAssembler(carType);
            var response = wheelAssembler.CreateComponent();
            var result = response.GetAttributes()[1];
            result.Should().Be(testWheel.GetAttributes()[1]);
        }

        [Test]
        public void WhenWheelAssemblerIsCalled_ReturnWheel()
        {
            var wheelAssembler = new WheelAssembler("off road");
            var expected = "steel rims";
            var response = wheelAssembler.CreateComponent();
            var result = response.GetAttributes()[1];

            result.Should().Be(expected);
        }
    }
}
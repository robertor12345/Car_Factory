using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace TestingCars
{
    [TestFixture]
    public class WheelAssemblerShould
    {
        private List<string> testList;

        private List<string> ExpectedLists(int caseNumber)
        {
            switch (caseNumber)
            {
                case 1:
                    testList = new List<string> {"steel rims", "offroad tyres"};
                    break;
                case 2:
                    testList = new List<string> {"rims", "high traction"};
                    break;
            }

            return testList;
        }


        [TestCase("off road", "steel rims")]
        [TestCase("sports car", "rims")]
        public void WhenWheelAssemblerIsCalled_AndCarTypeIsPassedInReturnAppropriateWheeltype(string carType,
            string expected)
        {
            var wheelAssembler = new WheelAssembler(carType);
            var response = wheelAssembler.Create();
            var result = response[0];
            result.Should().Be(expected);
        }

        [TestCase("off road", 1)]
        [TestCase("sports car", 2)]
        public void WhenWheelAssemblerIsCalled_AndCarTypeIsPassedInReturnAppropriateWheelAttributes(string carType,
            int caseNumber)
        {
            ExpectedLists(caseNumber);
            var wheelAssembler = new WheelAssembler(carType);
            var result = wheelAssembler.Create();
            result.Should().BeEquivalentTo(testList);
        }

        [Test]
        public void WhenWheelAssemblerIsCalled_ReturnWheel()
        {
            var wheelAssembler = new WheelAssembler();
            var expected = "rims";
            var response = wheelAssembler.Create();
            var result = response[0];

            result.Should().Be(expected);
        }
    }
}
using FluentAssertions;
using NUnit.Framework;
using TransportStrategy;
using TransportStrategy.TransportStrategies;

namespace TestingPatterns
{
    [TestFixture]
    internal class TransportStrategiesShould
    {
        private CarStrategy carStrategy;
        private PlaneStrategy planeStrategy;
        private TrainStrategy trainStrategy;

        [SetUp]
        public void Setup()
        {
            carStrategy = new CarStrategy();
            planeStrategy = new PlaneStrategy();
            trainStrategy = new TrainStrategy();
        }

        [TestCase]
        public void WhenCustomerIsCalledWithANewCarStrategyPassedInAsAParameter_ThenANewTimeEstimateIsReturned()
        {
            var expected = 3;
            Customer customer = new Customer(carStrategy);
            var result = customer.CalculateTime(180);

            result.Should().Be(expected);
        }

        [TestCase]
        public void WhenCustomerIsCalledWithANewPlaneStrategyPassedInAsAParameter_ThenANewTimeEstimateIsReturned()
        {
            var expected = 0;
            Customer customer = new Customer(planeStrategy);
            var result = customer.CalculateTime(180);

            result.Should().Be(expected);
        }

        [TestCase]
        public void WhenCustomerIsCalledWithANewTrainStrategyPassedInAsAParameter_ThenANewTimeEstimateIsReturned()
        {
            var expected = 1;
            Customer customer = new Customer(trainStrategy);
            var result = customer.CalculateTime(180);

            result.Should().Be(expected);
        }
    }
}
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

        [TestCase(3, 180)]
        [TestCase(4, 240)]
        [TestCase(5, 300)]
        public void WhenCustomerIsCalledWithANewCarStrategyPassedInAsAParameter_ThenANewTimeEstimateIsReturned(int expectedTime,
            int distance)
        {
            var expected = expectedTime;
            Customer customer = new Customer(carStrategy);
            var result = customer.CalculateTime(distance);

            result.Should().Be(expected);
        }

        [TestCase(2, 450)]
        [TestCase(0, 180)]
        [TestCase(1, 300)]
        public void WhenCustomerIsCalledWithANewPlaneStrategyPassedInAsAParameter_ThenANewTimeEstimateIsReturned(int expectedTime,
            int distance)
        {
            var expected = expectedTime;
            Customer customer = new Customer(planeStrategy);
            var result = customer.CalculateTime(distance);

            result.Should().Be(expected);
        }

        [TestCase(3, 450)]
        [TestCase(1, 180)]
        [TestCase(2, 300)]
        public void WhenCustomerIsCalledWithANewTrainStrategyPassedInAsAParameter_ThenANewTimeEstimateIsReturned(int expectedTime,
            int distance)
        {
            var expected = expectedTime;
            Customer customer = new Customer(trainStrategy);
            var result = customer.CalculateTime(distance);

            result.Should().Be(expected);
        }
    }
}
using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;
using VehichleFactory.compnentAssemblies;
using VehichleFactory.components;

namespace TestingPatterns
{
    [TestFixture]
    public class ComponentFactoryShould
    {
        [TestCase("car")]
        public void WhenComponentFactoryIsCalledWithVehicleTypeofCarParameter_ThenAListOfComponentObjectsIsReturned(
            string vehicleType)
        {
            var componentFactory = new ComponentFactory(vehicleType);
            var expected = DummyCarComponents();
            var result = componentFactory.CreateComponents();
            int i = 0;

            foreach (IComponent component in result)
            {
                component.Should().Be(result[i]);
                i++;
            }
        }

        [TestCase("plane")]
        public void WhenComponentFactoryIsCalledWithVehicleTypeofPlaneParameter_ThenAListOfComponentObjectsIsReturned(
            string vehicleType)
        {
            var componentFactory = new ComponentFactory(vehicleType);
            var expected = DummyPlaneComponents();
            var result = componentFactory.CreateComponents();

            int i = 0;
            foreach (IComponent component in result)
            {
                component.Should().Be(result[i]);
                i++;
            }
        }

        private List<IComponent> DummyCarComponents()
        {
            var componentFactory = new ComponentFactory("car");
            var dummyCarComponents = componentFactory.CreateComponents();
            return dummyCarComponents;
        }

        public List<IComponent> DummyPlaneComponents()
        {
            var componentFactory = new ComponentFactory("plane");
            var dummyPlaneComponents = componentFactory.CreateComponents();
            return dummyPlaneComponents;
        }
    }
}
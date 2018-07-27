using FluentAssertions;
using InterpreterPattern;
using NUnit.Framework;

namespace TestingPatterns

{
    [TestFixture]
    internal class CommandPatternShould
    {
        [Test]
        public void FlipDownCommandShouldSetLightStateToOn()
        {
            var expectedStatus = true;

            Light light = new Light();

            InterpreterPattern.ICommand commandA = new FlipUpCommand(light);

            LightSwitch lightSwitch = new LightSwitch();

            lightSwitch.SetAndExecuteCommand(commandA);

            light.State.Should().Be(expectedStatus);
        }

        [Test]
        public void FlipUpCommandShouldSetLightStateToOn()
        {
            var expectedStatus = false;

            Light light = new Light();

            InterpreterPattern.ICommand commandA = new FlipDownCommand(light);

            LightSwitch lightSwitch = new LightSwitch();

            lightSwitch.SetAndExecuteCommand(commandA);

            light.State.Should().Be(expectedStatus);
        }
    }
}
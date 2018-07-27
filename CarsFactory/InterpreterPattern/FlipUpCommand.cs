namespace InterpreterPattern
{
    public class FlipUpCommand : ICommand
    {
        public FlipUpCommand(Light light) : base(light)
        {
        }

        public override void Execute()
        {
            Light.TurnOn();
        }
    }
}
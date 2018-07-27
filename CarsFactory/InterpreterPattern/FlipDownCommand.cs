namespace InterpreterPattern
{
    public class FlipDownCommand : ICommand
    {
        public FlipDownCommand(Light light) : base(light)
        {
        }

        public override void Execute()
        {
            Light.TurnOff();
        }
    }
}
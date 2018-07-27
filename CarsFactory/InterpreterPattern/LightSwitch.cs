namespace InterpreterPattern
{
    public class LightSwitch
    {
        private ICommand Command;

        public void SetAndExecuteCommand(ICommand command)
        {
            Command = command;
            command.Execute();
        }
    }
}
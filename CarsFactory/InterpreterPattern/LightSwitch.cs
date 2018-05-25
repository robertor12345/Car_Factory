using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    class LightSwitch
    {

        private ICommand command;

        public void SetAndExecuteCommand(ICommand command)
        {
            this.command = command;
            command.Execute();
        }
    }
}

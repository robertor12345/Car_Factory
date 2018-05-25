using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    class FlipUpCommand : ICommand
    {
        public FlipUpCommand(Light light) :
            base(light)
        {
        }

        public override void Execute()
        {
            Light.TurnOff();
        }
    }
}

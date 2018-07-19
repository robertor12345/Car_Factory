using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
   public class FlipDownCommand : ICommand
    {
        public FlipDownCommand(Light light) :
            base(light)
        {
        }

        public override void Execute()
        {
            Light.TurnOff();
        }
    }
}


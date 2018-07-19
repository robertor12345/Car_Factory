using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
   public abstract class ICommand
    {
        protected Light Light;

        // Constructor

        public ICommand(Light light)
        {
            this.Light = light;
        }

        public abstract void Execute();
    }
}

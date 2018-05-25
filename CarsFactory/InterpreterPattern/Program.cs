using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterpreterPattern;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create light, command, and @lightSwitch

            Light light = new Light();
            ICommand commandA = new FlipUpCommand(light);
            ICommand commandB = new FlipDownCommand(light);
            LightSwitch lightSwitch = new LightSwitch();

            // Set and execute command

            lightSwitch.SetAndExecuteCommand(commandA);
        
            lightSwitch.SetAndExecuteCommand(commandB);
   

            // Wait for user

            Console.ReadKey();
        }
    }
}

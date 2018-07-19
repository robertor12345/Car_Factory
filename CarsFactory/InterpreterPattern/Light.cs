using System;
using System.Security.Cryptography.X509Certificates;

namespace InterpreterPattern
{
   public class Light
    {
        public bool State { get; private set; }

        public void TurnOn()
        {
            State = true;
            ShowState();
        }

        public void TurnOff()
        {
            State = false;
            ShowState();
        }

        public void ShowState()
        {
            var onOrOff = string.Empty;
            switch (State)
            {
                case true:
                    onOrOff = "on";
                    break;
                case false:
                    onOrOff = "off";
                    break;
            }
            Console.WriteLine("Light is switched " + onOrOff);
        }
    }
}
using System;

namespace StatePattern
{
    public class Human
    {
        public HumanState currentState;

        public Human()
        {
            currentState = new TiredState();
        }

        public void WakeUpHuman()
        {
            while (true)
            {
                Console.WriteLine(currentState.GetNextState());
            }
        }

    }
}
using System;

namespace StatePattern
{
    public class Human
    {
        public HumanState currentState;

        public Human()
        {
            currentState = new SleepingState();
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
namespace StatePattern
{
    public class TiredState : HumanState
    {
        public override string GetNextState()
        {
            UpdateState();

            return "Going to Sleep";
        }

        private void UpdateState()
        {
            Human.currentState = new SleepingState();
        }
    }
}
namespace StatePattern
{
    public class SleepingState : HumanState
    { 

        public override string GetNextState()
        {
            UpdateState();

            return "Dreaming";
        }

        private void UpdateState()
        {

            Human.currentState = new DreamingState();

        }
    }
}
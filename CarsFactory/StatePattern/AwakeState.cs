namespace StatePattern
{
    public class AwakeState : HumanState
    {
        public override string GetNextState()
        {
            UpdateState();
            return "Waking up";
        }

        private void UpdateState()
        {

            Human.currentState = new TrainingState();

        }
    }
}
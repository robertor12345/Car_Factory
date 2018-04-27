namespace StatePattern
{
    public class DreamingState : HumanState
    {
        public override string GetNextState()
        {
            UpdateState();

            return "Waking up";
        }

        private void UpdateState()
        {

            Human.currentState = new AwakeState();

        }
    }
}
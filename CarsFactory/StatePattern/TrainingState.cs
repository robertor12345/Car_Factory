namespace StatePattern
{
    public class TrainingState : HumanState
    {
        public override string GetNextState()
        {
            UpdateState();

            return "Hungry";
        }

        private void UpdateState()
        {

            Human.currentState = new HungryState();

        }
    }

    public class HungryState : HumanState
    {
        public override string GetNextState()
        {
            UpdateState();

            return "Eating";
        }

        private void UpdateState()
        {

            Human.currentState = new Eatingstate();

        }
    }

    public class Eatingstate : HumanState
    {
        public override string GetNextState()
        {
            UpdateState();

            return "Tired";
        }

        private void UpdateState()
        {

            Human.currentState = new TiredState();

        }
    }
}
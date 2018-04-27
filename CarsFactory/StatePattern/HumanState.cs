namespace StatePattern
{
    public abstract class HumanState
    {
        private Human human;

        public Human Human
        {
            get => human;
            set => human = value;
        }

        public abstract string GetNextState();

    }
}

   


namespace ADayAtTHeRaces
{
    class Bet
    {
        //Properties

        private int amount = 0;
        private int lane = 0;
        private Guy better;


        //Constructors, Getters and Setters

        public Bet()
        {
        }

        public Bet(Guy better)
        {
            this.better = better;
        }


        public Bet(Guy better, int amount, int lane)
        {
            this.amount = amount;
            this.lane = lane;
            this.better = better;
        }


        // Methods

        public string GetDescription()
        {
            if (amount > 0)
            {
                string description = string.Format("{2} bets ${0} on lane #{1}", amount, lane, better.Name);
                return description;
            }
            else
            {
                string description = string.Format("{0} hasn't placed a bet", better.Name);
                return description;
            }
        }

        public int PayOut(int Winner)
        {
             if (Winner == lane)
            {
                return amount;
            }
            else
            {
                return amount * -1;
            }
        }
    }
}

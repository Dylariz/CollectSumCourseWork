namespace CollectSum
{
    public class Player
    {
        public string Name { get; }
        public int RoundScore { get; private set; }
        public int TotalScore { get; private set; }
        public int RecivedNumber { get; private set; }
        public bool IsPassed { get; private set; }

        public Player(string name)
        {
            Name = name;
            Reset();
        }

        public void AddNumber(int number)
        {
            RecivedNumber = number;
            RoundScore += number;
        }

        public void NextRound(bool isLoser)
        {
            if (!isLoser)
            {
                TotalScore += RoundScore;
            }
            RoundScore = 0;
            IsPassed = false;
        }

        public void Pass()
        {
            IsPassed = true;
        }

        public void Reset()
        {
            RoundScore = 0;
            TotalScore = 0;
            RecivedNumber = 0;
            IsPassed = false;
        }
    }
}
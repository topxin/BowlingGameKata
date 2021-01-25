namespace BowlingGame
{
    public class Game
    {
        private int Score { get; set; }
        private int[] Rolls { get; set; } = new int[21];
        private int CurrentIndex { get; set; }

        public void Roll(int nbPins)
        {
            Rolls[CurrentIndex] = nbPins;
            CurrentIndex++;
        }

        public int CalculateScore()
        {
            for(int i=0; i<Rolls.Length; i++)
            {
                if (Rolls[i] == 10)
                {
                    Score += (10 + Rolls[i + 1] + Rolls[i + 2]);
                }
                else
                {
                    Score += Rolls[i];
                }
            }
            return Score>300?300:Score;
        }
    }
}

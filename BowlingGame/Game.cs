namespace BowlingGame
{
    public class Game
    {
        private int Score { get; set; }

        public void Roll(int nbPins)
        {
            Score += nbPins;
        }

        public int CalculateScore()
        {
            return Score;
        }
    }
}

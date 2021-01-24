namespace BowlingGame
{
    public class Game
    {
        private int Result { get; set; }

        public void Roll(int i)
        {
            Result += i;
        }

        public int Score()
        {
            return Result;
        }
    }
}

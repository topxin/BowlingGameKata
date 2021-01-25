namespace BowlingGame
{
    public class Game
    {
        private int Score { get; set; }
        private int[] Rolls { get; } = new int[21];
        private int CurrentIndex { get; set; }

        public void Roll(int nbPins)
        {
            Rolls[CurrentIndex] = nbPins;
            CurrentIndex++;
        }

        public int CalculateScore()
        {
            for(int i=0; i<Rolls.Length-1; i++)
            {
                if (IsStrikeRoll(i))
                {
                    Score += (10 + Rolls[i + 1] + Rolls[i + 2]);
                }   
                else if(IsSpareRoll(i))
                {
                    Score += (10 + Rolls[i + 2]);
                    i++;
                }
                else
                {
                    Score += Rolls[i];
                }
            }
            return Score>300?300:Score;
        }

        private bool IsSpareRoll(int indexRoll)
        {
            return Rolls[indexRoll] + Rolls[indexRoll + 1] == 10;
        }

        private bool IsStrikeRoll(int indexRoll)
        {
            return Rolls[indexRoll] == 10;
        }
    }
}

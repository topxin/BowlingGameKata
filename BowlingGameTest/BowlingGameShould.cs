using BowlingGame;
using NUnit.Framework;

namespace BowlingGameTest
{
    public class BowlingGameShould
    {
        [Test]
        public void Return_score()
        {
            var game = new Game();
            for (int i = 1; i <= 20; i++)
            {
                game.Roll(0);
            }
            Assert.AreEqual(0, game.Score());
        }
    }
}

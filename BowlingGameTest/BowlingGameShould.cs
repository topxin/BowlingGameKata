using BowlingGame;
using NUnit.Framework;
namespace BowlingGameTest
{
    [TestFixture]
    public class BowlingGameShould
    {
        [Test]
        public void Return_0_when_no_pins_striked_down()
        {
            Game game = new Game();
            RollForMany(20, 0, game);
            Assert.AreEqual(0, game.CalculateScore());
        }

        [Test]
        public void Return_20_when_all_one_pin_striked_down()
        {
            Game game = new Game();
            RollForMany(20, 1, game);
            Assert.AreEqual(20, game.CalculateScore());
        }

        [Test]
        public void Return_correct_score_with_one_strike()
        {
            Game game = new Game();
            game.Roll(10);
            game.Roll(1);
            game.Roll(1);
            RollForMany(16, 0, game);
            Assert.AreEqual(14, game.CalculateScore());
        }

        private void RollForMany(int nbRoll, int nbPinsPerRoll, Game game)
        {
            for (int i = 1; i <= nbRoll; i++)
            {
                game.Roll(nbPinsPerRoll);
            }
        }
    }
}

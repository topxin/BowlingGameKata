using BowlingGame;
using NUnit.Framework;

namespace BowlingGameTest
{
    public class BowlingGameShould
    {
        [Test]
        public void Return_0_when_no_pins_striked_down()
        {
            var game = new Game();
            for (int i = 1; i <= 20; i++)
            {
                game.Roll(0);
            }
            Assert.AreEqual(0, game.Score());
        }

        [Test]
        public void Return_20_when_all_one_pin_striked_down()
        {

        }
    }
}

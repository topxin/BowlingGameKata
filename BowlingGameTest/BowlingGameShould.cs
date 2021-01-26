using BowlingGame;
using NUnit.Framework;
namespace BowlingGameTest
{
    [TestFixture]
    public class BowlingGameShould
    {
        private Game _game;
        [SetUp]
        public void InitTest()
        {
            _game = new Game();
        }

        [Test]
        public void Return_0_when_no_pins_striked_down()
        {
            RollForMany(20, 0);
            Assert.AreEqual(0, _game.CalculateScore());
        }

        [Test]
        public void Return_20_when_all_one_pin_striked_down()
        {
            RollForMany(20, 1);
            Assert.AreEqual(20, _game.CalculateScore());
        }

        [Test]
        public void Return_correct_score_with_one_strike()
        {
            _game.Roll(10);
            _game.Roll(1);
            _game.Roll(1);
            RollForMany(16, 0);
            Assert.AreEqual(14, _game.CalculateScore());
        }

        [Test]
        public void Return_correct_score_with_two_strikes()
        {
            _game.Roll(3);
            _game.Roll(3);
            _game.Roll(10);
            _game.Roll(5);
            _game.Roll(2);
            _game.Roll(10);
            RollForMany(12, 0);
            Assert.AreEqual(40, _game.CalculateScore());
        }

        [Test]
        public void Return_300_with_12_strikes()
        {
            RollForMany(12, 10);
            Assert.AreEqual(300, _game.CalculateScore());

        }

        [Test]
        public void Return_correct_score_with_one_spare()
        {
            _game.Roll(5);
            _game.Roll(5);
            _game.Roll(1);
            _game.Roll(1);
            RollForMany(16, 0);
            Assert.AreEqual(13, _game.CalculateScore());
        }

        private void RollForMany(int nbRoll, int nbPinsPerRoll)
        {
            for (int i = 1; i <= nbRoll; i++)
            {
                _game.Roll(nbPinsPerRoll);
            }
        }
    }
}

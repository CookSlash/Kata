using Bowling;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingTest
{
    [TestFixture]
    public class BowlingGameTest
    {
        private BowlingGame aGame;
        [SetUp]
        public void Setup()
        {
            aGame = new BowlingGame();
        }
        [Test]
        public void BowlingGameShouldScore0WhenNoPinHaveBeenKnocked()
        {

            RollWithSameNumberOfKnockedPin(20, 0);
            Assert.That(aGame.Score(), Is.EqualTo(0));

        }

        [Test]
        public void BowlingGameShouldScore20When1PinHaveBeenKnockedAtEachRoll()
        {
            RollWithSameNumberOfKnockedPin(20,1);
            Assert.That(aGame.Score(), Is.EqualTo(20));

        }


        [Test]
        public void BowlingGameShouldAddBonusPointOnaSpare()
        {

            RollASpare();
            aGame.Roll(6);
            RollWithSameNumberOfKnockedPin(17, 0);
            Assert.That(aGame.Score, Is.EqualTo(22));

        }

        [Test]
        public void BowlingGameShouldAddBonusPointOnaStrike()
        {

            RollAStrike();
            aGame.Roll(8);
           
            RollWithSameNumberOfKnockedPin(17, 0);
            Assert.That(aGame.Score, Is.EqualTo(26));

        }

        private void RollAStrike()
        {
            aGame.Roll(10);
        }

        private void RollASpare()
        {
            aGame.Roll(9);
            aGame.Roll(1);
        }

        private void RollWithSameNumberOfKnockedPin(int rollNumber, int knockedPin)
        {
            for (int i = 0; i < rollNumber; i++)
            {
                aGame.Roll(knockedPin);
            }
        }

    }
}

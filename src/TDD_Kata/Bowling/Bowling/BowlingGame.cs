using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
    public class BowlingGame
    {
        
        private int[] rolls = new int[21];
        private int _currentRoll = 0;
        private static int FRAME_COUNT = 10;
        private static int PIN_COUNT = 10;

        public void Roll(int pin)
        {
            rolls[_currentRoll] = pin;
            _currentRoll++;


        }

        public int Score()
        {
            int score = 0;
            int rollIndex = 0;
            for (int i = 0; i < FRAME_COUNT; i++)
            {
                if (isStrike(rollIndex))
                {

                    score += ComputeScoreForAStrike( rollIndex);
                    rollIndex++;
                
                }
                else if (isSpare(rollIndex))
                {
                    score += ComputeScoreForASpare(rollIndex);
                    rollIndex += 2;
                }
                else
                {
                    score += ComputeScore(rollIndex);
                    rollIndex += 2;
                }
                
            }

            return score;
        }

        private Boolean isSpare(int rollIndex)
        {
            return rolls[rollIndex] + rolls[rollIndex + 1] == PIN_COUNT;
        }

        private Boolean isStrike(int rollIndex)
        {
            return rolls[rollIndex]  == PIN_COUNT;
        }

        private int ComputeScoreForAStrike(int rollIndex)
        {
            return PIN_COUNT + rolls[rollIndex + 1] + rolls[rollIndex + 2]; ;
        }

        private int ComputeScoreForASpare(int rollIndex)
        {
            return PIN_COUNT  + rolls[rollIndex + 2]; ;
        }

        private int ComputeScore(int rollIndex)
        {
            return rolls[rollIndex] + rolls[rollIndex + 1];
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
    public class BowlingGame
    {
        public int Score { get; set; }
        private int _lastRoll = 0;

        public void Roll(int pin)
        {
            if (_lastRoll + pin == 10)
            {
                Score += pin + 5;
            }
            else
            {
                Score += pin;
            }
            _lastRoll = pin;
            
        }
    }
}

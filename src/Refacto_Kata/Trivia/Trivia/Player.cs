using System;
using Trivia;

namespace Trivia_csharp.Init
{
    public class Player : IPlayer
    {
        private ITextDisplay _textDisplay;
       


        public Player(string playerName) : this(playerName, new TextDisplay(Console.Out))
        {
            Name = playerName;
        }

        public Player(string playerName, ITextDisplay textDisplay)
        {
            _textDisplay = textDisplay;
        }

        public string Name { get; set; }
        public int Location { get; set; }
        public int Purses { get; set; }
        public bool IsInPenaltyBox { get; set; }

        public bool IsGettingOutOfPenaltyBox
        {get; set; }

        public void GoToNewLocation(int roll)
        {
            Location = (Location + roll) % 12;
            _textDisplay.DisplayLocation(this);
        }

        
    }
}
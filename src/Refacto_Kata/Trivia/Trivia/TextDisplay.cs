using System;
using System.Collections.Generic;
using System.IO;

namespace Trivia
{
    class TextDisplay : ITextDisplay
    {
        private readonly TextWriter _outpuTextWriterwriter;

        public TextDisplay(TextWriter textWriter)
        {
            _outpuTextWriterwriter = textWriter;
        }

        public void DisplayCurrentPlayer(IPlayer currentPlayer)
        {
            _outpuTextWriterwriter.WriteLine($"{currentPlayer.Name} is the current player");
        }

        public void DisplayDiceRoll(int roll)
        {
            _outpuTextWriterwriter.WriteLine($"They have rolled a {roll}");
        }

        public void DisplayGetOutPenaltyBox(IPlayer player)
        {
            _outpuTextWriterwriter.WriteLine($"{player.Name} is getting out of the penalty box"); 
        }
        public void DisplayDontGetOutPenaltyBox(IPlayer player)
        {
            _outpuTextWriterwriter.WriteLine($"{player.Name} is getting out of the penalty box");
        }
       

        public void DisplayLocation(IPlayer player)
        {
            _outpuTextWriterwriter.WriteLine($"{player.Name}'s new location is {player.Location}");
        }

        public void DisplayPurse(IPlayer player)
        {
            _outpuTextWriterwriter.WriteLine($"{player.Name} now has {player.Purses} Gold Coins.");
        }

        public void DisplayCategory(CategoryEnum category)
        {
            _outpuTextWriterwriter.WriteLine($"The category is {category}");
        }

        public void DisplayCorrectAnswer()
        {
            _outpuTextWriterwriter.WriteLine("Answer was correct!!!!");
        }

        public void DisplayBadAnswer()
        {
            _outpuTextWriterwriter.WriteLine("Question was incorrectly answered");
        }

        public void DisplaySentToPenaltyBox(IPlayer player)
        {
            _outpuTextWriterwriter.WriteLine($"{player.Name} was sent to the penalty box");
        }

        public void DisplayAddedPlayer(IPlayer player)
        {
           _outpuTextWriterwriter.WriteLine($"{player.Name} was added");
        }


        public void DisplayPlayerNumber(IList<IPlayer> players)
        {
            _outpuTextWriterwriter.WriteLine($"They are player number {players.Count}");
        }

        public void DisplayQuestion(string askQuestion)
        {
            _outpuTextWriterwriter.WriteLine(askQuestion);
        }
    }
}
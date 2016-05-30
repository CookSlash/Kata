using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Trivia
{
    public interface ITextDisplay
    {
        void DisplayCurrentPlayer(IPlayer currentPlayer);
        void DisplayDiceRoll(int roll);
        void DisplayGetOutPenaltyBox(IPlayer player);
        void DisplayDontGetOutPenaltyBox(IPlayer player);
        void DisplayLocation(IPlayer player);
        void DisplayPurse(IPlayer player);
        void DisplayCategory(CategoryEnum category);
        void DisplayCorrectAnswer();
        void DisplayBadAnswer();
        void DisplaySentToPenaltyBox(IPlayer player);
        void DisplayAddedPlayer(IPlayer player);
        void DisplayPlayerNumber(IList<IPlayer> players);
        void DisplayQuestion(string askQuestion);
    }
}

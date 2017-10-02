using System;
using System.Collections.Generic;
using System.Linq;
using Trivia;

namespace Trivia_csharp.Init
{
    public class Game
    {

        private ITextDisplay _textDisplay;
        private readonly List<IPlayer> _players = new List<IPlayer>();

        private readonly IDictionary<CategoryEnum, Queue<string>> _questions = new Dictionary<CategoryEnum, Queue<string>>();

        
        private IPlayer _currentPlayer;

        public Game() : this(new TextDisplay(Console.Out))
        {
        }

        public Game(ITextDisplay textDisplay)
        {
            _textDisplay = textDisplay;
            CreateQuestions();
        }

        private void CreateQuestions()
        {
            var allQuestionCategories = Enum.GetValues(typeof(CategoryEnum)).Cast<CategoryEnum>().ToList();
            foreach (var category in allQuestionCategories)
            {
                _questions.Add(category, new Queue<string>(Enumerable.Range(0, 50).Select(i => category + " Question " + i)));
            }

            
        }

       

       
        public bool Add(String playerName)
        {

            var newPlayer = PlayerFactory.CreatePlayer(playerName);
            _players.Add(newPlayer);
            if (_currentPlayer == null)
            {
                _currentPlayer = newPlayer;
            }
            _textDisplay.DisplayAddedPlayer(newPlayer);
            _textDisplay.DisplayPlayerNumber(_players);
            
            
            return true;
        }

       
        public void Roll(int roll)
        {
            _textDisplay.DisplayCurrentPlayer(_currentPlayer);

            _textDisplay.DisplayDiceRoll(roll);

            if (_currentPlayer.IsInPenaltyBox)
            {
                _currentPlayer.IsGettingOutOfPenaltyBox = IsGettingOutOfPenaltyBox(roll);
                if (!_currentPlayer.IsGettingOutOfPenaltyBox)
                {
                    _textDisplay.DisplayDontGetOutPenaltyBox(_currentPlayer);
                    return;
                }
                _textDisplay.DisplayGetOutPenaltyBox(_currentPlayer);

            }

            _currentPlayer.GoToNewLocation(roll);
           
            _textDisplay.DisplayCategory(CurrentCategory);
            _textDisplay.DisplayQuestion(AskQuestion());
            


        }

        private static bool IsGettingOutOfPenaltyBox(int roll)
        {
            return roll%2 != 0;
        }


        private string AskQuestion()
        {
            return _questions[CurrentCategory].Dequeue();
        }


        private CategoryEnum CurrentCategory =>  (CategoryEnum)(_currentPlayer.Location % 4);
        

        public bool WasCorrectlyAnswered()
        {
            if (_currentPlayer.IsInPenaltyBox && !_currentPlayer.IsGettingOutOfPenaltyBox)
            {
                ChangePlayer();
                return true;
            }
            _textDisplay.DisplayCorrectAnswer();
            _currentPlayer.Purses++;
            _textDisplay.DisplayPurse(_currentPlayer);
            ChangePlayer();
            return DidPlayerWin();
        }

        private void ChangePlayer()
        {
            _currentPlayer = _players [(_players.IndexOf(_currentPlayer) + 1) % _players.Count];
        }

        public bool WrongAnswer()
        {
            _textDisplay.DisplayBadAnswer();
            _currentPlayer.IsInPenaltyBox = true;
            _textDisplay.DisplaySentToPenaltyBox(_currentPlayer);
            ChangePlayer();
            return true;
        }


        private bool DidPlayerWin()
        {
            return _currentPlayer.Purses != 6;
        }
    }
}

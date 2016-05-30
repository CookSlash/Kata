using Trivia;

namespace Trivia_csharp.Init
{
    public class Player : IPlayer
    {
        public Player(string playerName)
        {
            Name = playerName;
        }

        public string Name { get; set; }
        public int Location { get; set; }
        public int Purses { get; set; }
        public bool IsInPenaltyBox { get; set; }
        public bool IsGettingOutOfPenaltyBox { get; set; }

        public void GoToNewLocation(int roll)
        {
            Location = (Location + roll) % 12;
        }
    }
}
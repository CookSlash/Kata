using System;

namespace Trivia
{
    public interface IPlayer
    {
        String Name { get; set; }
        int Location { get; set; }
        int Purses { get; set; }
        bool IsInPenaltyBox { get; set; }
        bool IsGettingOutOfPenaltyBox { get; set; }
        void GoToNewLocation(int roll);
    }
}
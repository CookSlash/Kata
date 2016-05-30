using Trivia;

namespace Trivia_csharp.Init
{
    public class PlayerFactory
    {
        public static IPlayer CreatePlayer(string playerName)
        {
            return new Player(playerName);
        }
    }
}

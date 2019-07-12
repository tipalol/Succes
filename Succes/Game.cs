using System;
namespace Succes
{
    public class Game
    {
        public static Game game;
        public static Game GetGame()
        {
            if (game == null)
                game = new Game();
            return game;
        }
        public readonly string Mode;
        public static string GetMode(string mode) =>
            mode switch
            {
                "Easy" => "Easy",
                "Medium" => "Medium",
                "Hard" => "Hard",
                _ => "Medium"
            };
        public Game()
        {
        }
    }
}

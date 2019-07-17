using System;
using Succes.Data;
using Succes.Entities;

namespace Succes
{
    public class Game
    {
        public static Game game;
        public static Game GetGame(string mode)
        {
            if (game == null)
                game = new Game(mode);
            return game;
        }
        public static Settings Settings { get; set; }
        public Player Player { get; set; }
        public readonly string Mode;
        public static string GetMode(string mode) =>
            mode switch
            {
                "Easy" => "Easy",
                "Medium" => "Medium",
                "Hard" => "Hard",
                _ => "Medium"
            };
        public void NewGame()
        {

        }
        public Game(string mode)
        {
            Settings = new Settings();
            Settings.ReadSettings(mode);

        }
    }
}

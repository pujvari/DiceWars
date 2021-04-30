using System.Collections.Generic;
using System.Windows.Media;
using static DiceWars.Models.Player.Enums;

namespace DiceWars.Models
{
    public abstract class APlayer
    {
        public APlayer(int playerNumber, PlayerType playerType)
        {
            Number = playerNumber;
            Type = playerType;
            Tiles = new List<Tile>();
        }

        public int Number { get; set; }
        public PlayerType Type { get; set; }
        public Brush Color { get; set; }
        public List<Tile> Tiles { get; set; }

        public abstract void Play();
    }
}

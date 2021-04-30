using System.Collections.Generic;

namespace DiceWars.Models
{
    public class Board
    {
        public Board()
        {
            Tiles = new List<Tile>();
        }

        public List<Tile> Tiles { get; set; }
    }
}

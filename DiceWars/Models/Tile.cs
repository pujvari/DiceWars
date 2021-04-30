using System.Collections.Generic;
using static DiceWars.Models.Player.Enums;

namespace DiceWars.Models
{
    public class Tile
    {
        public Tile(int tileNumber)
        {
            Number = tileNumber;
            Dices = new List<Dice>();
        }

        public List<Dice> Dices { get; set; }

        public APlayer Owner { get; set; }

        public int Number { get; set; }

        public TileType Type { get; set; }

        public bool War(Tile defender)
        {
            int attackerValue = 0;
            Dices.ForEach(x => attackerValue += x.Roll());

            int defenderValue = 0;
            defender.Dices.ForEach(x => defenderValue += x.Roll());

            if (attackerValue > defenderValue)
                return true;

            return false;
        }

    }
}

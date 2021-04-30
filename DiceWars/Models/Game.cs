using System.Collections.Generic;
using System.Linq;

namespace DiceWars.Models
{
    public class Game
    {
        public Game()
        {
            Players = new List<APlayer>();
            Steps = new List<Step>();
        }

        public Board Board { get; set; }
        public List<APlayer> Players { get; set; }
        public List<Step> Steps { get; set; }

        public bool IsTheGameEnded()
        {
            int ownerNumber = Board.Tiles.First().Owner.Number;
            if (Board.Tiles.Any(x => x.Owner.Number != ownerNumber))
                return false;

            return true;
        }
        public bool IsHumanLost()
        {
            int humanNumber = Players.First().Number;
            if (Board.Tiles.Any(x => x.Owner.Number == humanNumber))
                return false;

            return true;
        }
    }
}

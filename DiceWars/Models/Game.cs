using DiceWars.Providers;
using System.Collections.Generic;
using System.Linq;

namespace DiceWars.Models
{
    public class Game : ABase
    {
        public Game(int rows, int cols, int numberOfPlayers) : base()
        {
            Steps = new List<Step>();
            Board = new Board(rows,cols);
        }

        private Board board;
        public Board Board
        {
            get
            {
                return board;
            }
            set
            {
                if (value != board)
                {
                    board = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public List<APlayer> Players
        {
            get
            {
                return PlayerProvider.GetAllPlayers();
            }
        }

        private List<Step> steps;
        public List<Step> Steps
        {
            get
            {
                return steps;
            }
            set
            {
                if (value != steps)
                {
                    steps = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private bool ended;
        public bool Ended
        {
            get
            {
                return ended;
            }
            set
            {
                if (value != ended)
                {
                    ended = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private bool lost;
        public bool Lost
        {
            get
            {
                return lost;
            }
            set
            {
                if (value != lost)
                {
                    lost = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public bool IsTheGameEnded()
        {
            int ownerNumber = TileProvider.Tiles.First().Owner.Number;

            if (TileProvider.Tiles.Any(x => x.Owner.Number != ownerNumber))
            {
                Ended = false;
                return false;
            }

            Ended = true;
            return true;
        }

        public bool IsHumanLost()
        {
            int humanNumber = Players.First().Number;
            if (TileProvider.Tiles.Any(x => x.Owner.Number == humanNumber))
            {
                Lost = false;
                return false;
            }

            Lost = true;
            return true;
        }
    }
}

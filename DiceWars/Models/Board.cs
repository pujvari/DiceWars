using DiceWars.Providers;
using System.Collections.Generic;
using System.Linq;

namespace DiceWars.Models
{
    public class Board : ABase
    {
        public Board(int rows, int columns) : base()
        {
            Rows = rows;
            Columns = columns;
            InitBoard();
        }

        private int rows;
        public int Rows
        {
            get
            {
                return rows;
            }
            set
            {
                if (value != rows)
                {
                    rows = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private int columns;
        public int Columns
        {
            get
            {
                return columns;
            }
            set
            {
                if (value != columns)
                {
                    columns = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public void InitBoard()
        {
            int numberOfTiles = Rows * Columns;

            TileProvider.CreateTiles(numberOfTiles);

            int numberOfPlayers = PlayerProvider.GetAllPlayers().Count;
            int tilePerPlayer = numberOfTiles / numberOfPlayers;

            SetTileOwner(numberOfTiles, numberOfPlayers, tilePerPlayer);

            DealDices(tilePerPlayer);
        }

        private void DealDices(int tilePerPlayer)
        {
            PlayerProvider.GetAllPlayers().ForEach(x => x.Tiles.ForEach(y => y.Dices.Add(new Dice())));

            foreach (var player in PlayerProvider.GetAllPlayers())
            {
                int dicePerPlayer = tilePerPlayer * 2;

                while (dicePerPlayer > 0)
                {
                    player.Tiles[RandomProvider.Next(0, player.Tiles.Count)].Dices.Add(new Dice());
                    dicePerPlayer--;
                }
            }
        }

        private void SetTileOwner(int numberOfTiles, int numberOfPlayers, int tilePerPlayer)
        {
            var list = CreateListForRandomizeTilesOwner(numberOfTiles);

            foreach (var owner in PlayerProvider.GetAllPlayers())
            {
                for (int i = 0; i < tilePerPlayer; i++)
                {
                    var tileNumber = list[RandomProvider.Next(0, numberOfTiles)];

                    TileProvider.Tiles.Find(x => x.Number == tileNumber).Owner = owner;
                    list.Remove(tileNumber);
                    numberOfTiles--;
                }
            }
        }

        private List<int> CreateListForRandomizeTilesOwner(int numberOfTiles)
        {
            var list = new List<int>();

            for (int i = 0; i < numberOfTiles; i++)
                list.Add(i);

            return list;
        }
    }
}

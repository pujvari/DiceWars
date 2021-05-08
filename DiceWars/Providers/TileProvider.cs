using DiceWars.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DiceWars.Providers
{
    static class TileProvider
    {
        static TileProvider()
        {
            tiles = new List<Tile>();
        }

        public static EventHandler IsSelectedChanged;

        private static List<Tile> tiles;
        public static List<Tile> Tiles
        {
            get
            {
                return tiles;
            }
        }
        public static List<Tile> SelectedTiles
        {
            get
            {
                return tiles.Where(x => x.IsSelected).OrderBy(x => x.SelectedDate).ToList();
            }
        }

        public static void CreateTiles(int numberOfTiles)
        {
            int index = 0;
            while (numberOfTiles > index)
            {
                tiles.Add(new Tile(index));

                index++;
            }
        }

        public static void SelectTile(Tile tile)
        {
            if (SelectedTiles.Count == 0 && 2 > tile.Dices.Count)
                return;

            if (SelectedTiles.Count == 1 && (SelectedTiles[0].Owner == tile.Owner || !SelectedTiles[0].NextTo(tile)))
                return;

            tile.IsSelected = true;
            tile.SelectedDate = DateTime.Now;

            if (SelectedTiles.Count == 2)
                SelectedTiles[0].War(SelectedTiles[1]);

            IsSelectedChanged.Invoke(null,null);
        }
    }
}

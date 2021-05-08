using DiceWars.Models;
using DiceWars.Providers;
using System;
using System.Windows.Media;

namespace DiceWars.UiElements
{
    public partial class TileUi : ABaseUi
    {
        public TileUi()
        {
            InitializeComponent();
            DataContext = this;
            TileProvider.IsSelectedChanged += TileSelectionChanged;
        }

        public Tile tile;
        public Tile Tile
        {
            get
            {
                return tile;
            }
            set
            {
                if (value != tile)
                {
                    tile = value;
                    NotifyPropertyChanged();
                    InitTile();
                }
            }
        }

        private void TileSelectionChanged(object sender, EventArgs e)
        {
            InitTile();
        }

        private void InitTile()
        {
            if (Tile.Type == Models.Player.Enums.TileType.UnPlayable)
            {
                button.Background = Brushes.Gray;
                button.Content = null;
                button.IsEnabled = false;
            }
            else
            {
                button.Background = Tile?.Owner?.Color;
                button.Content = Tile?.Dices?.Count;
                button.IsEnabled = true;
                button.Opacity = Tile.IsSelected ? 0.5 : 1.0;
            }
        }

        private void button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            TileProvider.SelectTile(tile);
            InitTile();
        }
    }
}

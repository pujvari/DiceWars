using DiceWars.Models;
using DiceWars.Providers;
using System;
using System.Windows.Controls;

namespace DiceWars.UiElements
{
    public partial class BoardUi : ABaseUi
    {
        public BoardUi()
        {
            InitializeComponent();
            DataContext = this;
        }

        public Board board;
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
                    RefreshBoard();
                }
            }
        }

        public void RefreshBoard()
        {
            StackPanel verticalStackPanel = new StackPanel() { Orientation = Orientation.Vertical };

            foreach (var tile in TileProvider.Tiles)
            {
                if (tile.Number % 10 == 0)
                {
                    horizontalStackPanel.Children.Add(verticalStackPanel);
                    verticalStackPanel = new StackPanel() { Orientation = Orientation.Vertical };
                }

                verticalStackPanel.Children.Add(new TileUi() { Tile = tile });
            }

            horizontalStackPanel.Children.Add(verticalStackPanel);
        }
    }
}

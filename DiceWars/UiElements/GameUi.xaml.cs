using DiceWars.Models;
using DiceWars.Providers;
using System;

namespace DiceWars.UiElements
{
    public partial class GameUi : ABaseUi
    {
        public GameUi()
        {
            InitializeComponent();
            DataContext = this;
            TileProvider.IsSelectedChanged += TileSelectionChanged;
        }

        private void TileSelectionChanged(object sender, EventArgs e)
        {
            RefreshGame();
        }

        public Game game;
        public Game Game
        {
            get
            {
                return game;
            }
            set
            {
                if (value != game)
                {
                    game = value;
                    NotifyPropertyChanged();
                    RefreshGame();
                }
            }
        }

        public void RefreshGame()
        {
            boardUi.board = Game.Board;
            boardUi.RefreshBoard();

            foreach (var player in Game.Players)
                playersStackPanel.Children.Add(new PlayerUi() { Player = player,Width = 200, Height=100 });
        }
    }
}

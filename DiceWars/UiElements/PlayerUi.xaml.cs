using DiceWars.Models;
using DiceWars.Providers;
using System;

namespace DiceWars.UiElements
{
    public partial class PlayerUi : ABaseUi
    {
        public PlayerUi()
        {
            InitializeComponent();
            DataContext = this;
            TileProvider.IsSelectedChanged += TileSelectionChanged;
        }

        private void TileSelectionChanged(object sender, EventArgs e)
        {
            RefreshPlayer();
        }

        public APlayer player;
        public APlayer Player
        {
            get
            {
                return player;
            }
            set
            {
                if (value != player)
                {
                    player = value;
                    NotifyPropertyChanged();
                    RefreshPlayer();
                }
            }
        }

        private void RefreshPlayer()
        {
                    NotifyPropertyChanged();
            //throw new NotImplementedException();
        }
    }
}

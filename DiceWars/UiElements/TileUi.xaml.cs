using DiceWars.Models;
using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Media;

namespace DiceWars.UiElements
{
    /// <summary>
    /// Interaction logic for TileUi.xaml
    /// </summary>
    public partial class TileUi : UserControl, INotifyPropertyChanged
    {
        public TileUi()
        {
            InitializeComponent();
        }

        public Tile Tile { get; set; }

        public Brush Color 
        {
            get
            {
                return Tile.Owner.Color;
            }
            set
            {
                Tile.Owner.Color = value;
                RaisePropertyChanged("TextInViewModel");
            }
        }
        public int CountOfDices
        {
            get
            {
                return Tile.Dices.Count;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}

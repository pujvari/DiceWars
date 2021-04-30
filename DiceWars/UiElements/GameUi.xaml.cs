using DiceWars.Models;
using System.Windows.Controls;

namespace DiceWars.UiElements
{
    /// <summary>
    /// Interaction logic for GameUi.xaml
    /// </summary>
    public partial class GameUi : UserControl
    {
        public GameUi()
        {
            InitializeComponent();
        }

        public Game Game { get; set; }
    }
}

using DiceWars.Models;
using System.Windows.Controls;

namespace DiceWars.UiElements
{
    /// <summary>
    /// Interaction logic for PlayerUi.xaml
    /// </summary>
    public partial class PlayerUi : UserControl
    {
        public PlayerUi()
        {
            InitializeComponent();
        }

        public APlayer Player { get; set; }
    }
}

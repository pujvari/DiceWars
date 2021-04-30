using DiceWars.Models;
using System.Windows.Controls;

namespace DiceWars.UiElements
{
    /// <summary>
    /// Interaction logic for BoardUi.xaml
    /// </summary>
    public partial class BoardUi : UserControl
    {
        public BoardUi()
        {
            InitializeComponent();
        }

        public Board Board { get; set; }
    }
}

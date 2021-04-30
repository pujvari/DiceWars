using DiceWars.Models;
using System.Collections.Generic;
using System.Windows.Controls;

namespace DiceWars.UiElements
{
    /// <summary>
    /// Interaction logic for StepsUi.xaml
    /// </summary>
    public partial class StepsUi : UserControl
    {
        public StepsUi()
        {
            InitializeComponent();
        }

        public List<Step> Steps { get; set; }
    }
}

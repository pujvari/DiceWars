using DiceWars.Models;
using System.Collections.Generic;

namespace DiceWars.UiElements
{
    public partial class StepsUi : ABaseUi
    {
        public StepsUi()
        {
            InitializeComponent();
            DataContext = this;
        }

        public List<Step> Steps { get; set; }
    }
}

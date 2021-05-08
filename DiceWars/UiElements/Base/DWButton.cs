using System.Windows;
using System.Windows.Controls;

namespace DiceWars.UiElements
{
    public class DWButton : Button
    {
        public DWButton()
        {
            HorizontalAlignment = HorizontalAlignment.Stretch;
            VerticalAlignment = VerticalAlignment.Stretch;

            HorizontalContentAlignment = HorizontalAlignment.Center;
            VerticalContentAlignment = VerticalAlignment.Center;
        }
    }
}

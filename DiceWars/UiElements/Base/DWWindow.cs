using System.Windows;

namespace DiceWars.UiElements
{
    public class DWWindow : Window
    {
        public DWWindow()
        {
            HorizontalAlignment = HorizontalAlignment.Stretch;
            VerticalAlignment = VerticalAlignment.Stretch;

            HorizontalContentAlignment = HorizontalAlignment.Stretch;
            VerticalContentAlignment = VerticalAlignment.Stretch;

            ResizeMode = ResizeMode.NoResize;
        }
    }
}

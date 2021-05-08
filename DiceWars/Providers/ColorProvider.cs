using System.Collections.Generic;
using System.Windows.Media;

namespace DiceWars.Providers
{
    static class ColorProvider
    {
        private static Dictionary<int, Brush> colors = new Dictionary<int, Brush>();

        static ColorProvider()
        {
            colors.Add(1, Brushes.Aqua);
            colors.Add(2, Brushes.Red);
            colors.Add(3, Brushes.Green);
            colors.Add(4, Brushes.Yellow);
            colors.Add(5, Brushes.Purple);
            colors.Add(6, Brushes.Orange);
            colors.Add(7, Brushes.Pink);
            colors.Add(8, Brushes.LightBlue);
            colors.Add(9, Brushes.AntiqueWhite);
            colors.Add(10, Brushes.OliveDrab);
        }
        public static Brush GetColor(int number)
        {
            return colors[number];
        }
    }
}

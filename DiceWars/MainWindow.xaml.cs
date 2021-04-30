using DiceWars.Models;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;

namespace DiceWars
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static int sanyi = 0;
        public MainWindow()
        {
            InitializeComponent();

            testTile.Tile = new Tile(1)
            {
                Owner = new Human(1) { Color = Brushes.AliceBlue},
                Dices = new List<Dice>() { new Dice()}
            };

            if (sanyi == 0)
            {
                sanyi++;
                MainWindow newWindow = new MainWindow();
                Application.Current.MainWindow = newWindow;
                newWindow.Show();
                this.Close();
            }
        }
    }
}

using DiceWars.Models;
using DiceWars.Providers;
using DiceWars.UiElements;
using System;

namespace DiceWars
{
	public partial class MainWindow : DWWindow
	{
		public MainWindow()
		{
			InitializeComponent();
			DataContext = this;

			//testBoard.Board = testBoardInit();
			testGame.Game = testGameInit();
		}

		private Game testGameInit()
		{
			int numberOfAiPlayers = GetNumberOfAiPlayers();
			int totalPlayers = numberOfAiPlayers + 1;

			PlayerProvider.GetHuman();

			int counter = 2;
			while (numberOfAiPlayers > counter - 2)
			{
				PlayerProvider.GetRandomAi(counter);
				counter++;
			}

			return new Game(10,10, totalPlayers);
		}

		private int GetNumberOfAiPlayers()
		{
			return 4;
		}
	}
}

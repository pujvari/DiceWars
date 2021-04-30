using static DiceWars.Models.Player.Enums;

namespace DiceWars.Models
{
    public class Human : APlayer
    {
        public Human(int playerNumber) : base(playerNumber, PlayerType.Human)
        {
        }

        public override void Play()
        {

        }
    }
}

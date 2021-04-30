using static DiceWars.Models.Player.Enums;

namespace DiceWars.Models
{
    public abstract class AAi : APlayer
    {
        public AAi(int playerNumber, AiType type) : base(playerNumber, PlayerType.Ai)
        {
            AiType = type;
        }

        public AiType AiType { get; set; }
    }
}

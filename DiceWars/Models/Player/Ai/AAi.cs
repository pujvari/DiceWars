using static DiceWars.Models.Player.Enums;

namespace DiceWars.Models
{
    public abstract class AAi : APlayer
    {
        public AAi(int playerNumber, AiType type) : base(playerNumber, PlayerType.Ai)
        {
            AiType = type;
        }

        private AiType aiType;
        public AiType AiType
        {
            get
            {
                return aiType;
            }
            set
            {
                if (value != aiType)
                {
                    aiType = value;
                    NotifyPropertyChanged();
                }
            }
        }
    }
}

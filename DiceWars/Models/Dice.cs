using DiceWars.Providers;

namespace DiceWars.Models
{
    public class Dice : ABase
    {
        public Dice() : base()
        {

        }

        public int Roll()
        {
            return RandomProvider.Next(1,6);
        }
    }
}

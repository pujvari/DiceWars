using DiceWars.Providers;

namespace DiceWars.Models
{
    public class Dice
    {
        public Dice()
        {

        }

        public int Roll()
        {
            return RandomProvider.Next(1,6);
        }
    }
}

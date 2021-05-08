namespace DiceWars.Models.Player
{
    public static class Enums
    {
        public enum PlayerType : int
        {
            Human = 1,
            Ai=2,
        };
        public enum AiType : int
        {
            Noob = 1,
            Normal = 2,
            Pro = 3,
        };

        public enum TileType : int
        {
            UnPlayable = 1,
            Playable = 2,
        };
    }
}

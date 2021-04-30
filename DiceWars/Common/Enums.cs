namespace DiceWars.Models.Player
{
    public static class Enums
    {
        public enum PlayerType : int
        {
            Human = 0,
            Ai=1,
        };
        public enum AiType : int
        {
            Noob = 0,
            Normal = 1,
            Pro = 1,
        };

        public enum TileType : int
        {
            UnPlayable = 0,
            Playable = 1,
        };
    }
}

using DiceWars.Models;
using System.Collections.Generic;
using System.Linq;
using static DiceWars.Models.Player.Enums;

namespace DiceWars.Providers
{
    static class PlayerProvider
    {
        private static List<AiType> aiTypes = new List<AiType>();
        private static Dictionary<int, APlayer> players = new Dictionary<int, APlayer>();

        static PlayerProvider()
        {
            aiTypes.Add(AiType.Noob);
            aiTypes.Add(AiType.Normal);
            aiTypes.Add(AiType.Pro);
        }

        public static List<APlayer> GetAllPlayers()
        {
            return players.Values.ToList();
        }

        public static APlayer GetHuman()
        {
            if (players.ContainsKey(1))
                return players[1];

            return CreateHuman();
        }

        public static APlayer GetRandomAi(int number)
        {
            if (players.ContainsKey(number))
                return players[number];

            return CreateAi(number, aiTypes[RandomProvider.Next(0,2)]);
        }

        public static APlayer GetAi(int number, AiType aiType = AiType.Normal)
        {
            if (players.ContainsKey(number))
                return players[number];

            return CreateAi(number, aiType);
        }

        public static AAi CreateAi(int number, AiType aiType = AiType.Normal)
        {
            switch (aiType)
            {
                case AiType.Noob:
                    return CreateNoobAi(number);
                case AiType.Normal:
                    return CreateNormalAi(number);
                case AiType.Pro:
                    return CreateProAi(number);
                default:
                    return CreateNormalAi(number);
            }
        }

        public static Human CreateHuman()
        {
            var human = new Human(1);

            players.Add(1, human);

            return human;
        }

        public static AAi CreateNoobAi(int number)
        {
            var ai = new NoobAi(number);

            players.Add(number, ai);

            return ai;
        }

        public static AAi CreateNormalAi(int number)
        {
            var ai = new NormalAi(number);

            players.Add(number, ai);

            return ai;
        }

        public static AAi CreateProAi(int number)
        {
            var ai = new ProAi(number);

            players.Add(number, ai);

            return ai;
        }
    }
}

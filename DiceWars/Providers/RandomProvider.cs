﻿using System;

namespace DiceWars.Providers
{
    static class RandomProvider
    {
        private static Random random = new Random();

        public static int Next(int min, int max)
        {
            return random.Next(min, max);
        }
    }
}

﻿using AdventOfCodeCubeConundrum.Models;

namespace AdventOfCodeCubeConundrum
{
    public class Calculator
    {
        public static int GetPossibleGamesSum(List<GameInfo> gameInfo)
        {
            var sum = 0;
            foreach (var game in gameInfo)
            {
                if(game.IsPosible)
                {
                    sum += game.GameId;
                }
            }
            return sum;
        }

        public static int GetPowerOfSets(List<GameInfo> gameInfo)
        {
            var sum = 0;
            foreach (var game in gameInfo)
            {
              sum += game.PowerSum;
            }
            return sum;
        }
    }
}

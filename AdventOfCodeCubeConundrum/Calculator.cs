using AdventOfCodeCubeConundrum.Models;

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
            Console.WriteLine(sum);
            Console.WriteLine(gameInfo.Where(gi=>gi.IsPosible).Select(gi=>gi.GameId).Sum());
            return sum;
        }
    }
}

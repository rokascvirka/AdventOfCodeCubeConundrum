using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCodeCubeConundrum.Models
{
    public class GameInfo
    {

        const int MAX_RED_SIZE = 12;
        const int MAX_GREEN_SIZE = 13;
        const int MAX_BLUE_SIZE = 14;
        public int GameId { get; set; } = 0;
        public List<Balls> FullData { get; set; }
        public bool IsPosible { get; set; } = false;

        public GameInfo()
        {
            
        }
        public GameInfo(int gameId, List<Balls> balls)
        {
            GameId = gameId;
            FullData = balls;
            IsPosible = IsGamePosible(balls);
        }

        private static bool IsGamePosible(List<Balls> balls)
        {
            foreach (Balls ball in balls)
            {

                if (ball.Red > MAX_RED_SIZE || ball.Blue > MAX_BLUE_SIZE || ball.Green > MAX_GREEN_SIZE)
                {
                    return false;
                }
            }
            return true;
        }

    }
}

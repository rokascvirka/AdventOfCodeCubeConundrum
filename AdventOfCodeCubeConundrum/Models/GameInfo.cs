using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCodeCubeConundrum.Models
{
    public class GameInfo
    {
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

                if (ball.Red > 12 || ball.Blue > 13 || ball.Green > 14)
                {
                    return false;
                }
            }
            return true;
        }

    }
}

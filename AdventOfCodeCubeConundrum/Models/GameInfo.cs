using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCodeCubeConundrum.Models
{
    public class GameInfo
    {

        public List<GameInfo> FullData { get; set; }
        public int GameId { get; set; }

        public bool IsPosible { get; set; }

        public GameInfo(int gameId, Balls balls)
        {
            GameId = gameId;
            IsPosible = IsGamePosible(balls);
        }

        private static bool IsGamePosible(Balls balls)
        {
            if(balls.Red <=12 && balls.Blue <= 13 && balls.Green <= 14)
            {
                return true;
            }
            return false;
        }
    }
}

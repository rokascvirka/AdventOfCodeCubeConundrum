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
        public int PowerSum { get; set; }

        public GameInfo()
        {
            
        }
        public GameInfo(int gameId, List<Balls> balls)
        {
            GameId = gameId;
            FullData = balls;
            IsPosible = IsGamePosible(balls);
            PowerSum = CountPower(balls);
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

        private static int CountPower(List<Balls> balls)
        {
            var result = 1;
            var ballsMaxValues = FindMaxValues(balls);
            if(ballsMaxValues.Red != 0)
            {
                result = ballsMaxValues.Red * result;
            }
            if (ballsMaxValues.Green != 0)
            {
                result = ballsMaxValues.Green * result;
            }
            if (ballsMaxValues.Blue != 0)
            {
                result = ballsMaxValues.Blue * result;
            }
            return result;
        }

        private static Balls FindMaxValues(List<Balls> balls)
        {
            var red_value = 0;
            var blue_value = 0;
            var green_value = 0;
            
            foreach (Balls ball in balls)
            {
                if(ball.Red > red_value)
                {
                    red_value = ball.Red;
                }
                if (ball.Blue > blue_value)
                {
                    blue_value = ball.Blue;
                }
                if(ball.Green > green_value)
                {
                    green_value = ball.Green;
                }
            }
            return new Balls(red:  red_value, blue: blue_value, green: green_value);
        }

    }
}

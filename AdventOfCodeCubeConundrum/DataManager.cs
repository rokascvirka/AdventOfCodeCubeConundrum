using AdventOfCodeCubeConundrum.Models;

namespace AdventOfCodeCubeConundrum
{
    public class DataManager
    {
        public static List<GameInfo> GetDataFromFile(string path)
        {
            var mappedData = new List<GameInfo>();
            var data = FileManager.ReadFile(path);

            foreach(var line in data)
            {
                var gameInfo = ProcessLine(line);
                mappedData.Add(gameInfo);
            }

            return mappedData;
        }


        private static GameInfo ProcessLine(string line)
        {
            if(line != "")
            {
                var splitLine = line.Split(":");
                var gameId = GetGameId(splitLine);
                var splitGames = splitLine[1].ToString().Split(";");
                var balls = SplitGameBalls(splitGames);
                var mapped = MapBalls(balls);

                return new GameInfo(gameId, mapped);
            }
            else
            {
                return new GameInfo();
            }
        }

        public static int GetGameId(string[] game)
        {
            if(game[0] != "")
            {
                var gameLine = game[0];
                var gameInfo = gameLine.Split(" ");
                return Convert.ToInt32(gameInfo[1]);
            }
            return 0;
        }

        public static List<string[]> SplitGameBalls(string[] splitGames)
        {
            var balls = new List<string[]>();
            foreach (var game in splitGames)
            {
                var gameInfo = game.ToString().Split(",");
                balls.Add(gameInfo);
            }
            return balls;
        }

        public static List<Balls> MapBalls(List<string[]> balls)
        {
            List<Balls> result = new List<Balls>();
            foreach (var game in balls)
            {
                var ballInfo = new Balls();

                foreach (var ball in game)
                {
                    if (ball.Contains("green"))
                    {
                        var info = ball.Trim().Split(" ");
                        ballInfo.Green = Convert.ToInt32(info[0]);
                    }
                    if (ball.Contains("red"))
                    {
                        var info = ball.Trim().Split(" ");
                        ballInfo.Red = Convert.ToInt32(info[0]);
                    }
                    if (ball.Contains("blue"))
                    {
                        var info = ball.Trim().Split(" ");
                        ballInfo.Blue = Convert.ToInt32(info[0]);
                    }
                }
                result.Add(ballInfo);
            }

            return result;
        }
    }
}

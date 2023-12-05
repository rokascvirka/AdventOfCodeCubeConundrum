using System.Reflection;

namespace AdventOfCodeCubeConundrum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var FILE_PATH = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? "", "Data.txt");
            var data = DataManager.GetDataFromFile(FILE_PATH);
            var sum = Calculator.GetPossibleGamesSum(data);
            Console.WriteLine(sum);
        }
    }
}
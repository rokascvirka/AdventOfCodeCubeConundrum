using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCodeCubeConundrum.Models
{
    public class Balls
    {
        public int Red { get; set; }
        public int Blue { get; set; }
        public int Green { get; set; }

        public Balls(int gameId, int red, int blue, int green)
        {
            Blue = blue;
            Red = red;
            Green = green;
        }
    }
}

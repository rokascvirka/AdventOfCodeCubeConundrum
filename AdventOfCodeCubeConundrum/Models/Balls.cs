using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCodeCubeConundrum.Models
{
    public class Balls
    {
        public int Red { get; set; } = 0;
        public int Blue { get; set; } = 0;
        public int Green { get; set; } = 0;

        public Balls()
        {
            
        }

        public Balls(int red, int blue, int green)
        {
            Blue = blue;
            Red = red;
            Green = green;
        }
    }
}

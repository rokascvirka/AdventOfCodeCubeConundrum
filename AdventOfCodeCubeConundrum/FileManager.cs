using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCodeCubeConundrum
{
    public class FileManager
    {
        public static string[] ReadFile(string path)
        {
            using(StreamReader sr = new StreamReader(path)) 
            {
               return sr.ReadToEnd().Split(Environment.NewLine);
            }
        }
    }
}

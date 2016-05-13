using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploringMars
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] terrain = new int[5, 5];
            Mars mars = new Mars(terrain);
            Robot robot1 = new Robot();
            Robot robot2 = new Robot();
        }
    }
}

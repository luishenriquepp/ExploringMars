using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploringMars
{
    public enum Cordenada
    {
        N = 0,
        E = 1,
        S = 2,
        W = 3
    }

    public class Robo
    {
        public Cordenada ahead { get; set; }

        public void TurnLeft()
        {
            if (ahead == Cordenada.N)
            {
                this.ahead = Cordenada.W;
            }
            else
            {
                this.ahead = ahead - 1;
            }
        }

        public void TurnRight()
        {
            if (ahead == Cordenada.W)
            {
                this.ahead = Cordenada.N;
            }
            else
            {
                this.ahead = ahead + 1;
            }
        }
    }
}

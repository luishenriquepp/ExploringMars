using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploringMars
{
    public enum Cordenada
    {
        North = 0,
        East = 1,
        South = 2,
        West = 3
    }

    public class Robot
    {
        public int positionX { get; set; }
        public int positionY { get; set; }

        public Cordenada ahead { get; set; }

        public Robot() { }

        public Robot(int positionX, int positionY, Cordenada ahead)
        {
            this.positionX = positionX;
            this.positionY = positionY;
            this.ahead = ahead;
        }

        public void move()
        {
            switch(ahead)
            {
                case Cordenada.North:
                    ++positionY;
                    break;
                case Cordenada.South:
                    --positionY;
                    break;
                case Cordenada.West:
                    --positionX;
                    break;
                case Cordenada.East:
                    ++positionX;
                    break;
            }
        }

        public void TurnLeft()
        {
            if (ahead == Cordenada.North)
            {
                ahead = Cordenada.West;
            }
            else
            {
                ahead = ahead - 1;
            }
        }

        public void TurnRight()
        {
            if (ahead == Cordenada.West)
            {
                ahead = Cordenada.North;
            }
            else
            {
                ahead = ahead + 1;
            }
        }
    }
}

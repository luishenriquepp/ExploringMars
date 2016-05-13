using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploringMars.Tests
{
    [TestClass]
    public class RobotMovingMethod
    {
        Robot robot = new Robot();

        [TestMethod]
        public void Pointed_North_Should_Move_North()
        {
            // new robot begins in the position 3,3 and pointed to the north
            robot.ahead = Cordenada.North;
            robot.positionX = 3;
            robot.positionY = 3;

            robot.move();

            Assert.AreEqual(robot.positionX, 3);
            Assert.AreEqual(robot.positionY, 4);
        }

        [TestMethod]
        public void Pointed_South_Should_Move_South()
        {
            // new robot begins in the position 3,3 and pointed to the south
            robot.ahead = Cordenada.South;
            robot.positionX = 3;
            robot.positionY = 3;
            
            robot.move();

            Assert.AreEqual(robot.positionX, 3);
            Assert.AreEqual(robot.positionY, 2);
        }

        [TestMethod]
        public void Pointed_West_Should_Move_West()
        {
            // new robot begins in the position 3,3 and pointed to the west
            robot.ahead = Cordenada.West;
            robot.positionX = 3;
            robot.positionY = 3;

            robot.move();

            Assert.AreEqual(robot.positionX, 2);
            Assert.AreEqual(robot.positionY, 3);
        }

        [TestMethod]
        public void Pointed_East_Should_Move_East()
        {
            // new robot begins in the position 3,3 and pointed to the east
            robot.ahead = Cordenada.East;
            robot.positionX = 3;
            robot.positionY = 3;

            robot.move();

            Assert.AreEqual(robot.positionX, 4);
            Assert.AreEqual(robot.positionY, 3);
        }
    }
}

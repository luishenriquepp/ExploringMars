using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExploringMars.Test
{
    [TestClass]
    public class RoboTurningMethods
    {
        Robot robo = new Robot();

        [TestMethod]
        public void TurnRight_Should_Return_East()
        {
            robo.ahead = Cordenada.North;
            robo.TurnRight();

            Assert.AreEqual(Cordenada.East, robo.ahead);
        }

        [TestMethod]
        public void TurnRight_Should_Return_Nort()
        {
            robo.ahead = Cordenada.West;
            robo.TurnRight();

            Assert.AreEqual(Cordenada.North, robo.ahead);
        }

        [TestMethod]
        public void TurnLeft_Should_Return_West()
        {
            robo.ahead = Cordenada.North;
            robo.TurnLeft();

            Assert.AreEqual(Cordenada.West, robo.ahead);
        }

        [TestMethod]
        public void TurnLeft_Should_Return_South()
        {
            robo.ahead = Cordenada.West;
            robo.TurnLeft();

            Assert.AreEqual(Cordenada.South, robo.ahead);
        }
    }
}

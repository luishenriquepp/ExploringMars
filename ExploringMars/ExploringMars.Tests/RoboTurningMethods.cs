using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExploringMars.Test
{
    [TestClass]
    public class RoboTurningMethods
    {
        Robo robo = new Robo();

        [TestMethod]
        public void TurnRight_Should_Return_East()
        {
            robo.ahead = Cordenada.N;
            robo.TurnRight();

            Assert.AreEqual(Cordenada.E, robo.ahead);
        }

        [TestMethod]
        public void TurnRight_Should_Return_Nort()
        {
            robo.ahead = Cordenada.W;
            robo.TurnRight();

            Assert.AreEqual(Cordenada.N, robo.ahead);
        }

        [TestMethod]
        public void TurnLeft_Should_Return_West()
        {
            robo.ahead = Cordenada.N;
            robo.TurnLeft();

            Assert.AreEqual(Cordenada.W, robo.ahead);
        }

        [TestMethod]
        public void TurnLeft_Should_Return_South()
        {
            robo.ahead = Cordenada.W;
            robo.TurnLeft();

            Assert.AreEqual(Cordenada.S, robo.ahead);
        }
    }
}

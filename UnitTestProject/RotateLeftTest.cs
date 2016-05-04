using CommonServices;
using CommonServicesImpl.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class RotateLeftTest
    {
        [TestMethod]
        public void East_RotateLeft_ExpectNorth()
        {
            Direction d = RotationUtil.RotateLeft(Direction.EAST);
            Assert.AreEqual(Direction.NORTH, d);
        }

        [TestMethod]
        public void North_RotateLeft_ExpectWest()
        {
            Direction d = RotationUtil.RotateLeft(Direction.NORTH);
            Assert.AreEqual(Direction.WEST, d);
        }

        [TestMethod]
        public void West_RotateLeft_ExpectSouth()
        {
            Direction d = RotationUtil.RotateLeft(Direction.WEST);
            Assert.AreEqual(Direction.SOUTH, d);
        }

        [TestMethod]
        public void South_RotateLeft_ExpectEast()
        {
            Direction d = RotationUtil.RotateLeft(Direction.SOUTH);
            Assert.AreEqual(Direction.EAST, d);
        }
    }
}

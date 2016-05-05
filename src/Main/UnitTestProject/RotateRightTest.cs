using CommonServices;
using CommonServicesImpl.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class RotateRightTest
    {
        [TestMethod]
        public void East_RotateRight_ExpectSouth()
        {
            Direction d = RotationUtil.RotateRight(Direction.EAST);
            Assert.AreEqual(Direction.SOUTH, d);
        }

        [TestMethod]
        public void North_RotateRight_ExpectEast()
        {
            Direction d = RotationUtil.RotateRight(Direction.NORTH);
            Assert.AreEqual(Direction.EAST, d);
        }

        [TestMethod]
        public void West_RotateRight_ExpectNorth()
        {
            Direction d = RotationUtil.RotateRight(Direction.WEST);
            Assert.AreEqual(Direction.NORTH, d);
        }

        [TestMethod]
        public void South_RotateRight_ExpectWest()
        {
            Direction d = RotationUtil.RotateRight(Direction.SOUTH);
            Assert.AreEqual(Direction.WEST, d);
        }
    }
}

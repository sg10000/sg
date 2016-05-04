using CommonServices;
using CommonServicesImpl.Command;
using CommonServicesImpl.Toy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class RightCommandTest
    {
        #region private
        private readonly int X_Position = 3;
        private readonly int Y_Position = 3;
        #endregion

        [TestMethod]
        public void North_NoPositionChange_ExpectFacingEast()
        {
            IToy toy = new Robot()
            {
                X = X_Position,
                Y = Y_Position,
                Facing = Direction.NORTH
            };
            ICommand c = new RightImpl();
            IPosition pos = c.Execute(toy);

            Assert.AreEqual(X_Position, pos.X);
            Assert.AreEqual(Y_Position, pos.Y);
            Assert.AreEqual(Direction.EAST, pos.Facing);
        }

        [TestMethod]
        public void West_NoPositionChange_ExpectFacingNorth()
        {
            IToy toy = new Robot()
            {
                X = X_Position,
                Y = Y_Position,
                Facing = Direction.WEST
            };
            ICommand c = new RightImpl();
            IPosition pos = c.Execute(toy);

            Assert.AreEqual(X_Position, pos.X);
            Assert.AreEqual(Y_Position, pos.Y);
            Assert.AreEqual(Direction.NORTH, pos.Facing);
        }

        [TestMethod]
        public void South_NoPositionChange_ExpectFacingWest()
        {
            IToy toy = new Robot()
            {
                X = X_Position,
                Y = Y_Position,
                Facing = Direction.SOUTH
            };
            ICommand c = new RightImpl();
            IPosition pos = c.Execute(toy);

            Assert.AreEqual(X_Position, pos.X);
            Assert.AreEqual(Y_Position, pos.Y);
            Assert.AreEqual(Direction.WEST, pos.Facing);
        }

        [TestMethod]
        public void East_NoPositionChange_ExpectFacingSouth()
        {
            IToy toy = new Robot()
            {
                X = X_Position,
                Y = Y_Position,
                Facing = Direction.EAST
            };
            ICommand c = new RightImpl();
            IPosition pos = c.Execute(toy);

            Assert.AreEqual(X_Position, pos.X);
            Assert.AreEqual(Y_Position, pos.Y);
            Assert.AreEqual(Direction.SOUTH, pos.Facing);
        }
    }
}

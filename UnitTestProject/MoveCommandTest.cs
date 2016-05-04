using CommonServices;
using CommonServicesImpl.Command;
using CommonServicesImpl.Toy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class MoveCommandTest
    {
        #region private
        private readonly int X_Position = 3;
        private readonly int Y_Position = 3;
        #endregion

        [TestMethod]
        public void North_ExpectMoveNorthByOne()
        {
            IToy toy = new Robot()
            {
                X = X_Position,
                Y = Y_Position,
                Facing = Direction.NORTH
            };
            ICommand c = new MoveImpl();
            IPosition pos = c.Execute(toy);

            Assert.AreEqual(X_Position, pos.X);
            Assert.AreEqual(Y_Position + 1, pos.Y);
            Assert.AreEqual(Direction.NORTH, pos.Facing);
        }

        [TestMethod]
        public void West_ExpectMoveWestByOne()
        {
            IToy toy = new Robot()
            {
                X = X_Position,
                Y = Y_Position,
                Facing = Direction.WEST
            };
            ICommand c = new MoveImpl();
            IPosition pos = c.Execute(toy);

            Assert.AreEqual(X_Position -1, pos.X);
            Assert.AreEqual(Y_Position, pos.Y);
            Assert.AreEqual(Direction.WEST, pos.Facing);
        }

        [TestMethod]
        public void South_ExpectMoveSouthByOne()
        {
            IToy toy = new Robot()
            {
                X = X_Position,
                Y = Y_Position,
                Facing = Direction.SOUTH
            };
            ICommand c = new MoveImpl();
            IPosition pos = c.Execute(toy);

            Assert.AreEqual(X_Position, pos.X);
            Assert.AreEqual(Y_Position - 1, pos.Y);
            Assert.AreEqual(Direction.SOUTH, pos.Facing);
        }

        [TestMethod]
        public void East_ExpectMoveEastByOne()
        {
            IToy toy = new Robot()
            {
                X = X_Position,
                Y = Y_Position,
                Facing = Direction.EAST
            };
            ICommand c = new MoveImpl();
            IPosition pos = c.Execute(toy);

            Assert.AreEqual(X_Position + 1, pos.X);
            Assert.AreEqual(Y_Position, pos.Y);
            Assert.AreEqual(Direction.EAST, pos.Facing);
        }
    }
}

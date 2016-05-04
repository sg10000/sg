using System;
using CommonServices;
using CommonServicesImpl.Command;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class CommandServiceTest
    {
        [TestMethod]
        public void UppercaseMoveStringCommandCaseSentitive_ExpectMoveImplCommand()
        {
            string cmd = "MOVE";
            Type t = typeof(MoveImpl);
            bool caseSensitive = true;
            ICommand c = CommandService.Execute(cmd, caseSensitive);
            Assert.AreEqual(t, c.GetType());
        }

        [TestMethod]
        public void UpperAndLowerCaseMoveStringCommandCaseInsentitive_ExpectMoveImplCommand()
        {
            string cmd = "MOvE";
            Type t = typeof(MoveImpl);
            bool caseSensitive = false;
            ICommand c = CommandService.Execute(cmd, caseSensitive);
            Assert.AreEqual(t, c.GetType());
        }

        [TestMethod]
        public void UpperAndLowerCaseMoveStringCommandCaseSentitive_ExpectInvalidCommandImplCommand()
        {
            string cmd = "MOvE";
            Type t = typeof(InvalidCommandImpl);
            bool caseSensitive = true;
            ICommand c = CommandService.Execute(cmd, caseSensitive);
            Assert.AreEqual(t, c.GetType());
        }
    }
}

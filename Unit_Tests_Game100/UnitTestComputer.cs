using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Game100Classes;

namespace Unit_Tests_Game100
{

    [TestClass]
    public class UnitTestComputer
    {

        [TestMethod]
        public void SetStep_Count0_9Returned()
        {
            Game game = new Game(true);
            Computer computer = new Computer();
            int expected = 9;
            computer.SetStep(game);
            int actual = computer.GetStep();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SetStep_Count9_10Returned()
        {
            Game game = new Game(true);
            Computer computer = new Computer();
            int expected = 10;
            game.CountUpdate(9);
            computer.SetStep(game);
            int actual = computer.GetStep();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SetStep_Count10_9Returned()
        {
            Game game = new Game(true);
            Computer computer = new Computer();
            int expected = 9;
            game.CountUpdate(10);
            computer.SetStep(game);
            int actual = computer.GetStep();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SetStep_Count5_4Returned()
        {
            Game game = new Game(true);
            Computer computer = new Computer();
            int expected = 4;
            game.CountUpdate(5);
            computer.SetStep(game);
            int actual = computer.GetStep();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SetStep_Count16_3Returned()
        {
            Game game = new Game(true);
            Computer computer = new Computer();
            int expected = 3;
            game.CountUpdate(16);
            computer.SetStep(game);
            int actual = computer.GetStep();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SetStep_Count50_9Returned()
        {
            Game game = new Game(true);
            Computer computer = new Computer();
            int expected = 9;
            game.CountUpdate(50);
            computer.SetStep(game);
            int actual = computer.GetStep();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SetStep_Count89_1Returned()
        {
            Game game = new Game(true);
            Computer computer = new Computer();
            int expected = 1;
            game.CountUpdate(89);
            computer.SetStep(game);
            int actual = computer.GetStep();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SetStep_Count91_9Returned()
        {
            Game game = new Game(true);
            Computer computer = new Computer();
            int expected = 9;
            game.CountUpdate(91);
            computer.SetStep(game);
            int actual = computer.GetStep();
            Assert.AreEqual(expected, actual);
        }

        [ExpectedException(typeof(Exception), "Общий счет не может быть отрицательным")]
        [TestMethod]
        public void SetStep_CountMin1_Exeption()
        {
            Game game = new Game(true);
            Computer computer = new Computer();
            game.CountUpdate(-1);
            computer.SetStep(game);
        }
    }
}

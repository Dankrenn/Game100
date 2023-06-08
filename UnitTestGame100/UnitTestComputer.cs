using Game100Classes;
using Game100Classes.ExceptionGame100.ExceptionComputer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestGame100
{
    [TestClass]
    public class UnitTestComputer
    {
        Mock<IGame> game;
        Computer computer;
        [TestInitialize]
        public void TestInitialize()
        {
            game = new Mock<IGame>();
            computer = new Computer(game.Object);
        }
        [TestMethod]
        public void GetStep_Count0_Return9()
        {
            int exception = 9;
            game.Setup(m => m.GetCount()).Returns(0);
            computer.SetStep();
            int actual = computer.GetStep();
            Assert.AreEqual(exception, actual);
        }

        [TestMethod]
        public void GetStep_Count9_Return10()
        {
            int exception = 10;
            game.Setup(m => m.GetCount()).Returns(9);
            computer.SetStep();
            int actual = computer.GetStep();
            Assert.AreEqual(exception, actual);
        }

        [TestMethod]
        public void GetStep_Count10_Return9()
        {
            int exception = 9;
            game.Setup(m => m.GetCount()).Returns(10);
            computer.SetStep();
            int actual = computer.GetStep();
            Assert.AreEqual(exception, actual);
        }

        [TestMethod]
        public void GetStep_Count5_Return4()
        {
            int exception = 4;
            game.Setup(m => m.GetCount()).Returns(5);
            computer.SetStep();
            int actual = computer.GetStep();
            Assert.AreEqual(exception, actual);
        }

        [TestMethod]
        public void GetStep_Count16_Return3()
        {
            int exception = 3;
            game.Setup(m => m.GetCount()).Returns(16);
            computer.SetStep();
            int actual = computer.GetStep();
            Assert.AreEqual(exception, actual);
        }

        [TestMethod]
        public void GetStep_Count50_Return9()
        {
            int exception = 9;
            game.Setup(m => m.GetCount()).Returns(50);
            computer.SetStep();
            int actual = computer.GetStep();
            Assert.AreEqual(exception, actual);
        }

        [TestMethod]
        public void GetStep_Count89_Return1()
        {
            int exception = 1;
            game.Setup(m => m.GetCount()).Returns(89);
            computer.SetStep();
            int actual = computer.GetStep();
            Assert.AreEqual(exception, actual);
        }

        [TestMethod]
        public void GetStep_Count91_Return9()
        {
            int exception = 9;
            game.Setup(m => m.GetCount()).Returns(91);
            computer.SetStep();
            int actual = computer.GetStep();
            Assert.AreEqual(exception, actual);
        }

        [ExpectedException(typeof(NegativeScoreException))]
        [TestMethod]
        public void GetStep_CountMin5_Exception()
        {
            game.Setup(m => m.GetCount()).Returns(-5);
            computer.SetStep();
        }

    }
}

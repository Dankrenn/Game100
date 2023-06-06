using Game100Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Unit_Tests_Game100
{
    [TestClass]
    public class UnitTestPlayer
    {
      
        [TestMethod]
        public void AddName_Daniil_TrueReturned()
        {
            ConcolePlayers player = new Player("Daniil");
            string expected = "Daniil";
            string actual = player.GetName();          
            Assert.AreEqual(expected, actual);
        }

        [ExpectedException(typeof(ArgumentNullException), "Строка не содержит значений")]
        [TestMethod]
        public void NameAdd_Null_Exception()
        {
            Player player = new Player("");           
        }

        [TestMethod]
        public void SetStep_5_5Returned()
        {
            Game game = new Game(true);
            Player player = new Player("Daniil");
            int expected = 5;
            player.SetStep(game);
            int actual =  player.GetStep(); 
            Assert.AreEqual(expected, actual, "входной параметр {0} ,результатом является {1}", 5, expected);
        }

        [ExpectedException(typeof(Exception), "Превышен диапозон значений")]
        [TestMethod]
        public void SetStep_11_Exception()
        {
            Game game = new Game(true);
            Player player = new Player("Daniil");
            player.SetStep(game);
        }
    }
}

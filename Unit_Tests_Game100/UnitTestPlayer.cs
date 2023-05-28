using Game100Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Unit_Tests_Game100
{
    [TestClass]
    public class UnitTestPlayer
    {
      
        [TestMethod]
        public void NameAdd_Daniil_TrueReturned()
        {
            Player player = new Player();
            string expected = "Daniil";
            string name = "Daniil";
            player.NameAdd(name);
            string actual = player.NameReturn();          
            Assert.AreEqual(expected, actual , "входной параметр {0} ,результатом является {1}", name , expected);
        }

        [ExpectedException(typeof(ArgumentNullException), "Строка не содержит значений")]
        [TestMethod]
        public void NameAdd_Null_Exception()
        {
            Player player = new Player();
            player.NameAdd(null);            
        }

        [TestMethod]
        public void ResultingValue_5_5Returned()
        {
            Game game = new Game();
            Player player = new Player();
            player.AdvancedValue(5);
            player.ResultingValue(game.CountReturn());
            int expected = 5;
            int actual = player.ResultingValueReturn();
            Assert.AreEqual(expected, actual, "входной параметр {0} ,результатом является {1}", 5, expected);
        }
    }
}

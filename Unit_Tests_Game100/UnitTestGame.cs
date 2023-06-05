using Game100Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Unit_Tests_Game100
{
    [TestClass]
    public class UnitTestGame
    {
        [ExpectedException(typeof(Exception), "Вы ввели одинаковые имена")]
        [TestMethod]
        public void CreatePlayer_DaniilandDaniil_Exception()
        {
            Game game = new Game(false);
            game.CreatePlayer("Daniil","Daniil");
        }

        [TestMethod]
        public void CreatePlayer_DaniilandBoris_TrueMetod()
        {
            Game game = new Game(false);
            game.CreatePlayer("Daniil", "Boris");
        }

        [ExpectedException(typeof(ArgumentNullException), "Строка не содержит значений")]
        [TestMethod]
        public void CreatePlayer_DaniilandEmply_Exception()
        {
            Game game = new Game(false);
            game.CreatePlayer("Daniil", "");
        }

        [ExpectedException(typeof(Exception), "Превышен диапозон значений")]
        [TestMethod]
        public void ValidationValue_50_Exceptoin()
        {
            Game game = new Game(false);
            game.ValidationValue(50);
        }

        [TestMethod]
        public void ValidationValue_5_TrueMetod()
        {
            Game game = new Game(false);
            game.ValidationValue(5);
        }
    }
}

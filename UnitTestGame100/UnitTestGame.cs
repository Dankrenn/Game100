using Game100Classes;
using Game100Classes.ExceptionGame100;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace UnitTestGame100
{
    [TestClass]
    public class UnitTestGame
    {
        Game game;
        Mock<IPlayer> player1;
        Mock<IPlayer> player2;

        [TestInitialize]
        public void TestInitialize()
        {
            game = new Game(false);
            player1 = new Mock<IPlayer>();
            player2 = new Mock<IPlayer>();
            player1.Setup(m => m.GetName()).Returns("Daniil");
            player2.Setup(m => m.GetName()).Returns("Boris");
            game.CreatePlayer(player1.Object, player2.Object);
        }

        [TestMethod]
        public void CreatePlayers_DaniilandBoris_Complite()
        {
            Assert.IsNotNull(game.player2.GetName());
        }
        [ExpectedException(typeof(SameUsernamesException))]
        [TestMethod]
        public void CreatePlayers_DaniilandDaniil_Exception()
        {
            player1.Setup(m => m.GetName()).Returns("Daniil");
            player2.Setup(m => m.GetName()).Returns("Daniil");
            game.CreatePlayer(player1.Object, player2.Object);
        }

        [ExpectedException(typeof(EmptyUsernameException))]
        [TestMethod]
        public void CreatePlayers_DaniilandEmpty_Exception()
        {
            player1.Setup(m => m.GetName()).Returns("Daniil");
            player2.Setup(m => m.GetName()).Returns("");
            game.CreatePlayer(player1.Object, player2.Object);
        }

        [ExpectedException(typeof(EmptyUsernameException))]
        [TestMethod]
        public void CreatePlayers_EmptyandDaniil_Exception()
        {
            player1.Setup(m => m.GetName()).Returns("");
            player2.Setup(m => m.GetName()).Returns("Daniil");
            game.CreatePlayer(player1.Object, player2.Object);
        }
        [ExpectedException(typeof(EmptyUsernameException))]
        [TestMethod]
        public void CreatePlayers_EmptyandEmpty_Exception()
        {
            player1 = new Mock<IPlayer>();
            player2 = new Mock<IPlayer>();
            player1.Setup(m => m.GetName()).Returns("");
            player2.Setup(m => m.GetName()).Returns("");
            game.CreatePlayer(player1.Object, player2.Object);
        }

        [ExpectedException(typeof(OutOfRangeException))]
        [TestMethod]
        public void SetStep_PlayerMove11_Exception()
        {
            player2.Setup(m => m.GetStep()).Returns(11);
            game.CountUpdate(player2.Object);
        }

        [ExpectedException(typeof(OutOfRangeException))]
        [TestMethod]
        public void SetStep_PlayerMoveMin1_Exception()
        {
            player2.Setup(m => m.GetStep()).Returns(-1);
            game.CountUpdate(player2.Object);
        }

        [TestMethod]
        public void SetStep_PlayerMove7_GetCount7()
        {
            int exception = 7;
            player2.Setup(m => m.GetStep()).Returns(7);
            game.CountUpdate(player2.Object);
            int actual = game.GetCount();
            Assert.AreEqual(actual, exception);
        }

        [ExpectedException(typeof(AnotherUsersMoveException))]
        [TestMethod]
        public void SetStep_Player1Move_Exception()
        {
            player1.Setup(m => m.GetStep()).Returns(7);
            game.CountUpdate(player1.Object);
        }
    }
}

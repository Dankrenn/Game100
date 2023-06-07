using Game100Classes.ExceptionGame100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game100Classes
{
    public class Game : IGame
    {
        private int _count;
        private bool _move_player1;
        private bool _gamebots;
        public IPlayer player1;
        public IPlayer player2;
        public Game(bool gamebots)
        {
                _gamebots = gamebots;
        }
    
        public bool GetGameBots() => _gamebots;

        public void CreatePlayer(IPlayer p1, IPlayer p2)
        {
            if (p1.GetName() == "" || p2.GetName() == "")
                throw new EmptyUsernameException();
            if (p1.GetName() == p2.GetName())
                throw new SameUsernamesException();
            player1 = p1;
            player2 = p2;
        }
        public void CreatePlayer(IPlayer name1)
        {   
            player1 = name1;
            player2 = new Computer(this);
        }

        public void MoveOrder()
        {
            int result = (new Random()).Next(0, 2);
            if (result == 0)
              _move_player1 = true;
            else
              _move_player1 = false;
        }

        public bool GetMovePlayer1() => _move_player1;
        private void SetMovePlayer1(bool move_player1) => _move_player1 = !move_player1;
        public void CountUpdate(IPlayer player)
        {
            int move;
            if (GetMovePlayer1())
            {
                if (player == player1)
                {
                    player1.SetStep();
                    move = player1.GetStep();
                }           
                else
                    throw new AnotherUsersMoveException();
            }
            else
            {
                if (player == player2)
                {
                    player2.SetStep();
                    move = player2.GetStep();
                }                   
                else
                    throw new AnotherUsersMoveException();
            }
            if (move < 1 || move > 10)
                throw new OutOfRangeException();
          _count += move;
          SetMovePlayer1(GetMovePlayer1());
        }

        public int GetCount() => _count;

        public  bool CountWins()
        {
            if (this._count == 100)
                return true;
            return false;
        }
    }
}

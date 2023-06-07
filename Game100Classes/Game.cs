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

        public void CreatePlayer(IPlayer name1, IPlayer name2)
        {
            if (name1 == name2)
                throw new Exception("Вы ввели одинаковые имена");
            player1 = name1;
            player2 = name2;
        }
        public void CreatePlayer(IPlayer name1)
        {   
            player1 = name1;
            player2 = new Computer();
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
        public void CountUpdate(int move)
        {
            if (move < 1 || move > 10)
                throw new Exception("Превышен диапозон значений");
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

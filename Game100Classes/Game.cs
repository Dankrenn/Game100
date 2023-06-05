using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game100Classes
{
    public class Game
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

        public void CreatePlayer(string name1, string name2)
        {
            if (name1 == name2)
                throw new Exception("Вы ввели одинаковые имена");
            player1 = new Player(name1);
            player2 = new Player(name2);
        }
        public void CreatePlayer(string name1)
        {         
            player1 = new Player(name1);
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
        public void SetMovePlayer1(bool move_player1) => _move_player1 = !move_player1;
        public void CountUpdate(int n) => _count+= n;
        public int GetCount() => _count;

        public  bool CountWins()
        {
            if (this._count == 100)
                return true;
            return false;
        }

        public void ValidationValue(int value)
        {
            if(value < 1 || value > 10)
                throw new Exception("Превышен диапозон значений");
        }
    }
}

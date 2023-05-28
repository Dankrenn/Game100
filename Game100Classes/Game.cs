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
        public Player player1 = new Player();
        public IPlayer _player;
        public Game()
        {

        }
        public void GameBots(string str)
        {
            if (str == "0")
            {
                _gamebots = true;
            }
            if(str == "1") 
            {
                _gamebots = false;
            }
            else
            {
                throw new Exception("Неверные входные параметры");
            }
        }
        public bool GameBotsReturn()
        {
            return _gamebots;
        }
        public  void CreatePlayer()
        {
            if (_gamebots == false)
            {
                _player = new Player();
            }
            else { _player = new Computer(); }
        }

        public void PlayersNameValid(Player player1)
        {
            string name1 = player1.NameReturn();
            string name2 = _player.NameReturn();
            if (name1 == name2)
            {
                throw new Exception("Ваши имена совпали");
            }
        }

        public void MoveOrder()
        {
            Random rand = new Random();
            int result = rand.Next(0, 2);
            if (result == 0)
            {
              _move_player1 = true;
            }
            else
            {
              _move_player1 = false;
            }
        }

        public bool MovePlayer1Return()
        {
            return _move_player1;
        }
        public void MovePlayer1Update(bool move_player1)
        {
            _move_player1 = move_player1;

        }

        public void CountUpdate(int n)
        {
            this._count += n;
        }

        public int CountReturn()
        {
            return this._count;
        }

        public  bool CountWins()
        {
            if (this._count >= 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ValidationValue(int value)
        {
            if(value < 1 || value > 10)
            {
                throw new Exception("Превышен диапозон значений");
            }
        }
    }
}

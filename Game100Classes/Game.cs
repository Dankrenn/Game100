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
        private int _chek;

        public Game()
        {

        }

        public void ChekApp()
        {
            this._chek++;
        }

        public int ChekReturn()
        {
            return this._chek;
        }

        public void CountUpdate(int n)
        {
            this._count += n;
        }

        public int CountReturn()
        {
            return this._count;
        }

        public  bool CountWins(int count)
        {
            if (count == 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public  int ValueConvert(string value)
        {
            int n = int.Parse(value);
            return n;
        }

        public bool ValidationValue(string value)
        {
            int n = ValueConvert(value);
            if (n >= 1 && n <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool MoveOrder()
        {
            Random rand = new Random();
            int result = rand.Next(0, 2);
            if(result == 0)
            {
                return true;
            }
            else return false;
        }
    }
}

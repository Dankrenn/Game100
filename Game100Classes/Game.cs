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
    }
}

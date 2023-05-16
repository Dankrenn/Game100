using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game100Classes
{
    public class Game
    {
        public int count;
        public int schet;
        public int chek;

        public Game()
        {

        }

        public Game(int count, int schet, int chek)
        {
            this.count = count;
            this.schet = schet;
            this.chek = chek;
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
        
        public  int CountN(int n, ref int count)
        {
            count += n;
            return count;
        }
    }
}

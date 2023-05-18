using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game100Classes
{
    public class Computer : Player
    {
        private int _move;
        public Computer()
        {

        }

        public void MoveUpdate(int move)
        {
            this._move = move;
        }

        public int MoveReturn()
        {
            return this._move;
        }

        public int SearchMove(int n, int chek, int count)
        {
            int m = 0;
            if (chek == 0)
            {
                if (n >= 1 && n <= 8)
                {
                    m = 10 - n - 1;
                }
                if (n == 9)
                {
                    m = 10;
                }
                if (n == 10)
                {
                    m = 9;
                }
            }
            else
            {
                if (count <= 79)
                {
                    if (n >= 1 && n <= 9)
                    {
                        m = 10 - n;
                    }
                    if (n == 10)
                    {
                        m = 10;
                    }
                }              
                if (count > 79 && count <= 89)
                {
                    if (n >= 1 && n <= 9)
                    {
                        m = 10 - n;
                    }
                    else
                    {
                        m = 1;
                    }
                }
                if (count > 89)
                {
                    if (n != 1)
                    {
                        m = 11 - n;
                    }
                    else
                    {
                        m = 10;
                    }
                }               
            }
            return m;
        }

    }
}

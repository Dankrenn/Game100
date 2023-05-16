using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game100Classes
{
    public class Computer : Player
    {
        public int m;
        public Computer()
        {

        }

        public Computer(int m)
        {
            this.m = m;
        }

        public int M(int n, int chek, int count)
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
            else if (chek > 0 && count < 79)
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
            else if (chek > 0 && count == 79)
            {
                if (n >= 1 && n <= 9)
                {
                    m = 10 - n;
                }
                if (n == 10)
                {
                    m = 1;
                }
            }
            else if (chek > 0 && count > 79 && count <= 89)
            {
                if (n >= 1 && n <= 9)
                {
                    m = 10 - n;
                }
                else
                {
                    m = 1;
                    // not
                }
            }
            else if (count > 89)
            {
                if (count - n != 90)
                {
                    if (n >= 1 && n <= 10)
                    {
                        m = 11 - n;
                    }
                    else
                    {
                        m = 1;
                        // not
                    }
                }
                else
                {
                    if (n >= 1 && n <= 10)
                    {
                        m = 10 - n;
                    }
                    else
                    {
                        m = 1;
                        // not
                    }
                }
            }
            return m;
        }

    }
}

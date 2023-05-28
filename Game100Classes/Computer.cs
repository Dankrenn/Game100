using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game100Classes
{
    public class Computer : IPlayer
    {
        private string _name = "PC";
        private int _resulting_value;

        public Computer()
        {

        }
        
        public void ResultingValue(int count)
        {
            if(count < 0)
            {
                throw new Exception("Общий счет не может быть отрицательным");
            }
            string str = Convert.ToString(count);
            char[] ch = str.ToCharArray();
            int[] a = new int[str.Length];
            string b = null;
            if (ch.Length == 2)
            {
                b = ch[1].ToString();
                a[1] = int.Parse(b);
            }
            int n;
            if (count == 0)
            {
                _resulting_value = 9;
                return;
            }
            if (count <= 10)
            {
                if (count >= 1 && count <= 8)
                {
                    _resulting_value = 10 - count - 1;
                }
                if (count == 9)
                {
                    _resulting_value = 10;
                }
                if (count == 10)
                {
                    _resulting_value = 9;
                }
                return;
            }
            else
            {
                n = a[1];
                if (count < 89)
                {
                    if(n > 0)
                    {
                        _resulting_value = 10 - n -1;
                    }
                    else
                    {
                        _resulting_value = 9;
                    }
                    return;
                }
                if (count >= 89)
                {
                   if(count == 89)
                    {
                        _resulting_value = 1;
                    }
                    else
                    {
                        _resulting_value = 100 - count;
                    }
                }
                return;
            }
        }
     
        public int ResultingValueReturn()
        {
            return this._resulting_value;
        }
        public void NameAdd(string name)
        {

        }
        public string NameReturn()
        {
            return _name;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game100Classes
{
    public class Computer : IPlayer
    {
        private const string _name = "PC";
        private int _step;

        public Computer()
        {

        }
        
        public void SetStep(Game game1)
        {
            int count = game1.GetCount();
            if(count < 0)
                throw new Exception("Общий счет не может быть отрицательным");

            char[] ch = Convert.ToString(count).ToCharArray();
            int[] a = new int[Convert.ToString(count).Length];
            for(int i  = 0; i < ch.Length; i++)
            {
                a[i] = int.Parse(ch[i].ToString());
            }
            int n;
            if (count == 0)
            {
                _step = 9;
                return;
            }
            if (count < 89)
            {
                if(count > 9)
                    n = a[1];
                else
                    n = a[0];
                if (n >= 1 && n <= 8)
                    _step = 10 - n - 1;
                if (n == 9)
                    _step = 10;
                if (n == 0)
                    _step = 9;
                return;
            }
            if (count == 89)
                _step = 1;
            if (count > 89)
                _step = 100 - count;
        }
     
        public int GetStep() => _step;
        public string GetName() => _name;
    }
}

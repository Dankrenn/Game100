using System;

namespace Game100Classes
{
    public class Computer : IPlayer
    {
        private const string _name = "PC";
        public Computer() { }
        
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
            int step = 0;
            if (count == 0)
            {
                step = 9;
            }
            int n;
            if (count < 89)
            {
                if(count > 9)
                    n = a[1];
                else
                    n = a[0];
                if (n >= 1 && n <= 8)
                    step = 10 - n - 1;
                if (n == 9)
                    step = 10;
                if (n == 0)
                    step = 9;
            }
            if (count == 89)
                step = 1;
            if (count > 89)
                step = 100 - count;

            game1.CountUpdate(step);
        }
        public string GetName() => _name;
    }
}

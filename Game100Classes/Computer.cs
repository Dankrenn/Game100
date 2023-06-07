using Game100Classes.ExceptionGame100.ExceptionComputer;
using System;

namespace Game100Classes
{
    public class Computer : IPlayer
    {
        private const string _name = "PC";
        private int _step;
        private IGame _game;
        public Computer(IGame game) { _game = game; }
        
        public void SetStep()
        {
            int count = _game.GetCount();
            if(count < 0)
                throw new NegativeScoreException();

            char[] ch = Convert.ToString(count).ToCharArray();
            int[] a = new int[Convert.ToString(count).Length];
            for(int i  = 0; i < ch.Length; i++)
            {
                a[i] = int.Parse(ch[i].ToString());
            }
            if (count == 0)
            {
                _step = 9;
            }
            int n;
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

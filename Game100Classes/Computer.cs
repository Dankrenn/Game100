using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game100Classes
{
    public class Computer : IPlayer
    {
        private int _advanced_value;//Полученаемое от игрока  значение ,которое он обрабатывает 
        private int _resulting_value;//Передаваемое  другому игроку значение которое он выбирает 

        public Computer()
        {

        }

        // метод для записи получаемого от сорерника значения
        public void AdvancedValue(int _advanced_value_playergame) 
        {
            this._advanced_value = _advanced_value_playergame;
        }

        // ПК Метод созданный для  записи  значения которое мы передадим другому игроку
        public  int  ResultingValue(int chek, int count)
        {
            int m = 0;
            int n = this._advanced_value;
            if (n == 0)
            {
                m = 9;
                return this._resulting_value = m;
            }
            if (chek == 1)
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
                return this._resulting_value = m;
            }
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
                return this._resulting_value = m;
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
                return this._resulting_value = m;
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
                return this._resulting_value = m;
            }
            else
            {
                m = 0;
                return this._resulting_value = m;
            }
        }

        public int ResultingValueReturn()
        {
            return this._resulting_value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game100Classes
{
    public class Player : IPlayer
    {
        private string _name;
        private int _advanced_value;//Полученаемое от игрока  значение ,которое он обрабатывает 
        private int _resulting_value;//Передаваемое  другому игроку значение которое он выбирает 
        public Player(string _name)
        {
            this._name = _name;
        }
        public Player()
        {
         
        }

        public void AdvancedValue(int _advanced_value_playergame) // метод для записи получаемого от сорерника значения
        {
            this._advanced_value = _advanced_value_playergame;
        }
      
        public void ResultingValue(int _resulting_value) // Метод созданный для записи  значения которое мы передадим другому игроку 
        {
           this._resulting_value = _resulting_value;             
        }
       
        public int ResultingValueReturn()
        {
            return this._resulting_value;
        }

        public void NameAdd(string name)
        {
            this._name = name;
        }
        public string NameReturn()
        {         
            return this._name;
        }
    }
}

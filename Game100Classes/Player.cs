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
        private int _advanced_value;
        private int _resulting_value;

        public Player()
        {
         
        }

        public void AdvancedValue(int _advanced_value_playergame) 
        {
            this._advanced_value = _advanced_value_playergame;
        }

        public void ResultingValue(int count)  
        {
           this._resulting_value = _advanced_value;             
        }
       
        public int ResultingValueReturn()
        {
            return this._resulting_value;
        }     
        public void NameAdd(string name)
        {
            if(name == null)
            {
                throw new ArgumentNullException("Введите свое имя");
            }        
             this._name = name;
        }
        public string NameReturn()
        {         
            return this._name;
        }
    }
}

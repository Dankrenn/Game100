using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game100Classes
{
    public class Player 
    {
        private string _name;
        private int _move;
        public Player() 
        {
        
        }       

        public  void NameUpdate(string name)
        {
            this._name = name;
        }

        public string NameReturn()
        {
           return this._name;
        }

        public void MoveUpdate(string value)
        {

            this._move = ValueConvert(value);
        }

        public int MoveReturn()
        {
           return this._move;
        }

        private  int ValueConvert(string value)
        {
            int n = int.Parse(value);
            return n;
        }

        public  bool Validation_value(string value)
        {
            int n =  ValueConvert(value);
            if (n >= 1 && n <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game100Classes
{
    public class Player : Game
    {
        public string name {get;set;}
        public string value  { get;set;}
        public int n { get; set; }
        public Player() 
        {
        
        }
        public Player(string name,string value)
        {
            this.name = name;
            this.value = value;
        }
        public  string Name(string name)
        {
            return name;
        }
        public  string Value(string value)
        {
            return value;
        }

        public  int ValueConvert(string value)
        {
            int n = int.Parse(value);
            return n;
        }
        public  bool Validation_value(int n)
        {
            
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

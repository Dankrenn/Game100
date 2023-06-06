using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game100Classes
{
    public abstract class Player : IPlayer
    {
        private string _name;

        public Player(string name)
        {
            if (name == null || name == "")
                throw new ArgumentNullException("Введите свое имя");
            this._name = name;
        }

        public abstract void SetStep(Game game);     
        public string GetName() => _name;
    }
}

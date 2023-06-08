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
        private int _step;
        private IGame _game;

        public Player(string name, IGame game)
        {
            if (name == null || name == "")
                throw new ArgumentNullException("Введите свое имя");
            this._name = name;
            _game = game;
        }

        public abstract void SetStep();
        public abstract int GetStep();
        public string GetName() => _name;
    }
}

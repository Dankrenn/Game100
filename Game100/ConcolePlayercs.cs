using Game100Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game100Concole
{
    public class ConcolePlayers : IPlayer
    {
        private string _name;
        private int _step;

        public ConcolePlayers(string name)
        {
            if (name == null || name == "")
            {
                throw new ArgumentNullException("Введите свое имя");
            }
            this._name = name;
        }

        public void SetStep(Game game)
        {
            Console.WriteLine($"Игрок {GetName()}, выберете любое число от 1 до 10");
            int step = int.Parse(Console.ReadLine());
            game.ValidationValue(step);
            this._step = step;
            game.CountUpdate(step);
            game.SetMovePlayer1(game.GetMovePlayer1());
        }

        public int GetStep() => _step;
        public string GetName() => _name;
    }
}

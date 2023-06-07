using Game100Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game100Concole
{
    public class ConcolePlayers : Player
    {
        public int _step;
        public ConcolePlayers(string name, IGame game) : base(name, game)
        {
        }

        public override void SetStep()
        {
            Console.WriteLine($"Игрок {GetName()}, выберете любое число от 1 до 10");
            _step = int.Parse(Console.ReadLine());       
        }
        public override int GetStep() => _step;
    }
}

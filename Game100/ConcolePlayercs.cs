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
        public ConcolePlayers(string name) : base(name)
        {
        }

        public override void SetStep(Game game)
        {
            Console.WriteLine($"Игрок {GetName()}, выберете любое число от 1 до 10");
            int step = int.Parse(Console.ReadLine());
            game.CountUpdate(step);            
        }
    }
}

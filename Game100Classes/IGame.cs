using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game100Classes
{
    public interface IGame
    {
        void CountUpdate(int move);
        void CreatePlayer(IPlayer name1, IPlayer name2);
        void CreatePlayer(IPlayer name1);
    }
}

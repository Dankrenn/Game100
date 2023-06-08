using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game100Classes
{
    public interface IGame
    {
        bool GetMovePlayer1();
        int GetCount();
        void CountUpdate();
    }
}

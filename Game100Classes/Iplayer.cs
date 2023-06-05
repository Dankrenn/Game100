using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game100Classes
{
    public interface IPlayer
    {
        string GetName();
        void SetStep(Game game1);
        int GetStep();
    }
}

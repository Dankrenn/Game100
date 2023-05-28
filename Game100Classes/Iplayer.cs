using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game100Classes
{
    public interface IPlayer
    {
        void NameAdd(string name);
        string NameReturn();
        void ResultingValue(int count);
        int ResultingValueReturn();
    }
}

using Game100Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Game100WinForms
{
    public class WinFormPlayer : Player
    {
        int _step;
        public WinFormPlayer(string name,Game game) : base(name,game) { }
        public new void SetStepWin(int move)
        {
            _step = move;
        }
        public override void SetStep()
        { 
            
        }
        public override int GetStep() => _step;
    }
}

using Game100Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Game100WinForms
{
    public class WinFormPlayer : Player
    {
        public WinFormPlayer(string name) : base(name) { }
        public override void SetStep(Game game) { }
    }
}

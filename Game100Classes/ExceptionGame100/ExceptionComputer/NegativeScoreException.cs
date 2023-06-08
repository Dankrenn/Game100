using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game100Classes.ExceptionGame100.ExceptionComputer
{
    public class NegativeScoreException : ExceptionGame100
    {
        public NegativeScoreException()
        {
            code = ExceptionCodes.NegativeScore;
        }
        //public override string comment => resourcemanager.GetString(code);
    }
}

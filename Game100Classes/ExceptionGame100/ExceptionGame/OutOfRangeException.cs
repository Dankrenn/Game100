using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game100Classes.ExceptionGame100
{
    public class OutOfRangeException : ExceptionGame100
    {
        public OutOfRangeException()
        {
            code = ExceptionCodes.OutOfRange;
        }
       // public override string comment => resourcemanager.GetString(code);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Game100Classes.ExceptionGame100
{
    public class SameUsernamesException : ExceptionGame100
    {
        public SameUsernamesException()
        {
            code = ExceptionCodes.SameUsernames;
        }

       // public override string comment => resourcemanager.GetString(code);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game100Classes.ExceptionGame100
{
    public class EmptyUsernameException : ExceptionGame100
    {
        public override string Code => ExceptionCodes.EmptyUsername;
    }
}

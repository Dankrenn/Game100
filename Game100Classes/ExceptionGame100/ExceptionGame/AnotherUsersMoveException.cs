using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game100Classes.ExceptionGame100
{
    public class AnotherUsersMoveException : ExceptionGame100
    {
        public override string Code => ExceptionCodes.AnotherUsersMove;
    }
}

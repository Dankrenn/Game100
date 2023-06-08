using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Game100Classes.ExceptionGame100
{
    public class AnotherUsersMoveException : ExceptionGame100
    {
        public AnotherUsersMoveException()
        {
           code = ExceptionCodes.AnotherUsersMove;
        }

        //public override string comment => resourcemanager.GetString(code);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game100Classes.ExceptionGame100
{
    public abstract class ExceptionGame100 : Exception
    {
        public abstract string Code { get; }
    }
}

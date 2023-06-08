using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using System.Reflection;
using System.Threading;

namespace Game100Classes.ExceptionGame100
{
    public abstract class ExceptionGame100 : Exception
    {
        //public static ResourceManager resourcemanager = new ResourceManager("Game100.ExceptionGame100.ResourceCodeException", typeof(ExceptionCodes).Assembly);
        public string code;
        //public abstract string comment { get; }
    }
}

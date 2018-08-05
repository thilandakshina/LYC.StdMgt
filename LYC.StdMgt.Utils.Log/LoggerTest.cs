using LYC.StdMgt.Utils.Log.Contracts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LYC.StdMgt.Utils.Log
{
    public class LoggerTest : ILogger
    {
        public bool LogError(string err)
        {
        
            Trace.Write("Test Log " + err);
            return true;
        }
    }
}

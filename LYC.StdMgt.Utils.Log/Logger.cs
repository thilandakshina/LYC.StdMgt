using LYC.StdMgt.Utils.Log.Contracts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LYC.StdMgt.Utils.Log
{
    public class Logger : ILogger
    {
        public bool LogError(string err)
        {
            //throw new NotImplementedException();
           // Console.WriteLine(err);
            Trace.Write(err);
            return true;
        }
    }
}

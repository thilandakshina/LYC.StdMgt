using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LYC.StdMgt.Utils.Log.Contracts
{
    public interface ILogger
    {
        bool LogError(string err);
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoKuai_EntSDK.UtilClass
{
    class LogPrint
    {
        private const string PRO_NAME = "GoKuai_EntSDK";

        public static void Print(string log)
        {
            Debug.WriteLine(PRO_NAME+"GoKuai_EntSDK==>"+log);
        }
        
    }
}

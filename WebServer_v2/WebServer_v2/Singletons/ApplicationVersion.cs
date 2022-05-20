using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServer_v2
{
    public sealed class ApplicationVersion
    {
        private ApplicationVersion() { }
        private static ApplicationVersion _instance;
        public static ApplicationVersion GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ApplicationVersion();
            }
            return _instance;
        }
        public static bool IsTestVersion()
        {
            return false;

            //return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportCenter
{
    public static class clsGlobal
    {
        // Connection String
        static string gstrConnectionString = "";
        public static string ConnectionString
        {
            get
            {
                return strConnectionString;
            }
            set
            {
                strConnectionString = value;
            }
        }


        // Developer Code
        static string gstrDeveloperCode = "";
        public static string DeveloperCode
        {
            get
            {
                return gstrDeveloperCode;
            }
            set
            {
                gstrDeveloperCode = value;
            }
        }
    }
}

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
                return gstrConnectionString;
            }
            set
            {
                gstrConnectionString = value;
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


        // UserName
        static string gstrUserName = "";
        public static string UserName
        {
            get
            {
                return gstrUserName;
            }
            set
            {
                gstrUserName = value;
            }
        }


        //Email
    }
}

using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportCenter
{
    class clsConnection
    {
        // Module constants
        private const int mc_intDefaultConnectionTimeout = 15;
        private const int mc_intDefaultCommandTimeout = 30;
        private const int mc_intNumberOfProperties = 12;
        private const string mc_strDelimiter = "<$¿$>";

        private const string mc_strApplicationNameTag = "ApplicationName=";
        private const string mc_strWorkstationIDTag = "WorkstationID=";
        private const string mc_strDBMSTag = "DBMS=";
        private const string mc_strServerTag = "Server=";
        private const string mc_strLocationTag = "Location=";
        private const string mc_strLoginIDTag = "LoginID=";
        private const string mc_strLoginPasswordTag = "LoginPassword=";
        private const string mc_strParametersTag = "Parameters=";
        private const string mc_strConnectionStringTag = "ConnectionString=";
        private const string mc_strConnectionTimeoutTag = "ConnectionTimeout=";
        private const string mc_strCommandTimeoutTag = "CommandTimeout=";
        private const string mc_strAutoConnectTag = "AutoConnect=";

        private const int mc_intApplicationNameTagLength = 16;
        private const int mc_intWorkstationIDTagLength = 14;
        private const int mc_intDBMSTagLength = 5;
        private const int mc_intServerTagLength = 7;
        private const int mc_intLocationTagLength = 9;
        private const int mc_intLoginIDTagLength = 8;
        private const int mc_intLoginPasswordTagLength = 14;
        private const int mc_intParametersTagLength = 11;
        private const int mc_intConnectionStringTagLength = 17;
        private const int mc_intConnectionTimeoutTagLength = 18;
        private const int mc_intCommandTimeoutTagLength = 15;
        private const int mc_intAutoConnectTagLength = 12;

        // Enumerated errors
        public enum ConnectionError
        {
            jmaConnectionErrorBase = 14098,
            jmaInvalidConnectionParameterValue = jmaConnectionErrorBase + 1,
            jmaUnsupportedDatabase = jmaConnectionErrorBase + 2,
            jmaInvalidFileFormat = jmaConnectionErrorBase + 3
        }

        //public enum ConnectionsError{
        //    jmaBaseConnectionsError = vbObjectError + 8992,
        //    jmaInvalidConnectionsParameterValue = jmaBaseConnectionsError + 1
        //}

        // Module variables
        private string mstrApplicationName;
        private string mstrWorkstationID;
        private string mstrDBMS;
        private string mstrServer;
        private string mstrLocation;
        private string mstrLoginID;
        private string mstrLoginPassword;
        private string mstrParameters;
        private string mstrConnectionString;
        private int mintConnectionTimeout;
        private int mintCommandTimeout;
        private bool mblnAutoConnect;

        private SqlConnection mcxnDatabase;

        public string ApplicationName
        {
            get
            {
                return mstrApplicationName;
            }
            set
            {
                mstrApplicationName = value;
            }
        }

        // ID of the workstation that requested the information.
        public string WorkstationID
        {
            get
            {
                return mstrWorkstationID;
            }
            set
            {
                mstrWorkstationID = value;
            }
        }

        // Database management system being connected to (SQL, Access, etc.).
        public string DBMS
        {
            get
            {
                return mstrDBMS;
            }
            set
            {
                mstrDBMS = value;
            }
        }

        // Name of the server.
        public string Server
        {
            get
            {
                return mstrServer;
            }
            set
            {
                mstrServer = value;
            }
        }

        // The actual database on the server of the file's path for a *.mdb.
        public string Location
        {
            get
            {
                return mstrLocation;
            }
            set
            {
                mstrLocation = value;
            }
        }

        // Login ID needed to log into the database.
        public string LoginID
        {
            get
            {
                return mstrLoginID;
            }
            set
            {
                mstrLoginID = value;
            }
        }

        // Decrypted password needed to log into the database.
        public string LoginPassword
        {
            get
            {
                return mstrLoginPassword;
            }
            set
            {
                mstrLoginPassword = value;
            }
        }

        // Any additional parameters required for the connection.
        public string Parameters
        {
            get
            {
                return mstrParameters;
            }
            set
            {
                mstrParameters = value;
            }
        }

        // Complete ADO connection string.
        public string ConnectionString
        {
            get
            {
                return mstrConnectionString;
            }
            set
            {
                mstrConnectionString = value;
            }
        }

        // Number of seconds to wait for a successful connection.
        public int ConnectionTimeout
        {
            get
            {
                return mintConnectionTimeout;
            }
            set
            {
                mintConnectionTimeout = value;
            }
        }

        // Number of seconds to wait for a successful command.
        public int CommandTimeout
        {
            get
            {
                return mintCommandTimeout;
            }
            set
            {
                mintCommandTimeout = value;
            }
        }

        // Determines whether the connection should automatically connect when accessed.
        public bool AutoConnect
        {
            get
            {
                return mblnAutoConnect;
            }
            set
            {
                mblnAutoConnect = value;
            }
        }

        // Exposes the SQLConnection object.
        public SqlConnection Connection
        {
            get
            {   // if the connection is not open, this attempts to open it.
                if ((mcxnDatabase.State != System.Data.ConnectionState.Open) && mblnAutoConnect)
                {
                    Connect();
                }
                return mcxnDatabase;
            }
        }

        public bool Connect()
        {
            //need to set timeouts in connection string. properties are read only
            #region
            // Use the default command timeout if the specified timeout is 0.
            //if (mlngConnectionTimeout == 0) {
            //    mcxnDatabase.ConnectionTimeout = mlngConnectionTimeout;
            //}

            // Use the default command timeout if the specified timeout is 0.
            //if (mlngCommandTimeout == 0) {
            //    mcxnDatabase.CommandTimeout = mc_lngDefaultCommandTimeout;
            //}
            //else {
            //    mcxnDatabase.CommandTimeout = mlngCommandTimeout;
            //}
            #endregion

            // Create the connection string using property values if a connection string
            // is not already specified.
            if (mstrConnectionString == null)
            {
                mstrConnectionString = CreateADOConnectionString();
            }

            mcxnDatabase.ConnectionString = mstrConnectionString;
            mcxnDatabase.Open();

            // Check if the connection was successfully closed and set the return value.
            if (mcxnDatabase.State == System.Data.ConnectionState.Open)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string CreateADOConnectionString()
        {
            return "";
        }
    }
}
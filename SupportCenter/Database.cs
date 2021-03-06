﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportCenter
{
    public static class Database
    {
        //properties

        //methods
        /// <summary>
        /// Run query and return result DataTable
        /// </summary>
        /// <param name="pstrSQL">sql query to be run</param>
        /// <returns></returns>
        public static DataTable Query(string pstrSQL)
        {
            DataTable dt = new DataTable();

            //using (SqlConnection conn = new SqlConnection(clsGlobal.ConnectionString))
            using (Global.Connection)
            {
                using (SqlCommand cmd = new SqlCommand(pstrSQL, Global.Connection))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            return dt;
        }

        /// <summary>
        /// ExecuteNonQuery the sql string
        /// </summary>
        /// <param name="pstrSQL">sql string to be executed</param>
        public static void Execute(string pstrSQL)
        {
            int rows;
            //using (SqlConnection conn = new SqlConnection(clsGlobal.ConnectionString))
            using (Global.Connection)
            {
                using (SqlCommand cmd = new SqlCommand(pstrSQL, Global.Connection))
                {
                    rows = cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Query Database and Return Specified Column
        /// </summary>
        /// <param name="pstrSQL">Query</param>
        /// <param name="pstrColName">Column to Return </param>
        /// <returns></returns>
        public static string QueryAndReturn(string pstrSQL, string pstrColName)
        {
            string strColValue;
            DataTable dt = Query(pstrSQL);
            DataRow dr = dt.Rows[0];

            strColValue = dr[pstrColName].ToString();
            return strColValue;
        }


        public static DataRow QueryAndReturnRow(string pstrSQL)
        {
            DataTable dt = Query(pstrSQL);
            DataRow dr = dt.Rows[0];

            return dr;
        }

        /// <summary>
        /// Run stored procedure, adding parameters from dictionary
        /// </summary>
        /// <param name="pstrSQL"></param>
        /// <param name="pdictParameters"></param>
        /// <returns>resulting DataTable</returns>
        public static DataTable Query(string pstrSQL, Dictionary<string, string> pdictParameters)
        {
            DataTable dt = new DataTable();

            using (Global.Connection)
            {
                using (SqlCommand cmd = new SqlCommand(pstrSQL, Global.Connection))
                {
                    foreach(KeyValuePair<string, string> param in pdictParameters){
                        cmd.Parameters.Add(param.Key, param.Value);
                    }
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            return dt;
        }
    }
}

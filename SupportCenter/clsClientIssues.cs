using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportCenter
{
    class clsClientIssues
    {
        public DataTable GetOpenItemsForDeveloper(string pstrDeveloperCode)
        {
            string strSQL;
            DataTable dtOpenItems;
            dtOpenItems = new DataTable();

            // TODO 
            strSQL = "SELECT CI.fkClientCode, CI.IssuePriority, CI.IssueSubject, CI.IssueDescription, CI.IssueOpenDate, CI.ProgressNotes " +
                        "FROM ClientIssue CI INNER JOIN Client C ON CI.fkClientCode = C.ClientCode " +
                        "WHERE C.Active = 1 " +
                            "AND (CI.fkAssignedToDeveloper = '" + pstrDeveloperCode + "' " +
                                        "OR C.fkPrimaryContactDeveloper = '" + pstrDeveloperCode + "' " +
                                        "OR C.fkTechnicalContact = '" + pstrDeveloperCode + "') " +
                                "AND CI.CompletedDate IS NULL " +
                        "ORDER BY CI.IssuePriority ASC";
            dtOpenItems = Database.Query(strSQL);

            return dtOpenItems;
        }
    }
}

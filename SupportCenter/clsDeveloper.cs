using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportCenter
{
    class clsDeveloper
    {

        private string mstrDeveloperCode;
        private string mstrDeveloperName;
        private DataTable mdtDeveloperList;
        private string mstrMSResourceName;

//----------------------------------------------------------------------------------------------
//                                          PROPERTIES
//----------------------------------------------------------------------------------------------

        public string DeveloperName
        {
            get
            {
                return mstrDeveloperName;
            }
            set
            {
                mstrDeveloperName = value;
            }
        }

        public string DeveloperCode{
            get{
                return mstrDeveloperCode;
            }
            set{
                mstrDeveloperCode = value;
            }
        }

        //----------------------*
        // READ-ONLY PROPERTIES *
        //----------------------*
        public DataTable DeveloperList{
            get{
                return mdtDeveloperList;
                }
        }

        public string MSResourceName{
            get{
                return mstrMSResourceName;
                }
        }

//----------------------------------------------------------------------------------------------
//                                            EVENTS
//----------------------------------------------------------------------------------------------

        private void Class_Initialize(){

            // Get list of developers from DB.
            string strSQL = "SELECT DeveloperCode, DeveloperName, UserName FROM Developer ";

            //mdtDeveloperList.Open strSQL, gobjConnection.Connection, adOpenKeyset, adLockOptimistic
            using (SqlConnection conn = new SqlConnection(clsGlobal.ConnectionString)){
                using (SqlCommand cmd = new SqlCommand(strSQL, conn)){
                    mdtDeveloperList = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(mdtDeveloperList);
                }
            }

        }     


        //private Sub Class_Terminate(){    
        //    Set mdtDeveloperList = Nothing
        //}

//----------------------------------------------------------------------------------------------
//                                       public PROCEDURES
//----------------------------------------------------------------------------------------------

        public void SetDeveloper(string pstrUserName){
    
            DataRow[] drFilteredRows;
            DataRow drFilteredRow;

            if (mdtDeveloperList.Rows.Count > 0){
                drFilteredRows = mdtDeveloperList.Select("UserName LIKE '%" + pstrUserName + "%'");

                if (drFilteredRows[0] != null){
                    drFilteredRow = drFilteredRows[0];
                    mstrDeveloperCode = drFilteredRow["DeveloperCode"].ToString();
                    mstrDeveloperName = drFilteredRow["DeveloperName"].ToString();
                }
            }

        }

//public Sub ConfigureDeveloperCombo(pcboDeveloper As SSOleDBCombo, _
//                                Optional pblnIncludeAllAsChoice As Boolean = True)

//    Dim intColPosition As Integer
//    Dim strSeparator As String
//    Dim strNewRow As String

//    With pcboDeveloper
//        .DataMode = ssDataModeAddItem
//        .BackColorEven = &HFFFFFF
//        .BackColorOdd = &HC0FFFF
//        .ForeColorEven = &H0&
//        .ForeColorOdd = &H0&
        
//        .Columns.RemoveAll
//        intColPosition = 0
//        .Columns(intColPosition).Name = "DeveloperCode"
//        .Columns(intColPosition).Caption = "Developer Code"
//        .Columns(intColPosition).DataType = vbString
//        intColPosition = intColPosition + 1
        
//        .Columns(intColPosition).Name = "DeveloperName"
//        .Columns(intColPosition).Caption = "Developer"
//        .Columns(intColPosition).DataType = vbString
//        intColPosition = intColPosition + 1
    
//        .FieldSeparator = ";"
//        strSeparator = .FieldSeparator
//        .DataFieldList = "Column 0"
//        .DataFieldToDisplay = "Column 1"
//        .RemoveAll
//        .Text = vbNullString
//    End With
     
//    If pblnIncludeAllAsChoice Then
//        strNewRow = vbNullString & strSeparator +
//                    "All"
                    
//        pcboDeveloper.AddItem (strNewRow)
//    End If
    
//    With mdtDeveloperList
//        If Not (.BOF And .EOF) Then
//            .MoveFirst
//            Do Until .EOF
//                strNewRow = .Fields("DeveloperCode").Value & strSeparator +
//                            .Fields("DeveloperName").Value
                
//                pcboDeveloper.AddItem (strNewRow)
                
//                .MoveNext
//            Loop
//        End If
//        pcboDeveloper.MoveFirst
//    End With

//End Sub

        public void GetIssueCounts(DateTime pdtmStartDate, DateTime pdtmEndDate, int pintIssuesOpened, int pintIssuesClosed, bool pblnGetAllDevelopers = false){
    
            string strSQL;
    
            strSQL = "SELECT COUNT(*) AS IssueCount " +
                    "FROM ClientIssue " +
                    "WHERE IssueOpenDate BETWEEN '" + pdtmStartDate + "' AND '" + pdtmEndDate + "' ";
            if (pblnGetAllDevelopers != true){
                strSQL = strSQL + "AND fkAddedByDeveloper = '" + mstrDeveloperCode + "' ";
            }

           // pintIssuesOpened = clsGlobal.Connection.Execute(strSQL)!IssueCount

            strSQL = "SELECT COUNT(*) AS IssueCount " +
                    "FROM ClientIssue AS CI " +
                        "INNER JOIN Client AS C ON C.ClientCode = CI.fkClientCode " +
                    "WHERE CompletedDate BETWEEN '" + pdtmStartDate + "' AND '" + pdtmEndDate + "' ";
            if (pblnGetAllDevelopers != true){
                strSQL = strSQL + "AND ISNULL(CI.fkAssignedToDeveloper, C.fkPrimaryContactDeveloper) = '" + mstrDeveloperCode + "' ";
            }

            //pintIssuesClosed = clsGlobal.Connection.Execute(strSQL)!IssueCount;

        }

//public Sub GetContactTimes(ByVal pdtmStartDate As Date, _
//                            ByVal pdtmEndDate As Date, _
//                            ByRef plngSupportMinutes As Long, _
//                            ByRef plngMaintenanceMinutes As Long, _
//                            Optional ByVal pblnGetAllDevelopers As Boolean = False)

//    Dim strSQL As String
    
//    strSQL = "SELECT ISNULL(SUM(SupportMinutes), 0) AS SupportMinutes " +
//            "FROM Task " +
//            "WHERE TaskDate BETWEEN '" & pdtmStartDate & "' AND '" & pdtmEndDate & "' "
    
//    If Not pblnGetAllDevelopers Then
//        strSQL = strSQL & "AND fkDeveloperCode = '" & mstrDeveloperCode & "' "
//    End If

//    plngSupportMinutes = gobjConnection.Connection.Execute(strSQL)!SupportMinutes
    
    
//    strSQL = "SELECT ISNULL(SUM(MaintenanceMinutes), 0) AS MaintenanceMinutes " +
//            "FROM Task " +
//            "WHERE TaskDate BETWEEN '" & pdtmStartDate & "' AND '" & pdtmEndDate & "' "
    
//    If Not pblnGetAllDevelopers Then
//        strSQL = strSQL & "AND fkDeveloperCode = '" & mstrDeveloperCode & "' "
//    End If
    
//    plngMaintenanceMinutes = gobjConnection.Connection.Execute(strSQL)!MaintenanceMinutes
//End Sub


//public Function GetDaysSinceLastTimesheetEntry() As Long
//    Dim strSQL As String
    
//    strSQL = "SELECT MIN(DATEDIFF(d, EndDateTime, getdate())) AS LengthOfTime " +
//            "FROM ActivityLog " +
//            "WHERE fkDeveloperCode = '" & mstrDeveloperCode & "'"
    
//    GetDaysSinceLastTimesheetEntry = IfNull(gobjConnection.Connection.Execute(strSQL)!LengthOfTime, 99)
    
//End Function

    }
}

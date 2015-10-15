using System;
using System.Data;
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
                mstrDeveloperName = value;'
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
                return mrstDeveloperList;
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

//private Sub Class_Initialize()

//    Dim strSQL As String
    
//    // Get list of developers from DB.
//'msp    strSQL = _
//        "SELECT DeveloperCode, DeveloperName, UserName, MSResourceName " +
//        "  FROM Developer "
        
//    strSQL = _
//        "SELECT DeveloperCode, DeveloperName, UserName " +
//        "  FROM Developer "

//    Set mdtDeveloperList = New ADODB.Recordset
//    mdtDeveloperList.Open strSQL, gobjConnection.Connection, adOpenKeyset, adLockOptimistic
    
//End Sub

//private Sub Class_Terminate()

//    On Error Resume Next
    
//    Set mdtDeveloperList = Nothing

//End Sub

//----------------------------------------------------------------------------------------------
//                                       public PROCEDURES
//----------------------------------------------------------------------------------------------

        public void SetDeveloper(string pstrUserName){
    
            //With mdtDeveloperList .Find "UserName = '" & pstrUserName & "'"        
            if (.EOF != true){
                mstrDeveloperCode = .Fields("DeveloperCode").Value;
                mstrDeveloperName = .Fields("DeveloperName").Value;
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
    
            //TODO rewrite as one query
            strSQL = "SELECT COUNT(*) AS IssueCount " +
                    "FROM ClientIssue " +
                    "WHERE IssueOpenDate BETWEEN '" + pdtmStartDate + "' AND '" + pdtmEndDate + "' ";
            if (pblnGetAllDevelopers != true){
                strSQL = strSQL & "AND fkAddedByDeveloper = '" + mstrDeveloperCode + "' ";
            }

            //plngIssuesOpened = gobjConnection.Connection.Execute(strSQL)!IssueCount
    
            strSQL = "SELECT COUNT(*) AS IssueCount " +
                    "FROM ClientIssue AS CI " +
                        "INNER JOIN Client AS C ON C.ClientCode = CI.fkClientCode " +
                    "WHERE CompletedDate BETWEEN '" + pdtmStartDate + "' AND '" + pdtmEndDate + "' ";
            if (pblnGetAllDevelopers != true){
                strSQL = strSQL + "AND ISNULL(CI.fkAssignedToDeveloper, C.fkPrimaryContactDeveloper) = '" + mstrDeveloperCode + "' ";
            }

            //plngIssuesClosed = gobjConnection.Connection.Execute(strSQL)!IssueCount;

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

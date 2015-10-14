using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportCenter
{
    class clsDeveloper
    {

//Private mstrDeveloperCode As String
//Private mstrDeveloperName As String
//Private mrstDeveloperList As ADODB.Recordset
//Private mstrMSResourceName As String

//Public Property Get MSResourceName() As String
//    MSResourceName = mstrMSResourceName
//End Property

////----------------------------------------------------------------------------------------------
////                                          PROPERTIES
////----------------------------------------------------------------------------------------------

//Public Property Get DeveloperName() As String
//    DeveloperName = mstrDeveloperName
//End Property

//Public Property Get DeveloperCode() As String
//    DeveloperCode = mstrDeveloperCode
//End Property

////----------------------*
//// READ-ONLY PROPERTIES *
////----------------------*
//Public Property Get DeveloperList() As ADODB.Recordset
//    Set DeveloperList = mrstDeveloperList
//End Property

////----------------------------------------------------------------------------------------------
////                                            EVENTS
////----------------------------------------------------------------------------------------------

//Private Sub Class_Initialize()

//    Dim strSQL As String
    
//    // Get list of developers from DB.
//'msp    strSQL = _
//        "SELECT DeveloperCode, DeveloperName, UserName, MSResourceName " & _
//        "  FROM Developer "
        
//    strSQL = _
//        "SELECT DeveloperCode, DeveloperName, UserName " & _
//        "  FROM Developer "

//    Set mrstDeveloperList = New ADODB.Recordset
//    mrstDeveloperList.Open strSQL, gobjConnection.Connection, adOpenKeyset, adLockOptimistic
    
//End Sub

//Private Sub Class_Terminate()

//    On Error Resume Next
    
//    Set mrstDeveloperList = Nothing

//End Sub

////----------------------------------------------------------------------------------------------
////                                       PUBLIC PROCEDURES
////----------------------------------------------------------------------------------------------

//Public Sub SetDeveloper(pstrUserName As String)
    
//    With mrstDeveloperList
//        .Find "UserName = '" & pstrUserName & "'", , , adBookmarkFirst
        
//        If Not .EOF Then
//            mstrDeveloperCode = .Fields("DeveloperCode").Value
//            mstrDeveloperName = .Fields("DeveloperName").Value
//'msp            mstrMSResourceName = IfNull(.Fields("MSResourceName").Value, vbNullString)
//        End If
//    End With

//End Sub

//Public Sub ConfigureDeveloperCombo(pcboDeveloper As SSOleDBCombo, _
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
//        strNewRow = vbNullString & strSeparator & _
//                    "All"
                    
//        pcboDeveloper.AddItem (strNewRow)
//    End If
    
//    With mrstDeveloperList
//        If Not (.BOF And .EOF) Then
//            .MoveFirst
//            Do Until .EOF
//                strNewRow = .Fields("DeveloperCode").Value & strSeparator & _
//                            .Fields("DeveloperName").Value
                
//                pcboDeveloper.AddItem (strNewRow)
                
//                .MoveNext
//            Loop
//        End If
//        pcboDeveloper.MoveFirst
//    End With

//End Sub

//Public Sub GetIssueCounts(ByVal pdtmStartDate As Date, _
//                            ByVal pdtmEndDate As Date, _
//                            ByRef plngIssuesOpened As Long, _
//                            ByRef plngIssuesClosed As Long, _
//                            Optional ByVal pblnGetAllDevelopers As Boolean = False)
    
//    Dim strSQL As String
    
//    strSQL = "SELECT COUNT(*) AS IssueCount " & _
//            "FROM ClientIssue " & _
//            "WHERE IssueOpenDate BETWEEN '" & pdtmStartDate & "' AND '" & pdtmEndDate & "' "
//    If Not pblnGetAllDevelopers Then
//        strSQL = strSQL & "AND fkAddedByDeveloper = '" & mstrDeveloperCode & "' "
//    End If

//    plngIssuesOpened = gobjConnection.Connection.Execute(strSQL)!IssueCount
    
//    strSQL = "SELECT COUNT(*) AS IssueCount " & _
//            "FROM ClientIssue AS CI " & _
//                "INNER JOIN Client AS C ON C.ClientCode = CI.fkClientCode " & _
//            "WHERE CompletedDate BETWEEN '" & pdtmStartDate & "' AND '" & pdtmEndDate & "' "
//    If Not pblnGetAllDevelopers Then
//        strSQL = strSQL & "AND ISNULL(CI.fkAssignedToDeveloper, C.fkPrimaryContactDeveloper) = '" & mstrDeveloperCode & "' "
//    End If

//    plngIssuesClosed = gobjConnection.Connection.Execute(strSQL)!IssueCount

//End Sub

//Public Sub GetContactTimes(ByVal pdtmStartDate As Date, _
//                            ByVal pdtmEndDate As Date, _
//                            ByRef plngSupportMinutes As Long, _
//                            ByRef plngMaintenanceMinutes As Long, _
//                            Optional ByVal pblnGetAllDevelopers As Boolean = False)

//    Dim strSQL As String
    
//    strSQL = "SELECT ISNULL(SUM(SupportMinutes), 0) AS SupportMinutes " & _
//            "FROM Task " & _
//            "WHERE TaskDate BETWEEN '" & pdtmStartDate & "' AND '" & pdtmEndDate & "' "
    
//    If Not pblnGetAllDevelopers Then
//        strSQL = strSQL & "AND fkDeveloperCode = '" & mstrDeveloperCode & "' "
//    End If

//    plngSupportMinutes = gobjConnection.Connection.Execute(strSQL)!SupportMinutes
    
    
//    strSQL = "SELECT ISNULL(SUM(MaintenanceMinutes), 0) AS MaintenanceMinutes " & _
//            "FROM Task " & _
//            "WHERE TaskDate BETWEEN '" & pdtmStartDate & "' AND '" & pdtmEndDate & "' "
    
//    If Not pblnGetAllDevelopers Then
//        strSQL = strSQL & "AND fkDeveloperCode = '" & mstrDeveloperCode & "' "
//    End If
    
//    plngMaintenanceMinutes = gobjConnection.Connection.Execute(strSQL)!MaintenanceMinutes
//End Sub


//Public Function GetDaysSinceLastTimesheetEntry() As Long
//    Dim strSQL As String
    
//    strSQL = "SELECT MIN(DATEDIFF(d, EndDateTime, getdate())) AS LengthOfTime " & _
//            "FROM ActivityLog " & _
//            "WHERE fkDeveloperCode = '" & mstrDeveloperCode & "'"
    
//    GetDaysSinceLastTimesheetEntry = IfNull(gobjConnection.Connection.Execute(strSQL)!LengthOfTime, 99)
    
//End Function

    }
}

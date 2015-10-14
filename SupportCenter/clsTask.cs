using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportCenter
{
    class clsTask
    {

//Const mc_intMinMinutesToCharge = 5
//Const mc_intRoundToIncrement = 15

//Private mintMinutes          As Integer
//Private mlngTaskID           As Long
//Private mdatTaskDate         As Date
//Private mstrfkDeveloperCode  As String
//Private mstrfkClientCode     As String
//Private mstrfkClaimsUserCode As String
//Private mstrIssue            As String
//Private mstrTaskType         As String
//Private mrstActivityList     As ADODB.Recordset
//Private mrstTask             As ADODB.Recordset

////----------------------------------------------------------------------------------------------
////                                          PROPERTIES
////----------------------------------------------------------------------------------------------

//Public Property Get ActivityMinutes() As Integer
    
//    Dim intActivityMinutes As Integer
    
//    With mrstActivityList
//        If .RecordCount < 1 Then
//            intActivityMinutes = 0
//        Else
//            .MoveFirst
//            Do Until .EOF
            
//                intActivityMinutes = intActivityMinutes + .Fields("DurationMinutes").Value
//                .MoveNext
//            Loop
//        End If
//    End With
    
//    ActivityMinutes = intActivityMinutes

//End Property
//Public Property Get ActivityList() As ADODB.Recordset
//    Set ActivityList = mrstActivityList
//End Property

//Public Property Get TaskType() As String
//    TaskType = mstrTaskType
//End Property
//Public Property Let TaskType(ByVal Value As String)
//    mstrTaskType = Value
//End Property

//Public Property Get Minutes() As Integer
//    Minutes = mintMinutes
//End Property
//Public Property Let Minutes(ByVal Value As Integer)
//    mintMinutes = Value
//End Property

//Public Property Get Issue() As String
//    Issue = mstrIssue
//End Property
//Public Property Let Issue(ByVal Value As String)
//    mstrIssue = Value
//End Property

//Public Property Get fkClaimsUserCode() As String
//    fkClaimsUserCode = mstrfkClaimsUserCode
//End Property
//Public Property Let fkClaimsUserCode(ByVal Value As String)
//    mstrfkClaimsUserCode = Value
//End Property

//Public Property Get fkClientCode() As String
//    fkClientCode = mstrfkClientCode
//End Property
//Public Property Let fkClientCode(ByVal Value As String)
//    mstrfkClientCode = Value
//End Property

//Public Property Get TaskDate() As Date
//    TaskDate = mdatTaskDate
//End Property
//Public Property Let TaskDate(ByVal Value As Date)
//    mdatTaskDate = Value
//End Property

//Public Property Get fkDeveloperCode() As String
//    fkDeveloperCode = mstrfkDeveloperCode
//End Property
//Public Property Let fkDeveloperCode(ByVal Value As String)
//    mstrfkDeveloperCode = Value
//End Property

////----------------------*
//// READ-ONLY PROPERTIES *
////----------------------*
//Public Property Get TaskID() As Long
//    TaskID = mlngTaskID
//End Property

////----------------------------------------------------------------------------------------------
////                                            EVENTS
////----------------------------------------------------------------------------------------------

//Private Sub Class_Initialize()
    
//    Set mrstTask = New ADODB.Recordset
//    Set mrstActivityList = New ADODB.Recordset

//End Sub

//Private Sub Class_Terminate()
    
//    On Error Resume Next
    
//    Set mrstTask = Nothing
//    Set mrstActivityList = Nothing

//End Sub

////----------------------------------------------------------------------------------------------
////                                       PUBLIC PROCEDURES
////----------------------------------------------------------------------------------------------

////----------------------------------------------------------------------------------------------
////     Project:    SupportCenter
////   Procedure:    DeleteTask
//// Description:    Delete the specified task from the DB.
////  Created By:    Richard M. Conlan - 5/17/2004
////
////  Parameters:    plngTaskID (Long)
////----------------------------------------------------------------------------------------------
//Public Sub DeleteTask(plngTaskID As Long)

//    Dim strSQL As String
    
//    strSQL = _
//        "DELETE FROM Task " & _
//        " WHERE TaskID = '" & plngTaskID & "' "
        
//    gobjConnection.Connection.Execute strSQL

//End Sub

//Public Sub EditTask(plngTaskID As Long)
    
//    Dim strSQL As String
    
//    If mrstTask.State = adStateOpen Then mrstTask.Close
//    If mrstActivityList.State = adStateOpen Then mrstActivityList.Close
    
//    strSQL = _
//        "SELECT TaskID, fkDeveloperCode, TaskDate, fkClientCode, fkClaimsUserCode, " & _
//        "       Issue, SupportMinutes, MaintenanceMinutes, TaskType, CreatedDateTime, " & _
//        "       CreatedUser, ModifiedDateTime, ModifiedUser " & _
//        "  FROM Task " & _
//        " WHERE TaskID = " & plngTaskID
    
//    With mrstTask
//        .Open strSQL, gobjConnection.Connection, adOpenKeyset, adLockOptimistic, adCmdText
        
//        If .EOF Then
//            mlngTaskID = -1
//            mstrfkDeveloperCode = vbNullString
//            mdatTaskDate = Date
//            mstrfkClientCode = vbNullString
//            mstrfkClaimsUserCode = vbNullString
//            mstrIssue = vbNullString
//            mintMinutes = 0
//            mstrTaskType = "SUPPORT"
//        Else
//            mlngTaskID = .Fields("TaskID").Value
//            mstrfkDeveloperCode = .Fields("fkDeveloperCode").Value
//            mdatTaskDate = .Fields("TaskDate").Value
//            mstrfkClientCode = .Fields("fkClientCode").Value
//            mstrfkClaimsUserCode = .Fields("fkClaimsUserCode").Value
//            mstrIssue = .Fields("Issue").Value
//            mintMinutes = IfNull(.Fields("SupportMinutes").Value, 0) + _
//                IfNull(.Fields("MaintenanceMinutes").Value, 0)
            
//            If IfNull(.Fields("TaskType").Value, vbNullString) = vbNullString Then
//                If mintMinutes < 1 Then
//                    mstrTaskType = "MAINTENANCE"
//                ElseIf IfNull(.Fields("SupportMinutes").Value, 0) > 0 Then
//                    mstrTaskType = "SUPPORT"
//                Else
//                    mstrTaskType = "MAINTENANCE"
//                End If
            
//            Else
//                mstrTaskType = .Fields("TaskType").Value
//            End If
            
//        End If
//    End With
    
//    // Get the activity log for the specified task from the DB.
//    strSQL = _
//        "SELECT CallLogID, StartDateTime, EndDateTime, Subject, Description, " & _
//        "       fkClaimsUserCode, fkClientCode, fkDeveloperCode, fkTaskID, " & _
//        "       fkActivityCode, DurationMinutes, InternalOrExternal, OpenItemID " & _
//        "  FROM ActivityLog " & _
//        " WHERE fkTaskID = " & mlngTaskID

//    mrstActivityList.Open strSQL, gobjConnection.Connection, adOpenKeyset, adLockReadOnly

//End Sub

//Public Function GetRoundedMinutes(pintMinutes As Integer) As Integer

//    GetRoundedMinutes = _
//            Round((pintMinutes / mc_intRoundToIncrement), 0) * mc_intRoundToIncrement

//    If GetRoundedMinutes < mc_intMinMinutesToCharge Then
//        GetRoundedMinutes = mc_intMinMinutesToCharge
//    End If

//End Function

//Public Sub NewTask()
    
//    Dim strSQL As String
    
//    If mrstTask.State = adStateOpen Then mrstTask.Close
//    If mrstActivityList.State = adStateOpen Then mrstActivityList.Close
    
//    // Get list of tasks from the DB.
//    strSQL = _
//        "SELECT TaskID, fkDeveloperCode, TaskDate, fkClientCode, fkClaimsUserCode, " & _
//        "       Issue, SupportMinutes, MaintenanceMinutes, TaskType, CreatedDateTime, " & _
//        "       CreatedUser, ModifiedDateTime, ModifiedUser " & _
//        "  FROM Task " & _
//        " WHERE 1=2"
    
//    mrstTask.Open strSQL, gobjConnection.Connection, adOpenKeyset, adLockOptimistic, adCmdText
    
//    mlngTaskID = -1
//    mstrfkDeveloperCode = vbNullString
//    mdatTaskDate = Date
//    mstrfkClientCode = vbNullString
//    mstrfkClaimsUserCode = vbNullString
//    mstrIssue = vbNullString
//    mintMinutes = 0
//    mstrTaskType = "SUPPORT"
    
//    // Get list of activity logs not associated with tasks from DB.
//    strSQL = _
//        "SELECT CallLogID, StartDateTime, EndDateTime, Subject, Description, " & _
//        "       fkClaimsUserCode, fkClientCode, fkDeveloperCode, fkTaskID, " & _
//        "       fkActivityCode, DurationMinutes, InternalOrExternal, OpenItemID " & _
//        "  FROM ActivityLog " & _
//        " WHERE fkTaskID = -1 "
    
//    mrstActivityList.Open strSQL, gobjConnection.Connection, adOpenKeyset, adLockReadOnly
    
//End Sub

//Public Function Save(penuFormState As FormState) As Boolean
    
//    On Error GoTo PROC_ERROR

//    Const c_strSource As String = "SupportCenter.clsTask.Save"

//    Save = False
//    With mrstTask
        
//        If penuFormState = jmaAddMode Then
//            .AddNew
//        End If
    
//        .Fields("fkDeveloperCode").Value = mstrfkDeveloperCode
//        .Fields("TaskDate").Value = mdatTaskDate
//        .Fields("fkClientCode").Value = mstrfkClientCode
//        .Fields("fkClaimsUserCode").Value = mstrfkClaimsUserCode
//        .Fields("Issue").Value = mstrIssue
//        .Fields("TaskType").Value = mstrTaskType
//        If mstrTaskType = "SUPPORT" Then
//            .Fields("SupportMinutes").Value = GetRoundedMinutes(mintMinutes)
//            .Fields("MaintenanceMinutes").Value = 0
//        Else
//            .Fields("SupportMinutes").Value = 0
//            .Fields("MaintenanceMinutes").Value = GetRoundedMinutes(mintMinutes)
//        End If
    
//        .Update
//        mlngTaskID = .Fields("TaskID").Value
        
//    End With
    
//    Save = True

//PROC_EXIT:

//    Exit Function

//PROC_ERROR:

//    Call ErrorHandler(c_strSource)
//    GoTo PROC_EXIT

//End Function

    }
}

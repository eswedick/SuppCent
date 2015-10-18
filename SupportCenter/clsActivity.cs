using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportCenter
{
    // Activities are the 
    class clsActivity
    {

        private DateTime mdtmStartDateTime;
        private DateTime mdtmEndDateTime;
        private int mintOpenItemID;
        private string mstrvoidject;
        private string mstrDesription;
        private string mstrfkClaimsUserCode;
        private string mstrfkClientCode;
        private string mstrfkDeveloperCode;
        private string mstrfkActivityCode;
        private int mintfkTaskID;
        private int mintCallLogID;
        private int mintDurationMinutes;
        private string mstrInternalOrExternal;
        private DataTable mdtActivityLog;
        private DataTable mdtActivityCodes;

//----------------------------------------------------------------------------------------------
//                                          PROPERTIES
//----------------------------------------------------------------------------------------------

public int OpenItemID{
    get{
        return mintOpenItemID;
    }
    set{
        mintOpenItemID = value;
    }
}

public int DurationMinutes{
    get{
        return mintDurationMinutes;
    }
    set{
        mintDurationMinutes = value;
    }
}

public int fkTaskID{
    get{
        return mintfkTaskID;
    }
    set{
        mintfkTaskID = value;
    }
}

public string fkActivityCode{
    get{
        return mstrfkActivityCode;
    }
    set{
        mstrfkActivityCode = value;
    }
}

public string fkDeveloperCode{
    get{
        return mstrfkDeveloperCode;
    }
    set{
        mstrfkDeveloperCode = value;
    }
}

public string fkClientCode{
    get{
        return mstrfkClientCode;
    }
    set{
        mstrfkClientCode = value;
    }
}

public string fkClaimsUserCode{
    get{
        return mstrfkClaimsUserCode;
    }
    set{
        mstrfkClaimsUserCode = value;
    }
}

public string Description{
    get{
        return mstrDesription;
    }
    set{
        mstrDesription = value;
    }
}

public string voidject{
    get{
        return mstrvoidject;
    }
    set{
        mstrvoidject = value;
    }
}

public DateTime EndDateTime{
    get{
        return mdtmEndDateTime;
    }
    set{
        mdtmEndDateTime = value;
    }
}

public DateTime StartDateTime{
    get{
        return mdtmStartDateTime;
    }
    set{
        mdtmStartDateTime = value;
    }
}

//----------------------*
// READ-ONLY PROPERTIES *
//----------------------*
public string InternalOrExternal{
    get{
        return mstrInternalOrExternal;
    }
}
    
public DataTable ActivityCodes{
    get{
        return mdtActivityCodes;
    }
}

public int CallLogID{
    get{
        return mintCallLogID;
    }
}
    
//----------------------------------------------------------------------------------------------
//                                            EVENTS
//----------------------------------------------------------------------------------------------

private void Class_Initialize(){

    string strSQL;
    
    // Get activity codes from DB.
    strSQL = "SELECT ActivityCode, ActivityDescription, InternalOrExternal FROM ActivityType ";
    
    //Set mrstActivityCodes = New ADODB.Recordset
    //mrstActivityCodes.Open strSQL, gobjConnection.Connection, _
    //    adOpenStatic, adLockReadOnly, adCmdText

    //Set mrstActivityLog = New ADODB.Recordset

}

private void Class_Terminate(){

    //On Error Resume Next
    
    //Set mrstActivityLog = Nothing
    //Set mrstActivityCodes = Nothing

}

//----------------------------------------------------------------------------------------------
//                                       public PROCEDURES
//----------------------------------------------------------------------------------------------

public void ConfigureActivityCodeCombo(string pstrInternalOrExternalActivities, bool pblnIncludeAllAsChoice = true){
    
    //Dim intColPosition As Integer
    //Dim strSeparator   As String
    //Dim strNewRow      As String

    //With pcboActivityCode
    //    .DataMode = ssDataModeAddItem
    //    .BackColorEven = &HFFFFFF
    //    .BackColorOdd = &HC0FFFF
    //    .ForeColorEven = &H0&
    //    .ForeColorOdd = &H0&
        
    //    .Columns.RemoveAll
    //    intColPosition = 0
    //    .Columns(intColPosition).Name = "ActivityCode"
    //    .Columns(intColPosition).Caption = "Code"
    //    .Columns(intColPosition).DataType = vbString
    //    intColPosition = intColPosition + 1
        
    //    .Columns(intColPosition).Name = "ActivityDescription"
    //    .Columns(intColPosition).Caption = "Description"
    //    .Columns(intColPosition).DataType = vbString
    //    intColPosition = intColPosition + 1
    
    //    .FieldSeparator = ";"
    //    strSeparator = .FieldSeparator
    //    .DataFieldList = "Column 0"
    //    .DataFieldToDisplay = "Column 1"
    //    .RemoveAll
    //    .Text = vbNullString
    //End With
     
    //If pblnIncludeAllAsChoice Then
    //    strNewRow = vbNullString & strSeparator+
    //                "All"
                    
    //    pcboActivityCode.AddItem (strNewRow)
    //End If
    
    //With mrstActivityCodes
    //    If Not (.BOF And .EOF) Then
    //        .MoveFirst
    //        Do Until .EOF
    //            If UCase(.Fields("InternalOrExternal").Value) = UCase(pstrInternalOrExternalActivities) Then
    //                strNewRow = _
    //                    .Fields("ActivityCode").Value & strSeparator+
    //                    .Fields("ActivityDescription").Value
                
    //                pcboActivityCode.AddItem (strNewRow)
    //            End If
    //            .MoveNext
    //        Loop
    //    End If
    //    pcboActivityCode.MoveFirst
    //End With


}

//----------------------------------------------------------------------------------------------
//     Project:    SupportCenter
//   Procedure:    DeleteActivity
// Description:    Delete the specified activity.
//  Created By:    Richard M. Conlan - 5/17/2004
//
//  Parameters:    plngCallLogID (Long)
//----------------------------------------------------------------------------------------------
public void DeleteActivity(int pintCallLogID){

    string strSQL;
    
    strSQL = "DELETE FROM ActivityLog WHERE CallLogID = " + pintCallLogID + "";
        
    //gobjConnection.Connection.Execute strSQL

}

public void EditActivity(int pintCallLogID){
    
    string strSQL;
    
    //If mrstActivityLog.State = adStateOpen Then mrstActivityLog.Close
    
    //strSQL = _
    //    "SELECT CallLogID, StartDateTime, EndDateTime, voidject, Description, "+
    //    "       fkClaimsUserCode, fkClientCode, fkDeveloperCode, fkTaskID, fkActivityCode, "+
    //    "       DurationMinutes, InternalOrExternal, OpenItemID "+
    //    "  FROM ActivityLog "+
    //    " WHERE CallLogID = " & plngCallLogID
    
    //With mrstActivityLog
    //    .Open strSQL, gobjConnection.Connection, adOpenKeyset, adLockOptimistic, adCmdText
        
    //    If .EOF Then
    //        mlngOpenItemID = 0
    //        mdtmStartDateTime = Now
    //        mdtmEndDateTime = Now
    //        mstrvoidject = vbNullString
    //        mstrDesription = vbNullString
    //        mstrfkClaimsUserCode = vbNullString
    //        mstrfkClientCode = vbNullString
    //        mstrfkDeveloperCode = vbNullString
    //        mstrfkActivityCode = vbNullString
    //        mlngfkTaskID = -1
    //        mlngCallLogID = -1
    //        mintDurationMinutes = 0
    //        mstrInternalOrExternal = vbNullString
    //    Else
    //        mlngOpenItemID = IfNull(.Fields("OpenItemID").Value, 0, true, true)
    //        mdtmStartDateTime = .Fields("StartDateTime").Value
    //        mdtmEndDateTime = .Fields("EndDateTime").Value
    //        mstrvoidject = .Fields("voidject").Value
    //        mstrDesription = .Fields("Description").Value
    //        mstrfkClaimsUserCode = IfNull(.Fields("fkClaimsUserCode").Value, vbNullString, true, true)
    //        mstrfkClientCode = IfNull(.Fields("fkClientCode").Value, vbNullString, true, true)
    //        mstrfkDeveloperCode = .Fields("fkDeveloperCode").Value
    //        mstrfkActivityCode = .Fields("fkActivityCode").Value
    //        mlngfkTaskID = IfNull(.Fields("fkTaskID").Value, -1, true, true)
    //        mlngCallLogID = IfNull(.Fields("CallLogID").Value, -1, true, true)
    //        mintDurationMinutes = .Fields("DurationMinutes").Value
    //        mstrInternalOrExternal = .Fields("InternalOrExternal").Value
    //    End If
    //End With
}

//----------------------------------------------------------------------------------------------
//     Project:    SupportCenter
//   Procedure:    GetActivityList
// Description:    Get a filtered activity log list from the DB.
//  Created By:    Richard M. Conlan - 5/6/2004
//
//  Parameters:    pstrClientCode (String)
//                 pstrDeveloperCode (String)
//                 pdtmFromDate (Date)
//                 pdtmToDate (Date)
//                 pstrInternalOrExtenral (String)
//                 pstrTaskType (String)
//     Returns: A recordset containing the filtered activity list.
//----------------------------------------------------------------------------------------------
public DataTable GetActivityList(string pstrClientCode, string pstrDeveloperCode, DateTime pdtmFromDate, DateTime pdtmToDate, string pstrInternalOrExternal, string pstrTaskType){
    
    string strSQL;
    //Dim rstActivityList As ADODB.Recordset

    // Get filtered activity log list from DB.
    strSQL = "SELECT AL.StartDateTime AS Date, D.DeveloperName AS Developer, "+
        "       C.ClientName AS Client, AL.fkActivityCode AS Activity, "+
        "       AL.DurationMinutes AS Duration, AL.InternalOrExternal, T.TaskType "+
        "  FROM ActivityLog AL "+
        "         INNER JOIN Developer D ON AL.fkDeveloperCode = D.DeveloperCode "+
        "         INNER JOIN Client C ON AL.fkClientCode = C.ClientCode "+
        "         INNER JOIN Task T ON AL.fkTaskID = T.TaskID "+
        " WHERE AL.StartDateTime BETWEEN '" + pdtmFromDate + "' AND '" + pdtmToDate + "' "+
        "       AND AL.InternalOrExternal = '" + pstrInternalOrExternal + "' "+
        "       AND T.TaskType = '" + pstrTaskType + "' ";
        
    // Only filter by client if a client was specified.
    //If Trim$(pstrClientCode) <> vbNullString Then
    //    strSQL = strSQL+
    //        "       AND AL.fkClientCode = '" & pstrClientCode & "' "
    //End If
    
    // Only filter by developer if a developer was specified.
    //If Trim$(pstrDeveloperCode) <> vbNullString Then
    //    strSQL = strSQL+
    //        "       AND AL.fkDeveloperCode = '" & pstrDeveloperCode & "' "
    //End If
    
    //Set rstActivityList = New ADODB.Recordset
    //rstActivityList.Open strSQL, gobjConnection.Connection, _
    //    adOpenStatic, adLockReadOnly, adCmdText
        
    //Set GetActivityList = rstActivityList
    return new DataTable();
}

//----------------------------------------------------------------------------------------------
//     Project:    SupportCenter
//   Procedure:    GetFilteredDevelopmentActivities
// Description:    [type_description_here]
//  Created By:    Richard M. Conlan - 5/17/2004
//
//  Parameters:    pstrDeveloperCode (String)
//                 pdtmFromDate (Date)
//                 pdtmToDate (Date)
//     Returns:
//----------------------------------------------------------------------------------------------
//public Function GetFilteredDevelopmentActivities( _
//    pdtmFromDate As Date, pdtmToDate As Date) As ADODB.Recordset
    
//    Dim strSQL                           As String
//    Dim rstFilteredDevelopmentActivities As ADODB.Recordset
    
//    // Get filtered activity log list from DB.
//    strSQL = _
//        "SELECT CallLogID, fkDeveloperCode, OpenItemID, StartDateTime, EndDateTime, "+
//        "       voidject, Description, fkActivityCode, DurationMinutes "+
//        "  FROM ActivityLog "+
//        " WHERE StartDateTime BETWEEN '" & pdtmFromDate & "' AND '" & pdtmToDate & "' "+
//        "       AND InternalOrExternal = 'INTERNAL' "
    
//    Set rstFilteredDevelopmentActivities = New ADODB.Recordset
//    rstFilteredDevelopmentActivities.Open strSQL, gobjConnection.Connection, _
//        adOpenStatic, adLockReadOnly, adCmdText
        
//    Set GetFilteredDevelopmentActivities = rstFilteredDevelopmentActivities

//}

//public void NewActivity()
    
//    string strSQL;
    
//    If mrstActivityLog.State = adStateOpen Then mrstActivityLog.Close
    
//    strSQL = _
//        "SELECT CallLogID, StartDateTime, EndDateTime, voidject, Description, "+
//        "       fkClaimsUserCode, fkClientCode, fkDeveloperCode, fkTaskID, fkActivityCode, "+
//        "       DurationMinutes, InternalOrExternal, OpenItemID "+
//        "  FROM ActivityLog "+
//        " WHERE 1=2 "
    
//    mrstActivityLog.Open strSQL, gobjConnection.Connection, adOpenKeyset, adLockOptimistic
    
//    mlngOpenItemID = 0
//    mdtmStartDateTime = Now
//    mdtmEndDateTime = Now
//    mstrvoidject = vbNullString
//    mstrDesription = vbNullString
//    mstrfkClaimsUserCode = vbNullString
//    mstrfkClientCode = vbNullString
//    mstrfkDeveloperCode = vbNullString
//    mstrfkActivityCode = vbNullString
//    mlngfkTaskID = -1
//    mlngCallLogID = -1
//    mintDurationMinutes = 0
    
//}

//public bool Save(penuFormState As FormState){

//    Save = false
//    With mrstActivityLog
        
//        If penuFormState = jmaAddMode Then
//            .AddNew
//        End If
    
//        .Fields("OpenItemID").Value = IIf(mlngOpenItemID <> 0, mlngOpenItemID, Null)
//        .Fields("StartDateTime").Value = mdtmStartDateTime
//        .Fields("EndDateTime").Value = mdtmEndDateTime
//        .Fields("voidject").Value = mstrvoidject
//        .Fields("Description").Value = mstrDesription
//        .Fields("fkClaimsUserCode").Value = IfNull(mstrfkClaimsUserCode, Null, , true)
//        .Fields("fkClientCode").Value = IfNull(mstrfkClientCode, Null, , true)
//        .Fields("fkDeveloperCode").Value = mstrfkDeveloperCode
//        .Fields("fkActivityCode").Value = mstrfkActivityCode
//        .Fields("fkTaskID").Value = IIf(mlngfkTaskID <> -1, mlngfkTaskID, Null)
//        .Fields("DurationMinutes").Value = mintDurationMinutes
//        .Fields("InternalOrExternal").Value = GetInternalOrExternal(mstrfkActivityCode)
//        .Update
//        mlngCallLogID = .Fields("CallLogID").Value
        
//    End With
    
//    Save = true

//}

//public Function GetActivitiesByDeveloperAndDate(ByVal pstrDeveloperCode As String, _
//                                                ByVal pdtmStartDateTime As Date, _
//                                                ByVal pdtmEndDateTime As Date) As ADODB.Recordset
//    '<EhHeader>
//    On Error GoTo PROC_ERROR
//    Const c_strSource As String = "SupportCenter.clsActivity.GetActivitiesByDeveloperAndDate"
//    '</EhHeader>
                                                
//    string strSQL;
//    Dim rstActivities As ADODB.Recordset
//    Set rstActivities = New ADODB.Recordset
    
//    strSQL = "SELECT C.ClientName, "+
//        "CU.ClaimsUserCode, "+
//        "AL.StartDateTime, "+
//        "AL.EndDateTime, "+
//        "Al.voidject, "+
//        "AL.Description "+
//    "FROM ActivityLog AS AL "+
//        "LEFT OUTER JOIN Client AS C ON C.ClientCode = AL.fkClientCode "+
//        "LEFT OUTER JOIN ClaimsUser AS CU ON CU.ClaimsUserCode = AL.fkClaimsUserCode "+
//            "AND CU.fkClientCode = AL.fkClientCode "+
//    "WHERE AL.fkDeveloperCode = '" & pstrDeveloperCode & "' "+
//        "AND AL.StartDateTime >= '" & pdtmStartDateTime & " 1:00 AM' "+
//        "AND AL.EndDateTime <= '" & pdtmEndDateTime & " 11:59:59 PM'"
    
//    Call rstActivities.Open(strSQL, gobjConnection.Connection)
        
//    Set GetActivitiesByDeveloperAndDate = rstActivities

//'<EhFooter>
//PROC_EXIT:
//    Set rstActivities = Nothing

//    Exit Function
//PROC_ERROR:
//    Call ErrorHandler(c_strSource)
//    GoTo PROC_EXIT
//'</EhFooter>
//}

////----------------------------------------------------------------------------------------------
////                                      private PROCEDURES
////----------------------------------------------------------------------------------------------

//private Function GetInternalOrExternal(pstrActivityCode As String) As String

//    On Error GoTo PROC_ERROR

//    Const c_strSource As String = "SupportCenter.clsActivity.GetInternalOrExternal"

//    GetInternalOrExternal = vbNullString
    
//    With mrstActivityCodes
//        .Find "ActivityCode = '" & pstrActivityCode & "'", , , adBookmarkFirst
        
//        If .EOF Then
//            GoTo PROC_EXIT
//        End If
        
//        GetInternalOrExternal = .Fields("InternalOrExternal").Value
//        .MoveFirst
//    End With

//PROC_EXIT:

//    Exit Function

//PROC_ERROR:

//    Call ErrorHandler(c_strSource)
//    GoTo PROC_EXIT

//}

    }
}

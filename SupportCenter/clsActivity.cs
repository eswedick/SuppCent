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

    mdtActivityCodes = Database.Query(strSQL);

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
    //    .Text = null
    //End With
     
    //If pblnIncludeAllAsChoice Then
    //    strNewRow = null & strSeparator+
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

    Database.Execute(strSQL);

}

public void EditActivity(int pintCallLogID){
    
    string strSQL;
    
    //If mrstActivityLog.State = adStateOpen Then mrstActivityLog.Close
    
    strSQL = "SELECT CallLogID, StartDateTime, EndDateTime, voidject, Description, " +
            "       fkClaimsUserCode, fkClientCode, fkDeveloperCode, fkTaskID, fkActivityCode, " +
            "       DurationMinutes, InternalOrExternal, OpenItemID " +
            "  FROM ActivityLog " +
            " WHERE CallLogID = " + pintCallLogID;
    
    //With mrstActivityLog
    //    .Open strSQL, gobjConnection.Connection, adOpenKeyset, adLockOptimistic, adCmdText
        
    //    If .EOF Then
    //        mlngOpenItemID = 0
    //        mdtmStartDateTime = Now
    //        mdtmEndDateTime = Now
    //        mstrvoidject = null
    //        mstrDesription = null
    //        mstrfkClaimsUserCode = null
    //        mstrfkClientCode = null
    //        mstrfkDeveloperCode = null
    //        mstrfkActivityCode = null
    //        mlngfkTaskID = -1
    //        mlngCallLogID = -1
    //        mintDurationMinutes = 0
    //        mstrInternalOrExternal = null
    //    Else
    //        mlngOpenItemID = IfNull(.Fields("OpenItemID").Value, 0, true, true)
    //        mdtmStartDateTime = .Fields("StartDateTime").Value
    //        mdtmEndDateTime = .Fields("EndDateTime").Value
    //        mstrvoidject = .Fields("voidject").Value
    //        mstrDesription = .Fields("Description").Value
    //        mstrfkClaimsUserCode = IfNull(.Fields("fkClaimsUserCode").Value, null, true, true)
    //        mstrfkClientCode = IfNull(.Fields("fkClientCode").Value, null, true, true)
    //        mstrfkDeveloperCode = .Fields("fkDeveloperCode").Value
    //        mstrfkActivityCode = .Fields("fkActivityCode").Value
    //        mlngfkTaskID = IfNull(.Fields("fkTaskID").Value, -1, true, true)
    //        mlngCallLogID = IfNull(.Fields("CallLogID").Value, -1, true, true)
    //        mintDurationMinutes = .Fields("DurationMinutes").Value
    //        mstrInternalOrExternal = .Fields("InternalOrExternal").Value
    //    End If
    //End With
}

        public DataTable GetActivityList(string pstrClientCode, string pstrDeveloperCode, DateTime pdtmFromDate, DateTime pdtmToDate, string pstrInternalOrExternal, string pstrTaskType){
    
            string strSQL;
            DataTable dtActivityList;

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
            if (pstrClientCode == null)
            {
                strSQL = strSQL + " AND AL.fkClientCode = '" + pstrClientCode + "' ";
            }
            
            // Only filter by developer if a developer was specified.
            if (pstrClientCode == null)
            {
                strSQL = strSQL + " AND AL.fkDeveloperCode = '" + pstrDeveloperCode + "' ";
            }

            dtActivityList = Database.Query(strSQL);

            return dtActivityList;
        }

        public DataTable GetFilteredDevelopmentActivities(DateTime pdtmFromDate, DateTime pdtmToDate){
    
            string strSQL;
            DataTable dtFilteredDevelopmentActivites;
    
            // Get filtered activity log list from DB.
            strSQL = "SELECT CallLogID, fkDeveloperCode, OpenItemID, StartDateTime, EndDateTime, " +
                    "       voidject, Description, fkActivityCode, DurationMinutes " +
                    "  FROM ActivityLog " +
                    " WHERE StartDateTime BETWEEN '" + pdtmFromDate + "' AND '" + pdtmToDate + "' " +
                    "       AND InternalOrExternal = 'INTERNAL' ";
    
            dtFilteredDevelopmentActivites = Database.Query(strSQL);

            return dtFilteredDevelopmentActivites;

        }

        public void NewActivity(){
    
            string strSQL;
    
            if (mdtActivityLog != null){
                mdtActivityLog = null;
            }
    
            strSQL = "SELECT CallLogID, StartDateTime, EndDateTime, voidject, Description, " +
                    "       fkClaimsUserCode, fkClientCode, fkDeveloperCode, fkTaskID, fkActivityCode, " +
                    "       DurationMinutes, InternalOrExternal, OpenItemID " +
                    " FROM ActivityLog " +
                    " WHERE 1=2 ";
    
            mdtActivityLog = Database.Query(strSQL);
    
            mintOpenItemID = 0;
            mdtmStartDateTime = DateTime.Now;
            mdtmEndDateTime = DateTime.Now;
            mstrvoidject = null;
            mstrDesription = null;
            mstrfkClaimsUserCode = null;
            mstrfkClientCode = null;
            mstrfkDeveloperCode = null;
            mstrfkActivityCode = null;
            mintfkTaskID = -1;
            mintCallLogID = -1;
            mintDurationMinutes = 0;
    
        }

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

        public DataTable GetActivitiesByDeveloperAndDate(string pstrDeveloperCode, DateTime pdtmStartDateTime, DateTime pdtmEndDateTime){
                                                
            string strSQL;
            DataTable dtActivities;
    
            strSQL = "SELECT C.ClientName, " +
                        "CU.ClaimsUserCode, " +
                        "AL.StartDateTime, " +
                        "AL.EndDateTime, " +
                        "Al.voidject, " +
                        "AL.Description " +
                    "FROM ActivityLog AS AL " +
                        "LEFT OUTER JOIN Client AS C ON C.ClientCode = AL.fkClientCode " +
                        "LEFT OUTER JOIN ClaimsUser AS CU ON CU.ClaimsUserCode = AL.fkClaimsUserCode " +
                            "AND CU.fkClientCode = AL.fkClientCode " +
                    "WHERE AL.fkDeveloperCode = '" + pstrDeveloperCode + "' " +
                        "AND AL.StartDateTime >= '" + pdtmStartDateTime + " 1:00 AM' " +
                        "AND AL.EndDateTime <= '" + pdtmEndDateTime + " 11:59:59 PM'";
    
            dtActivities = Database.Query(strSQL);
        
            return dtActivities;
        }

////----------------------------------------------------------------------------------------------
////                                      private PROCEDURES
////----------------------------------------------------------------------------------------------

        private string GetInternalOrExternal(string pstrActivityCode){
            string strInternalOrExternal;

            //With mdtactivitycodes .Find "ActivityCode = '" & pstrActivityCode & "'", , , adBookmarkFirst

            return strInternalOrExternal;
        }

    }
}

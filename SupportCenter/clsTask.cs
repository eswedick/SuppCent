using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportCenter
{
    class clsTask
    {

        const int mc_intMinMinutesToCharge = 5;
        const int mc_intRoundToIncrement = 15;

        private int mintMinutes;
        private int mintTaskID;
        private DateTime mdatTaskDate;
        private string mstrfkDeveloperCode;
        private string mstrfkClientCode;
        private string mstrfkClaimsUserCode; 
        private string mstrIssue;           
        private string mstrTaskType;        
        private DataTable mdtActivityList;     
        private DataTable mdtTask;            

        ////----------------------------------------------------------------------------------------------
        ////                                          PROPERTIES
        ////----------------------------------------------------------------------------------------------

        public DataTable ActivityList{
            get{
                return mdtActivityList;
            }
        }

        public string TaskType{
            get{
                return mstrTaskType;
            }
            set{
                mstrTaskType = value;
            }
        }

        public int Minutes{
            get{
                return mintMinutes;
            }
            set{
                mintMinutes = value;
            }
        }
        
        public string Issue{
            get{
                return mstrIssue;
            }
            set{
                mstrIssue = value;
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
        
        public string fkClientCode{
            get{
                return mstrfkClientCode;    
            }
            set{
                mstrfkClientCode = value;
            }
        }

        public DateTime TaskDate{
            get{
                return mdatTaskDate;
            }    
            set{
                mdatTaskDate = value;
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

        //----------------------*
        // READ-ONLY PROPERTIES *
        //----------------------*
        public int TaskID{
            get{
                return mintTaskID;
            }
        }

        public int ActivityMinutes
        {
            get
            {
                int intActivityMinutes = 0;
                foreach (DataRow row in mdtActivityList.Rows)
                {
                    int minutes = int.Parse(row["DurationMinutes"].ToString());
                    intActivityMinutes += minutes;
                }

                return intActivityMinutes;
            }
        }

        ////----------------------------------------------------------------------------------------------
        ////                                            EVENTS
        ////----------------------------------------------------------------------------------------------

        //private Sub Class_Initialize()
    
        //    Set mdtTask = New ADODB.Recordset
        //    Set mdtActivityList = New ADODB.Recordset

        //}

        //private Sub Class_Terminate()
    
        //    On Error Resume Next
    
        //    Set mdtTask = Nothing
        //    Set mdtActivityList = Nothing

        //}

        //----------------------------------------------------------------------------------------------
        //                                       public PROCEDURES
        //----------------------------------------------------------------------------------------------

        public void DeleteTask(int pintTaskID){

            string strSQL;
    
            strSQL = "DELETE FROM Task WHERE TaskID = '" + pintTaskID + "' ";
        
            //gobjConnection.Connection.Execute strSQL

        }

        public void EditTask(int pintTaskID){
            
            string strSQL;
            DataRow drTaskRow;
    
            if (mdtTask != null){
                mdtTask = null;
            }
    
            //TODO rewrite as one query

            // Get the task from the db
            strSQL = "SELECT TaskID, fkDeveloperCode, TaskDate, fkClientCode, fkClaimsUserCode, " +
                "       Issue, SupportMinutes, MaintenanceMinutes, TaskType, CreatedDateTime, " +
                "       CreatedUser, ModifiedDateTime, ModifiedUser " +
                "  FROM Task " +
                " WHERE TaskID = " + pintTaskID;
    
            //mdtTask.Open strSQL, gobjConnection.Connection, adOpenKeyset, adLockOptimistic, adCmdText
            
            // Get the activity log for the specified task from the DB.
            strSQL = "SELECT CallLogID, StartDateTime, EndDateTime, Subject, Description, " +
                "       fkClaimsUserCode, fkClientCode, fkDeveloperCode, fkTaskID, " +
                "       fkActivityCode, DurationMinutes, InternalOrExternal, OpenItemID " +
                "  FROM ActivityLog " +
                " WHERE fkTaskID = " + mintTaskID;

            //mdtActivityList.Open strSQL, gobjConnection.Connection, adOpenKeyset, adLockReadOnly

            if (mdtTask == null){
                mintTaskID = -1;
                mstrfkDeveloperCode = null;
                mdatTaskDate = DateTime.Today;
                mstrfkClientCode = null;
                mstrfkClaimsUserCode = null;
                mstrIssue = null;
                mintMinutes = 0;
                mstrTaskType = "SUPPORT";
            }
            else {
                drTaskRow = mdtTask[0];
                mintTaskID = .Fields("TaskID").Value;
                mstrfkDeveloperCode = .Fields("fkDeveloperCode").Value;
                mdatTaskDate = .Fields("TaskDate").Value;
                mstrfkClientCode = .Fields("fkClientCode").Value;
                mstrfkClaimsUserCode = .Fields("fkClaimsUserCode").Value;
                mstrIssue = .Fields("Issue").Value;
                mintMinutes = IfNull(.Fields("SupportMinutes").Value, 0) + IfNull(.Fields("MaintenanceMinutes").Value, 0);
            
                if (mdtTask[0]("TaskType").Value ?? 0 == 0){ 
                    if (mintMinutes < 1){
                        mstrTaskType = "MAINTENANCE";
                    }
                    else if (IfNull(.Fields("SupportMinutes").Value, 0) > 0){
                        mstrTaskType = "SUPPORT";
                    }
                    else{
                        mstrTaskType = "MAINTENANCE";
                    }
                }
            }
        }

        public int GetRoundedMinutes(int pintMinutes){

            GetRoundedMinutes = Round((pintMinutes / mc_intRoundToIncrement), 0) * mc_intRoundToIncrement

            if (GetRoundedMinutes < mc_intMinMinutesToCharge){
                GetRoundedMinutes = mc_intMinMinutesToCharge;
            }

        }

        public void NewTask(){
    
            string strSQL;
    
            if (mdtTask != null){
                mdtTask = null;
            }
    
            // Get list of tasks from the DB.
            strSQL = "SELECT TaskID, fkDeveloperCode, TaskDate, fkClientCode, fkClaimsUserCode, " +
                "       Issue, SupportMinutes, MaintenanceMinutes, TaskType, CreatedDateTime, " +
                "       CreatedUser, ModifiedDateTime, ModifiedUser " +
                "  FROM Task " +
                " WHERE 1=2";
    
            //mdtTask.Open strSQL, gobjConnection.Connection, adOpenKeyset, adLockOptimistic, adCmdText
    
            mintTaskID = -1
            mstrfkDeveloperCode = null
            mdatTaskDate = Date
            mstrfkClientCode = null
            mstrfkClaimsUserCode = null
            mstrIssue = null
            mintMinutes = 0
            mstrTaskType = "SUPPORT"
    
            // Get list of activity logs not associated with tasks from DB.
            strSQL = _
                "SELECT CallLogID, StartDateTime, EndDateTime, Subject, Description, "+
                "       fkClaimsUserCode, fkClientCode, fkDeveloperCode, fkTaskID, "+
                "       fkActivityCode, DurationMinutes, InternalOrExternal, OpenItemID "+
                "  FROM ActivityLog "+
                " WHERE fkTaskID = -1 "
    
            mdtActivityList.Open strSQL, gobjConnection.Connection, adOpenKeyset, adLockReadOnly
    
        }

        public bool Save(penuFormState As FormState){

            If penuFormState = jmaAddMode Then
                .AddNew
            End If
    
            .Fields("fkDeveloperCode").Value = mstrfkDeveloperCode
            .Fields("TaskDate").Value = mdatTaskDate
            .Fields("fkClientCode").Value = mstrfkClientCode
            .Fields("fkClaimsUserCode").Value = mstrfkClaimsUserCode
            .Fields("Issue").Value = mstrIssue
            .Fields("TaskType").Value = mstrTaskType
            If mstrTaskType = "SUPPORT" Then
                .Fields("SupportMinutes").Value = GetRoundedMinutes(mintMinutes)
                .Fields("MaintenanceMinutes").Value = 0
            else
                .Fields("SupportMinutes").Value = 0
                .Fields("MaintenanceMinutes").Value = GetRoundedMinutes(mintMinutes)
            End If
    
            .Update
            mintTaskID = .Fields("TaskID").Value

            return true;

        }

    }
}

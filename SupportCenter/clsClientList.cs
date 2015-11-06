using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportCenter
{
    class clsClientList
    {

        private string mstrCurrentClientName;
        private string mstrCurrentClientCode;
        private string mstrCurrentClientPrimaryUser;
        private string mstrCurrentClaimsUser;
        private DataTable mdtClientList;
        private DataTable mdtCurrentClientContactList;

        //public Event CurrentClientChanged(pstrCurrentClientCode )
        //public Event ClientListChanged()

        public string CurrentClaimsUser{
            get{
                return mstrCurrentClaimsUser;
            }
        }

        public string CurrentClientPrimaryUser{
            get{
                return mstrCurrentClientPrimaryUser;
            }
        }

        public string CurrentClientCode{
            get{
                return mstrCurrentClientCode;
            }
        }

        public string CurrentClientName{
            get{
                return mstrCurrentClientName;
            }
        }

        public DataTable CurrentClientContactList{
            get{
                return mdtCurrentClientContactList;
            }
        }

        public DataTable ClientList{
            get{
                return mdtClientList;
            }
        }

        //----------------------------------------------------------------------------------------------
        //                                            EVENTS
        //----------------------------------------------------------------------------------------------

        private void Class_Initialize(){

            string strSQL;
    
            // Get list of clients from DB.
            strSQL = "SELECT ClientCode, ClientName, PrimaryClaimsUserCode, InterfaceClaimsUserCode, " +
                "       RemoteAccessType, RemoteAccessAddress, SQLServerName, SQLServerIPAddress, " +
                "       TerminalServerName, TerminalServerIPAddress, Notes, CreatedDateTime, " +
                "       CreatedUser, ModifiedDateTime, ModifiedUser, Version, D.DeveloperName, fkPrimaryContactDeveloper, fkTechnicalContact " +
                "  FROM Client " +
                "   LEFT OUTER JOIN Developer AS D ON D.DeveloperCode = fkPrimaryContactDeveloper " +
                " WHERE 1=2 ";
    
            //Set mrstClientList = New ADODB.Recordset
            //mrstClientList.Open strSQL, gobjConnection.Connection, adOpenKeyset, adLockOptimistic, adCmdText
        
            // Get list of CLAIMS users from DB.
            strSQL = "SELECT ClaimsUserCode, ClaimsUser, fkClientCode, PhoneNumber, FaxNumber, " +
                "       EMailAddress, CreatedDateTime, CreatedUser, ModifiedDateTime, ModifiedUser " +
                "  FROM ClaimsUser " +
                " WHERE 1=2 ";
    
            //Set mrstCurrentClientContactList = New ADODB.Recordset
            //mrstCurrentClientContactList.Open strSQL, gobjConnection.Connection, adOpenKeyset, adLockOptimistic
    
        }

        private void Class_Terminate(){
    
            //mrstClientList = null;
            //mrstCurrentClientContactList = null;

        }

        //----------------------------------------------------------------------------------------------
        //                                       public PROCEDURES
        //----------------------------------------------------------------------------------------------

        public string ClientCodeFromName(string pstrClientName){
        
            DataRow[] drResults;
            DataRow drRow;
            drResults = mdtClientList.Select("ClientName LIKE '" + pstrClientName + "'");

            if (drResults != null){
                drRow = drResults[0];
                return drRow["ClientCode"].ToString();      
            } else{
                return null;
            }
        }

        public void ConfigureClientCombo(bool pblnIncludeAllAsChoice = true){

            //int intColPosition;
            //string strSeparator;
            //string strNewRow;

            //With pcboClient
            //    .DataMode = ssDataModeAddItem
            //    .BackColorEven = &HFFFFFF
            //    .BackColorOdd = &HC0FFFF
            //    .ForeColorEven = &H0&
            //    .ForeColorOdd = &H0&
        
            //    .Columns.RemoveAll
            //    intColPosition = 0
            //    .Columns(intColPosition).Name = "ClientCode"
            //    .Columns(intColPosition).Caption = "Client Code"
            //    .Columns(intColPosition).DataType = vbString
            //    intColPosition = intColPosition + 1
        
            //    .Columns(intColPosition).Name = "ClientName"
            //    .Columns(intColPosition).Caption = "Client Name"
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
            //    strNewRow = vbNullString +
            //                strSeparator +
            //                "All"
                    
            //    pcboClient.AddItem (strNewRow)
            //End If
    
            //With mrstClientList
        
            //    If Not (.BOF And .EOF) Then
            
            //        .MoveFirst
            //        Do Until .EOF
            //            strNewRow = .Fields("ClientCode").Value +
            //                        strSeparator +
            //                        .Fields("ClientName").Value
                
            //            pcboClient.AddItem (strNewRow)
                
            //            .MoveNext
            //        Loop
            //    End If
            //    pcboClient.MoveFirst
    
            //End With


        }

        public void ConfigureClaimsUserCombo(bool pblnIncludeAllAsChoice = true){
    
            //Dim intColPosition As Integer
            //Dim strSeparator   
            //Dim strNewRow      

            //With pcboClaimsUser
            //    .DataMode = ssDataModeAddItem
            //    .BackColorEven = &HFFFFFF
            //    .BackColorOdd = &HC0FFFF
            //    .ForeColorEven = &H0&
            //    .ForeColorOdd = &H0&
        
            //    .Columns.RemoveAll
        
            //    intColPosition = 0
            //    .Columns(intColPosition).Name = "fkClientCode"
            //    .Columns(intColPosition).Caption = "Client Code"
            //    .Columns(intColPosition).DataType = vbString
            //    intColPosition = intColPosition + 1
        
            //    .Columns(intColPosition).Name = "ClaimsUserCode"
            //    .Columns(intColPosition).Caption = "User Code"
            //    .Columns(intColPosition).DataType = vbString
            //    intColPosition = intColPosition + 1
            
            //    .Columns(intColPosition).Name = "ClaimsUserName"
            //    .Columns(intColPosition).Caption = "User Name"
            //    .Columns(intColPosition).DataType = vbString
            //    intColPosition = intColPosition + 1
            
            //    .Columns(intColPosition).Name = "PhoneNumber"
            //    .Columns(intColPosition).Caption = "Phone"
            //    .Columns(intColPosition).DataType = vbString
            //    intColPosition = intColPosition + 1
        
            //    .Columns(intColPosition).Name = "FaxNumber"
            //    .Columns(intColPosition).Caption = "Fax"
            //    .Columns(intColPosition).DataType = vbString
            //    intColPosition = intColPosition + 1
            
            //    .Columns(intColPosition).Name = "EmailAddress"
            //    .Columns(intColPosition).Caption = "Email"
            //    .Columns(intColPosition).DataType = vbString
            //    intColPosition = intColPosition + 1
    
            //    .FieldSeparator = ";"
            //    strSeparator = .FieldSeparator
            //    .DataFieldList = "Column 1"
            //    .DataFieldToDisplay = "Column 2"
            //    .RemoveAll
            //    .Text = vbNullString
            //End With
     
            //If pblnIncludeAllAsChoice Then
            //    strNewRow = vbNullString +
            //                strSeparator +
            //                "All"
                    
            //    pcboClaimsUser.AddItem (strNewRow)
            //End If
    
            //With mrstCurrentClientContactList
            //    If Not (.BOF And .EOF) Then
            //        .MoveFirst
            //        Do Until .EOF
            //            strNewRow = .Fields("fkClientCode").Value & strSeparator +
            //                        .Fields("ClaimsUserCode").Value & strSeparator +
            //                        .Fields("ClaimsUser").Value & strSeparator +
            //                        .Fields("PhoneNumber").Value & strSeparator +
            //                        .Fields("FaxNumber").Value & strSeparator +
            //                        .Fields("EmailAddress").Value

            //            pcboClaimsUser.AddItem (strNewRow)
                
            //            .MoveNext
            //        Loop
            //    End If
            //    pcboClaimsUser.MoveFirst
            //End With

        }

        public void SetCurrentClaimsUser(string pstrClaimsUserCode){

            mstrCurrentClaimsUser = pstrClaimsUserCode;

        }

        public void FlagClientDataAsChanged(string pstrClientCode){

            //If mstrCurrentClientCode = pstrClientCode Then
            //    RaiseEvent CurrentClientChanged(mstrCurrentClientCode)
            //End If

        }

        public void GetClients(){
            string strSQL;

            if (mdtClientList != null){
                mdtClientList = null;
            }
    
            // Get list of clients from DB.
            strSQL = "SELECT ClientCode, ClientName, PrimaryClaimsUserCode, InterfaceClaimsUserCode, " +
                "       RemoteAccessType, RemoteAccessAddress, SQLServerName, SQLServerIPAddress, " +
                "       TerminalServerName, TerminalServerIPAddress, Notes, CreatedDateTime, " +
                "       CreatedUser, ModifiedDateTime, ModifiedUser, Version, D.DeveloperName, fkTechnicalContact, fkPrimaryContactDeveloper " +
                "  FROM Client " +
                "   LEFT OUTER JOIN Developer AS D ON D.DeveloperCode = fkPrimaryContactDeveloper " +
                "  WHERE Active = 1";

            // fill datatable
    
        }


        public void ReloadClients(){

            //Dim strSQL 

            //If mrstClientList.State = adStateOpen Then mrstClientList.Close
    
            //// Get list of clients from DB.
            //strSQL = _
            //    "SELECT ClientCode, ClientName, PrimaryClaimsUserCode, InterfaceClaimsUserCode, " +
            //    "       RemoteAccessType, RemoteAccessAddress, SQLServerName, SQLServerIPAddress, " +
            //    "       TerminalServerName, TerminalServerIPAddress, Notes, CreatedDateTime, " +
            //    "       CreatedUser, ModifiedDateTime, ModifiedUser, Version, D.DeveloperName, fkTechnicalContact, fkPrimaryContactDeveloper " +
            //    "  FROM Client " +
            //    "   LEFT OUTER JOIN Developer AS D ON D.DeveloperCode = fkPrimaryContactDeveloper " +
            //    "  WHERE Active = 1"

            //mrstClientList.Open strSQL, gobjConnection.Connection, _
            //    adOpenKeyset, adLockOptimistic, adCmdText
    
            //RaiseEvent ClientListChanged

        }


        public void SetCurrentClient(string pstrCurrentClientCode){
    
            string strSQL;
    
            DataRow[] drResults;
            DataRow drRow;

            //get client row
            drResults = mdtClientList.Select("ClientCode LIKE '" + pstrCurrentClientCode + "'");

            if (drResults != null){
                mdtCurrentClientContactList = null;

                // get Current Client Contact List
                strSQL = "spGetClientContactList " + "'" + pstrCurrentClientCode + "'";
                mdtCurrentClientContactList = Database.Query(strSQL);

                // get property strings
                drRow = drResults[0]; 
                mstrCurrentClientName = drRow["ClientName"].ToString();
                mstrCurrentClientCode = drRow["ClientCode"].ToString();
                mstrCurrentClientPrimaryUser = drRow["PrimaryClaimsUserCode"].ToString() ?? null;

            } else {
                mstrCurrentClientName = null;
                mstrCurrentClientCode = null;
                mstrCurrentClientPrimaryUser = null;
            }     

        }

        public string GetCurrentProductionVersion(){

            string strSQL;
            DataTable dtCurrentVersion;
    
            strSQL = "SELECT LatestVersionNumber FROM Project";
    
            // execute query



            //get latest version
            //return row["LatestVersion"].ToString();
            return "";
    
        }

        public bool NewVersionAvailable(string pstrLatestVersion, string pstrClientVersion, int pintMinMajorVersionDifference = 1, int pintMinMinorVersionDifference = 1, int pintMinRevisionVersionDifference = 1){
    
            int intProductionSegment; 
            int intClientSegment; 
            string strProductionRestOfString ;
            string strClientRestOfString;
    
            //check major version
            intProductionSegment = 0;
            intClientSegment = 1;
    
            if (intProductionSegment >= intClientSegment + pintMinMajorVersionDifference){
                return true;
            }
    
            //strProductionRestOfString = Mid$(pstrLatestVersion, InStr(pstrLatestVersion, ".") + 1, 999) & "..";  //appending .. so that following functions will work
            //strClientRestOfString = Mid$(pstrClientVersion, InStr(pstrClientVersion, ".") + 1, 999) & ".."   ;   //appending .. so that following functions will work
    
            //check minor version
            //intProductionSegment = Val(Mid$(strProductionRestOfString, 1, InStr(strProductionRestOfString, ".")));
            //intClientSegment = Val(Mid$(strClientRestOfString, 1, InStr(strClientRestOfString, ".")));
    
            if (intProductionSegment >= intClientSegment + pintMinMinorVersionDifference){
                return true;
            }
    
            //strProductionRestOfString = Mid$(strProductionRestOfString, InStr(strProductionRestOfString, "."), 999);
            //strClientRestOfString = Mid$(strClientRestOfString, InStr(strClientRestOfString, "."));
    
            //check revision version
            //intProductionSegment = Val(Mid$(strProductionRestOfString, 1, InStr(strProductionRestOfString, ".")));
            //intClientSegment = Val(Mid$(strClientRestOfString, 1, InStr(strClientRestOfString, ".")));
    
            if (intProductionSegment >= intClientSegment + pintMinRevisionVersionDifference){
                return true;
            }
    
            //strProductionRestOfString = Mid$(pstrLatestVersion, InStr(pstrLatestVersion, "."), 999);
            //strClientRestOfString = Mid$(pstrClientVersion, InStr(pstrClientVersion, "."));
    
            //no problem!
            return false;


        }


    }
}

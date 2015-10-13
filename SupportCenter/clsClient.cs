using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportCenter
{
    class clsClient
    {
        private string mstrClientCode;             
        private string mstrClientName;             
        private string mstrPrimaryClaimsUserCode;  
        private string mstrIntefaceClaimsUserCode; 
        private string mstrRemoteAccessType;       
        private string mstrRemoteAccessAddress;    
        private string mstrSQLServerName;          
        private string mstrSQLServerAddress;       
        private string mstrTerminalServerName;     
        private string mstrTerminalServerAddress;  
        private string mstrNotes;                  

        private string mstrVersion; 
        private string mstrfkPrimaryContactDeveloper;
        private string mstrfkTechnicalContact; 
        private string mstrDomainLogin; 
        private string mstrDomainPassword; 
        private string mstrVPNAddress; 
        private string mstrVPNLogin; 
        private string mstrVPNPassword; 
        private string mstrTerminalServerLogin; 
        private string mstrTerminalServerPassword; 
        private string mstrWebConnectionAddress; 
        private string mstrWebConnectionLogin;
        private string mstrWebConnectionPassword; 
        private string mstrSQLServerLogin;
        private string mstrSQLServerPassword;

        private DataTable mdtClient;
        private DataTable mdtUserList;
        private DataTable mdtIssues;

        // Properties

        public string SQLServerPassword{
            get{
                return mstrSQLServerPassword;
            }
            set{
                mstrSQLServerPassword = value;
            }
        } 

        public string SQLServerLogin{
            get{
                return mstrSQLServerLogin;
            }
            set {
                mstrSQLServerLogin = value;
            }
        }

        public string WebConnectionPassword{
            get {
                return mstrWebConnectionPassword;
            }
            set {
                mstrWebConnectionPassword = value;
            }
        } 

        public string WebConnectionLogin{
            get{
                return mstrWebConnectionLogin;
            }
            set {
                mstrWebConnectionLogin = value;
            }
        } 

        public string WebConnectionAddress{
            get {
                return mstrWebConnectionAddress;
            }
            set {
                mstrWebConnectionAddress = value;
            }
        } 

        public string TerminalServerPassword{
            get{
                return mstrTerminalServerPassword;
            }
            set{
                mstrTerminalServerPassword = value;
            }
        } 

        public string TerminalServerLogin{
            get{
                return mstrTerminalServerLogin;
            }
            set{
                mstrTerminalServerLogin = value;
            }
        } 

        public string VPNPassword{
            get{
                return mstrVPNPassword;
            }
            set{
                mstrVPNPassword = value;
            }
        } 

        public string VPNLogin{
            get{
                return mstrVPNLogin;
            }
            set {
                mstrVPNLogin = value;
            }
        } 

        public string VPNAddress{
            get{
                return mstrVPNAddress;
            }
            set{
                mstrVPNAddress = value;
            }
        } 

        public string DomainPassword{
            get{
                return mstrDomainPassword;
            }
            set{
                mstrDomainPassword = value;
            }
        } 

        public string DomainLogin{
            get{
                return mstrDomainPassword;
            }
            set{
                mstrDomainPassword = value;
            }
        } 

        public string fkPrimaryContactDeveloper{
            get{
                return mstrfkPrimaryContactDeveloper;
            }
            set{
                mstrfkPrimaryContactDeveloper = value;
            }
        } 

        public string fkTechnicalContact{
            get{
                return mstrfkTechnicalContact;
            }
            set{
                mstrfkTechnicalContact = value;
            }
        } 


        public string Notes{
            get{
                return mstrNotes;
            }
            set{
                mstrNotes = value;
            }
        } 

        public string TerminalServerAddress{
            get{
                return mstrTerminalServerAddress;
            }
            set{
                mstrTerminalServerAddress = value;
            }
        } 

        public string TerminalServerName{
            get{
                return mstrTerminalServerName;
            }
            set {
                mstrTerminalServerName = value;
            }
        }

        public string SQLServerAddress{
            get{
                return mstrSQLServerAddress;
            }
            set{
                mstrSQLServerAddress = value;
            }
        } 

        public string SQLServerName{
            get{
                return mstrSQLServerName;
            }
            set{
                mstrSQLServerName = value;
            }
        } 

        public string RemoteAccessAddress{
            get{
                return mstrRemoteAccessAddress;
            }
            set{
                mstrRemoteAccessAddress = value;
            }
        } 

        public string RemoteAccessType{
            get{
                return mstrRemoteAccessType;
            }
            set{
                mstrRemoteAccessType = value;
            }
        } 

        public string IntefaceClaimsUserCode{
            get{
                return mstrIntefaceClaimsUserCode;
            }
            set{
                mstrIntefaceClaimsUserCode = value;
            }
        } 

        public string PrimaryClaimsUserCode{
            get{
                return mstrPrimaryClaimsUserCode;
            }
            set{
                mstrPrimaryClaimsUserCode = value;
            }
        } 

        public string ClientName{
            get{
                return mstrClientName;
            }
            set{
                mstrClientName = value;
            }
        } 

        public string ClientCode{
            get{
                return mstrClientCode;
            }
            set{
                mstrClientCode = value;
            }
        } 

        public string Version{
            get{
                return mstrVersion;
            }
            set{
                mstrVersion = value;
            }
        } 


//----------------------*
// READ-ONLY PROPERTIES *
//----------------------*
        //public string UserList() As ADODB.Recordset
        //Set UserList = mdtUserList


//public string Issues() As ADODB.Recordset
//    Set Issues = mrstIssues


//----------------------------------------------------------------------------------------------
//                                            EVENTS
//----------------------------------------------------------------------------------------------

//private voidClass_Initialize()
    
//    Set mdtClient = New ADODB.Recordset
//    Set mdtUserList = New ADODB.Recordset
//    Set mrstIssues = New ADODB.Recordset

//End Sub

//private voidClass_Terminate()

//    On Error Resume Next

//    Set mdtClient = Nothing
//    Set mdtUserList = Nothing

//End Sub


        //----------------------------------------------------------------------------------------------
        //                                       public PROCEDURES
        //----------------------------------------------------------------------------------------------

        public void NewClient(){
    
            string strSQL; 
    
            if (mdtClient == null){
                mdtClient = new DataTable();
            }
            
            //open db connection
            //mdtClient.Open strSQL, gobjConnection.Connection, adOpenKeyset, adLockBatchOptimistic;

            mstrClientCode = null;
            mstrClientName = null;
            mstrPrimaryClaimsUserCode = null;
            mstrIntefaceClaimsUserCode = null;
            mstrRemoteAccessType = null;
            mstrRemoteAccessAddress = null;
            mstrSQLServerName = null;
            mstrSQLServerAddress = null;
            mstrTerminalServerName = null;
            mstrTerminalServerAddress = null;
            mstrNotes = null;
            mstrfkPrimaryContactDeveloper = null;
            mstrfkTechnicalContact = null;
    
            GetClientUsers(null);
            GetClientIssues(null);
            
        }

        public void EditClient(string pstrClientCode){
    
            //Dim strSQL 
    
            //If mdtClient.State = adStateOpen Then mdtClient.Close
            //mdtClient.CursorLocation = adUseClient
    
            //strSQL = _
            //    "SELECT * " +
            //    "  FROM Client " +
            //    " WHERE ClientCode = '" & pstrClientCode & "'"
    
            //With mdtClient
            //    .Open strSQL, gobjConnection.Connection, adOpenKeyset, adLockBatchOptimistic, adCmdText
        
            //    If .EOF Then
            //        mstrClientCode = null
            //        mstrClientName = null
            //        mstrPrimaryClaimsUserCode = null
            //        mstrIntefaceClaimsUserCode = null
            //        mstrRemoteAccessType = null
            //        mstrRemoteAccessAddress = null
            //        mstrSQLServerName = null
            //        mstrSQLServerAddress = null
            //        mstrTerminalServerName = null
            //        mstrTerminalServerAddress = null
            //        mstrNotes = null
            //        mstrVersion = null
            //        mstrfkPrimaryContactDeveloper = null
            //        mstrfkTechnicalContact = null
            //        mstrDomainLogin = null
            //        mstrDomainPassword = null
            //        mstrVPNAddress = null
            //        mstrVPNLogin = null
            //        mstrVPNPassword = null
            //        mstrTerminalServerLogin = null
            //        mstrTerminalServerPassword = null
            //        mstrWebConnectionAddress = null
            //        mstrWebConnectionLogin = null
            //        mstrWebConnectionPassword = null
            //        mstrSQLServerLogin = null
            //        mstrSQLServerPassword = null
            //    Else
            //        mstrClientCode = .Fields("ClientCode").value
            //        mstrClientName = .Fields("ClientName").value
            //        mstrPrimaryClaimsUserCode = _
            //            IfNull(.Fields("PrimaryClaimsUserCode").value, null)
            //        mstrIntefaceClaimsUserCode = _
            //            IfNull(.Fields("InterfaceClaimsUserCode").value, null)
            //        mstrRemoteAccessType = IfNull(.Fields("RemoteAccessType").value, null)
            //        mstrRemoteAccessAddress = IfNull(.Fields("RemoteAccessAddress").value, null)
            //        mstrSQLServerName = IfNull(.Fields("SQLServerName").value, null)
            //        mstrSQLServerAddress = IfNull(.Fields("SQLServerIPAddress").value, null)
            //        mstrTerminalServerName = IfNull(.Fields("TerminalServerName").value, null)
            //        mstrTerminalServerAddress = _
            //            IfNull(.Fields("TerminalServerIPAddress").value, null)
            //        mstrNotes = IfNull(.Fields("Notes").value, null)
            //        mstrVersion = IfNull(.Fields("Version").value, null)
            //        mstrfkPrimaryContactDeveloper = IfNull(.Fields("fkPrimaryContactDeveloper").value, null)
            //        mstrfkTechnicalContact = IfNull(.Fields("fkTechnicalContact").value, null)
            //        mstrDomainLogin = IfNull(.Fields("DomainLogin").value, null)
            //        mstrDomainPassword = IfNull(.Fields("DomainPassword").value, null)
            //        mstrVPNAddress = IfNull(.Fields("VPNAddress").value, null)
            //        mstrVPNLogin = IfNull(.Fields("VPNLogin").value, null)
            //        mstrVPNPassword = IfNull(.Fields("VPNPassword").value, null)
            //        mstrTerminalServerLogin = IfNull(.Fields("TerminalServerLogin").value, null)
            //        mstrTerminalServerPassword = IfNull(.Fields("TerminalServerPassword").value, null)
            //        mstrWebConnectionAddress = IfNull(.Fields("WebConnectionAddress").value, null)
            //        mstrWebConnectionLogin = IfNull(.Fields("WebConnectionLogin").value, null)
            //        mstrWebConnectionPassword = IfNull(.Fields("WebConnectionPassword").value, null)
            //        mstrSQLServerLogin = IfNull(.Fields("SQLServerLogin").value, null)
            //        mstrSQLServerPassword = IfNull(.Fields("SQLServerPassword").value, null)
            //    End If
            //End With
    
            //GetClientUsers pstrClientCode
            //GetClientIssues pstrClientCode

            }

        public void GetClientUsers(string pstrClientCode){
    
            string strSQL; 
    
            strSQL = "SELECT ClaimsUserCode, ClaimsUser, fkClientCode, PhoneNumber, FaxNumber, " + 
                "       EMailAddress, CreatedDateTime, CreatedUser, ModifiedDateTime, ModifiedUser " +
                "  FROM ClaimsUser " + 
                " WHERE fkClientCode = '" + pstrClientCode + "'";
            
            if (mdtUserList.State == adStateOpen) {
                mdtUserList.Close;
            } else {
                mdtUserList.CursorLocation = adUseClient;
            }
            
    
            mdtUserList.Open strSQL, gobjConnection.Connection, _
                adOpenKeyset, adLockBatchOptimistic, adCmdText

        }

        public void GetClientIssues(string pstrClientCode , bool pblnUnresolvedIssuesOnly = false){
            //Dim strSQL 
    
            //strSQL = _
            //    "SELECT IssueID, " +
            //            "fkClientCode, " +
            //            "IssuePriority , " +
            //            "IssueSubject, " +
            //            "IssueDescription, " +
            //            "ProgressNotes, " +
            //            "fkAssignedToDeveloper, " +
            //            "IssueOpenDate, " +
            //            "TargetCompletionDate, " +
            //            "CompletedDate, " +
            //            "fkAddedByDeveloper " +
            //    "FROM ClientIssue " +
            //    "WHERE fkClientCode = '" & pstrClientCode & "' "

    
            //If pblnUnresolvedIssuesOnly Then
            //    strSQL = strSQL & " AND CompletedDate IS NULL "
            //End If
    
            //strSQL = strSQL & "ORDER BY IssuePriority ASC"
    
            //If mrstIssues.State = adStateOpen Then mrstIssues.Close
            //mrstIssues.CursorLocation = adUseClient
    
            //mrstIssues.Open strSQL, gobjConnection.Connection, _
            //    adOpenKeyset, adLockBatchOptimistic, adCmdText
        }

        public bool Save(){

        //    On Error GoTo PROC_ERROR

        //    Const c_strSource  = "SupportCenter.clsClient.Save"

        //    Save = False
        //    With mdtClient
        
        //        If .EOF Then
        //            .AddNew
        //            .Fields("CreatedDateTime").value = Now
        //            .Fields("CreatedUser").value = gstrDeveloperCode
        //        End If
    
        //        .Fields("ClientCode").value = mstrClientCode
        //        .Fields("ClientName").value = mstrClientName
        //        .Fields("PrimaryClaimsUserCode").value = _
        //            IIf(mstrPrimaryClaimsUserCode = null, Null, mstrPrimaryClaimsUserCode)
        //        .Fields("InterfaceClaimsUserCode").value = _
        //            IIf(mstrIntefaceClaimsUserCode = null, Null, mstrIntefaceClaimsUserCode)
        //        .Fields("RemoteAccessType").value = mstrRemoteAccessType
        //        .Fields("RemoteAccessAddress").value = mstrRemoteAccessAddress
        //        .Fields("SQLServerName").value = mstrSQLServerName
        //        .Fields("SQLServerIPAddress").value = mstrSQLServerAddress
        //        .Fields("TerminalServerName").value = mstrTerminalServerName
        //        .Fields("TerminalServerIPAddress").value = mstrTerminalServerAddress
        //        .Fields("Notes").value = mstrNotes
        //        .Fields("ModifiedDateTime").value = Now
        //        .Fields("ModifiedUser").value = gstrDeveloperCode
        //        .Fields("Version").value = mstrVersion
        //        .Fields("fkPrimaryContactDeveloper").value = mstrfkPrimaryContactDeveloper
        //        .Fields("fkTechnicalContact").value = mstrfkTechnicalContact
        //        .Fields("DomainLogin").value = mstrDomainLogin
        //        .Fields("DomainPassword").value = mstrDomainPassword
        //        .Fields("VPNAddress").value = mstrVPNAddress
        //        .Fields("VPNLogin").value = mstrVPNLogin
        //        .Fields("VPNPassword").value = mstrVPNPassword
        //        .Fields("TerminalServerLogin").value = mstrTerminalServerLogin
        //        .Fields("TerminalServerPassword").value = mstrTerminalServerPassword
        //        .Fields("WebConnectionAddress").value = mstrWebConnectionAddress
        //        .Fields("WebConnectionLogin").value = mstrWebConnectionLogin
        //        .Fields("WebConnectionPassword").value = mstrWebConnectionPassword
        //        .Fields("SQLServerLogin").value = mstrSQLServerLogin
        //        .Fields("SQLServerPassword").value = mstrSQLServerPassword
    
        //        .UpdateBatch
        
        //    End With
    
        //    With mdtUserList
        //        If .RecordCount > 0 Then
        //            .MoveFirst
        //            Do Until .EOF
        //                If IsNull(.Fields("fkClientCode").value) Then
        //                    .Fields("fkClientCode").value = mstrClientCode
        //                End If
        //                Select Case .Status
        //                    Case adRecModified
        //'x                        MsgBox .Fields("ClaimsUserCode") & " is changed"
        //                    Case adRecUnmodified
        //'x                        MsgBox .Fields("ClaimsUserCode") & " is unchanged"
        //                    Case adRecNew
        //                        .Fields("fkClientCode").value = mstrClientCode
        //                        .Fields("CreatedDateTime").value = Now
        //                        .Fields("CreatedUser").value = gstrDeveloperCode
        //                        .Fields("ModifiededDateTime").value = Now
        //                        .Fields("ModifiedUser").value = gstrDeveloperCode
        //                    Case Else
        //                        .Fields("ModifiededDateTime").value = Now
        //                        .Fields("ModifiedUser").value = gstrDeveloperCode
        //                End Select
    
        //                .MoveNext
        //            Loop
        //        End If
    
    
        //        .UpdateBatch
        //    End With
        //    Save = True

        //PROC_EXIT:

        //    Exit Function

        //PROC_ERROR:

        //    Call ErrorHandler(c_strSource)
        //    GoTo PROC_EXIT
            return true;
        }

        //----------------------------------------------------------------------------------------------
        //     Project:    SupportCenter
        //   Procedure:    NewClientUser
        // Description:    Add a new user to the specified client.
        //  Created By:    Evan Swedick - 10/13/2015
        //
        //  Parameters:    pstrUserName (String)
        //                 pstrClientCode (String)
        //----------------------------------------------------------------------------------------------
        public void NewClientUser(string pstrUserCode, string pstrUserName){

            string strSQL;
    
            strSQL = "INSERT INTO ClaimsUser( ClaimsUserCode, ClaimsUser, fkClientCode, " +
                "                        CreatedDateTime, CreatedUser, ModifiedDateTime, " +
                "                        ModifiedUser ) " +
                "  valueS( '" + pstrUserCode + "', '" + pstrUserName + "', " +
                "          '" + mstrClientCode + "', '" + DateTime.Now + "', '" + gstrDeveloperCode + "', " +
                "          '" + DateTime.Now + "', '" + gstrDeveloperCode + "' ) ";
        
            //gobjConnection.Connection.Execute strSQL

        }

        public string GetTopClientIssues(string pstrClientCode){ 
    
        //    Dim strSQL 
        //    Dim strClientIssues 
    
        //    strSQL = "SELECT dbo.fnGetTop3IssuesForClient('" & pstrClientCode & "') AS TopIssues"
        //    strClientIssues = gobjConnection.Connection.Execute(strSQL)!TopIssues
    
        //    If Len(strClientIssues) > 0 Then
        //        strClientIssues = Mid$(strClientIssues, 1, Len(strClientIssues) - 2)
        //    End If
    
        //    GetTopClientIssues = strClientIssues
    

        //PROC_EXIT:
        //    Exit Function
        //PROC_ERROR:
        //    Call ErrorHandler(c_strSource)
        //    GoTo PROC_EXIT
            return "";
        }

        public string GetAllClientIssues(string pstrClientCode){ 

    
        //    Dim strSQL 
        //    Dim strClientIssues 
    
        //    strSQL = "SELECT dbo.fnGetAllOpenIssuesForClient('" & pstrClientCode & "') AS TopIssues"
        //    strClientIssues = gobjConnection.Connection.Execute(strSQL)!TopIssues
    
        //    If Len(strClientIssues) > 0 Then
        //        strClientIssues = Mid$(strClientIssues, 1, Len(strClientIssues) - 2)
        //    End If
    
        //    GetAllClientIssues = strClientIssues
    

        //PROC_EXIT:
        //    Exit Function
        //PROC_ERROR:
        //    Call ErrorHandler(c_strSource)
        //    GoTo PROC_EXIT
            return "";
        }

        public string GetLastCommunication(string pstrClientCode){ 
    
        //    Dim strSQL 
        //    Dim rstLastCommunication As ADODB.Recordset
        //    Set rstLastCommunication = New ADODB.Recordset
    
        //    strSQL = "SELECT TOP 1 CAST(DATEPART(yyyy, EndDateTime) as varchar(4)) + '-' " +
        //                    "+ RIGHT('0' + CAST(DATEPART(mm, EndDateTime) as varchar(2)), 2) + '-' " +
        //                    "+ RIGHT('0' + CAST(DATEPART(dd, EndDateTime) as varchar(2)), 2) + ' (' " +
        //                    "+ fkDeveloperCode + ')' AS LastCommunication " +
        //                "FROM ActivityLog " +
        //                "WHERE fkClientCode = '" & pstrClientCode & "' " +
        //                "ORDER BY CAST(DATEPART(yyyy, EndDateTime) as varchar(4)) + '-' " +
        //                    "+ RIGHT('0' + CAST(DATEPART(mm, EndDateTime) as varchar(2)), 2)  + '-' " +
        //                    "+ RIGHT('0' + CAST(DATEPART(dd, EndDateTime) as varchar(2)), 2) DESC"
                    
        //    Call rstLastCommunication.Open(strSQL, gobjConnection.Connection)
    
        //    If Not (rstLastCommunication.EOF And rstLastCommunication.BOF) Then
        //        GetLastCommunication = rstLastCommunication!LastCommunication
        //    Else
        //        GetLastCommunication = null
        //    End If

        //
        //PROC_EXIT:
        //    Set rstLastCommunication = Nothing
        //    Exit Function
        //PROC_ERROR:
        //    Call ErrorHandler(c_strSource)
        //    GoTo PROC_EXIT
        //
            return "";
        }

        public string GetNumberOfOpenIssues(string pstrClientCode){
            //Dim strSQL 
    
            //strSQL = "SELECT COUNT(*) AS NumberOfOpenIssues " +
            //        "FROM ClientIssue " +
            //        "WHERE fkClientCode = '" & pstrClientCode & "' " +
            //            "AND CompletedDate IS NULL"
                
            //GetNumberOfOpenIssues = gobjConnection.Connection.Execute(strSQL)!NumberOfOpenIssues
            return "";
        }

    }
}

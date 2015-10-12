using System;
using System.Collections.Generic;
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
        //private mrstClient                 As ADODB.Recordset;
        //private mrstUserList               As ADODB.Recordset;
        //private mrstIssues                  As ADODB.Recordset;
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
//    Set UserList = mrstUserList


//public string Issues() As ADODB.Recordset
//    Set Issues = mrstIssues


//----------------------------------------------------------------------------------------------
//                                            EVENTS
//----------------------------------------------------------------------------------------------

//private voidClass_Initialize()
    
//    Set mrstClient = New ADODB.Recordset
//    Set mrstUserList = New ADODB.Recordset
//    Set mrstIssues = New ADODB.Recordset

//End Sub

//private voidClass_Terminate()

//    On Error Resume Next

//    Set mrstClient = Nothing
//    Set mrstUserList = Nothing

//End Sub


        //----------------------------------------------------------------------------------------------
        //                                       public PROCEDURES
        //----------------------------------------------------------------------------------------------

        public void NewClient(){
    
            //string strSQL; 
    
            //If mrstClient.State = adStateOpen Then mrstClient.Close
            //mrstClient.CursorLocation = adUseClient
    
            //strSQL = _
            //    "SELECT * " & _
            //    "  FROM Client " & _
            //    " WHERE 1=2"
    
            //mrstClient.Open strSQL, gobjConnection.Connection, adOpenKeyset, adLockBatchOptimistic
            //mstrClientCode = vbNullString
            //mstrClientName = vbNullString
            //mstrPrimaryClaimsUserCode = vbNullString
            //mstrIntefaceClaimsUserCode = vbNullString
            //mstrRemoteAccessType = vbNullString
            //mstrRemoteAccessAddress = vbNullString
            //mstrSQLServerName = vbNullString
            //mstrSQLServerAddress = vbNullString
            //mstrTerminalServerName = vbNullString
            //mstrTerminalServerAddress = vbNullString
            //mstrNotes = vbNullString
            //mstrfkPrimaryContactDeveloper = vbNullString
            //mstrfkTechnicalContact = vbNullString
    
            //GetClientUsers vbNullString
            //GetClientIssues vbNullString
            
        }

        public void EditClient(string pstrClientCode){
    
            //Dim strSQL 
    
            //If mrstClient.State = adStateOpen Then mrstClient.Close
            //mrstClient.CursorLocation = adUseClient
    
            //strSQL = _
            //    "SELECT * " & _
            //    "  FROM Client " & _
            //    " WHERE ClientCode = '" & pstrClientCode & "'"
    
            //With mrstClient
            //    .Open strSQL, gobjConnection.Connection, adOpenKeyset, adLockBatchOptimistic, adCmdText
        
            //    If .EOF Then
            //        mstrClientCode = vbNullString
            //        mstrClientName = vbNullString
            //        mstrPrimaryClaimsUserCode = vbNullString
            //        mstrIntefaceClaimsUserCode = vbNullString
            //        mstrRemoteAccessType = vbNullString
            //        mstrRemoteAccessAddress = vbNullString
            //        mstrSQLServerName = vbNullString
            //        mstrSQLServerAddress = vbNullString
            //        mstrTerminalServerName = vbNullString
            //        mstrTerminalServerAddress = vbNullString
            //        mstrNotes = vbNullString
            //        mstrVersion = vbNullString
            //        mstrfkPrimaryContactDeveloper = vbNullString
            //        mstrfkTechnicalContact = vbNullString
            //        mstrDomainLogin = vbNullString
            //        mstrDomainPassword = vbNullString
            //        mstrVPNAddress = vbNullString
            //        mstrVPNLogin = vbNullString
            //        mstrVPNPassword = vbNullString
            //        mstrTerminalServerLogin = vbNullString
            //        mstrTerminalServerPassword = vbNullString
            //        mstrWebConnectionAddress = vbNullString
            //        mstrWebConnectionLogin = vbNullString
            //        mstrWebConnectionPassword = vbNullString
            //        mstrSQLServerLogin = vbNullString
            //        mstrSQLServerPassword = vbNullString
            //    Else
            //        mstrClientCode = .Fields("ClientCode").value
            //        mstrClientName = .Fields("ClientName").value
            //        mstrPrimaryClaimsUserCode = _
            //            IfNull(.Fields("PrimaryClaimsUserCode").value, vbNullString)
            //        mstrIntefaceClaimsUserCode = _
            //            IfNull(.Fields("InterfaceClaimsUserCode").value, vbNullString)
            //        mstrRemoteAccessType = IfNull(.Fields("RemoteAccessType").value, vbNullString)
            //        mstrRemoteAccessAddress = IfNull(.Fields("RemoteAccessAddress").value, vbNullString)
            //        mstrSQLServerName = IfNull(.Fields("SQLServerName").value, vbNullString)
            //        mstrSQLServerAddress = IfNull(.Fields("SQLServerIPAddress").value, vbNullString)
            //        mstrTerminalServerName = IfNull(.Fields("TerminalServerName").value, vbNullString)
            //        mstrTerminalServerAddress = _
            //            IfNull(.Fields("TerminalServerIPAddress").value, vbNullString)
            //        mstrNotes = IfNull(.Fields("Notes").value, vbNullString)
            //        mstrVersion = IfNull(.Fields("Version").value, vbNullString)
            //        mstrfkPrimaryContactDeveloper = IfNull(.Fields("fkPrimaryContactDeveloper").value, vbNullString)
            //        mstrfkTechnicalContact = IfNull(.Fields("fkTechnicalContact").value, vbNullString)
            //        mstrDomainLogin = IfNull(.Fields("DomainLogin").value, vbNullString)
            //        mstrDomainPassword = IfNull(.Fields("DomainPassword").value, vbNullString)
            //        mstrVPNAddress = IfNull(.Fields("VPNAddress").value, vbNullString)
            //        mstrVPNLogin = IfNull(.Fields("VPNLogin").value, vbNullString)
            //        mstrVPNPassword = IfNull(.Fields("VPNPassword").value, vbNullString)
            //        mstrTerminalServerLogin = IfNull(.Fields("TerminalServerLogin").value, vbNullString)
            //        mstrTerminalServerPassword = IfNull(.Fields("TerminalServerPassword").value, vbNullString)
            //        mstrWebConnectionAddress = IfNull(.Fields("WebConnectionAddress").value, vbNullString)
            //        mstrWebConnectionLogin = IfNull(.Fields("WebConnectionLogin").value, vbNullString)
            //        mstrWebConnectionPassword = IfNull(.Fields("WebConnectionPassword").value, vbNullString)
            //        mstrSQLServerLogin = IfNull(.Fields("SQLServerLogin").value, vbNullString)
            //        mstrSQLServerPassword = IfNull(.Fields("SQLServerPassword").value, vbNullString)
            //    End If
            //End With
    
            //GetClientUsers pstrClientCode
            //GetClientIssues pstrClientCode

            }

        public void GetClientUsers(string pstrClientCode){
    
            //Dim strSQL 
    
            //strSQL = _
            //    "SELECT ClaimsUserCode, ClaimsUser, fkClientCode, PhoneNumber, FaxNumber, " & _
            //    "       EMailAddress, CreatedDateTime, CreatedUser, ModifiedDateTime, ModifiedUser " & _
            //    "  FROM ClaimsUser " & _
            //    " WHERE fkClientCode = '" & pstrClientCode & "'"
            
            //If mrstUserList.State = adStateOpen Then mrstUserList.Close
            //mrstUserList.CursorLocation = adUseClient
    
            //mrstUserList.Open strSQL, gobjConnection.Connection, _
            //    adOpenKeyset, adLockBatchOptimistic, adCmdText

        }

        public void GetClientIssues(string pstrClientCode , bool pblnUnresolvedIssuesOnly = false){
            //Dim strSQL 
    
            //strSQL = _
            //    "SELECT IssueID, " & _
            //            "fkClientCode, " & _
            //            "IssuePriority , " & _
            //            "IssueSubject, " & _
            //            "IssueDescription, " & _
            //            "ProgressNotes, " & _
            //            "fkAssignedToDeveloper, " & _
            //            "IssueOpenDate, " & _
            //            "TargetCompletionDate, " & _
            //            "CompletedDate, " & _
            //            "fkAddedByDeveloper " & _
            //    "FROM ClientIssue " & _
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
        //    With mrstClient
        
        //        If .EOF Then
        //            .AddNew
        //            .Fields("CreatedDateTime").value = Now
        //            .Fields("CreatedUser").value = gstrDeveloperCode
        //        End If
    
        //        .Fields("ClientCode").value = mstrClientCode
        //        .Fields("ClientName").value = mstrClientName
        //        .Fields("PrimaryClaimsUserCode").value = _
        //            IIf(mstrPrimaryClaimsUserCode = vbNullString, Null, mstrPrimaryClaimsUserCode)
        //        .Fields("InterfaceClaimsUserCode").value = _
        //            IIf(mstrIntefaceClaimsUserCode = vbNullString, Null, mstrIntefaceClaimsUserCode)
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
    
        //    With mrstUserList
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
        //  Created By:    Richard M. Conlan - 5/10/2004
        //
        //  Parameters:    pstrUserName (String)
        //                 pstrClientCode (String)
        //----------------------------------------------------------------------------------------------
        public void NewClientUser(string pstrUserCode, string pstrUserName){

            //Dim strSQL 
    
            //strSQL = _
            //    "INSERT INTO ClaimsUser( ClaimsUserCode, ClaimsUser, fkClientCode, " & _
            //    "                        CreatedDateTime, CreatedUser, ModifiedDateTime, " & _
            //    "                        ModifiedUser ) " & _
            //    "  valueS( '" & pstrUserCode & "', '" & pstrUserName & "', " & _
            //    "          '" & mstrClientCode & "', '" & Now & "', '" & gstrDeveloperCode & "', " & _
            //    "          '" & Now & "', '" & gstrDeveloperCode & "' ) "
        
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
        //    '<EhHeader>
        //    On Error GoTo PROC_ERROR
        //    Const c_strSource  = "SupportCenter.clsClient.GetLastCommunication"
        //    '</EhHeader>
    
        //    Dim strSQL 
        //    Dim rstLastCommunication As ADODB.Recordset
        //    Set rstLastCommunication = New ADODB.Recordset
    
        //    strSQL = "SELECT TOP 1 CAST(DATEPART(yyyy, EndDateTime) as varchar(4)) + '-' " & _
        //                    "+ RIGHT('0' + CAST(DATEPART(mm, EndDateTime) as varchar(2)), 2) + '-' " & _
        //                    "+ RIGHT('0' + CAST(DATEPART(dd, EndDateTime) as varchar(2)), 2) + ' (' " & _
        //                    "+ fkDeveloperCode + ')' AS LastCommunication " & _
        //                "FROM ActivityLog " & _
        //                "WHERE fkClientCode = '" & pstrClientCode & "' " & _
        //                "ORDER BY CAST(DATEPART(yyyy, EndDateTime) as varchar(4)) + '-' " & _
        //                    "+ RIGHT('0' + CAST(DATEPART(mm, EndDateTime) as varchar(2)), 2)  + '-' " & _
        //                    "+ RIGHT('0' + CAST(DATEPART(dd, EndDateTime) as varchar(2)), 2) DESC"
                    
        //    Call rstLastCommunication.Open(strSQL, gobjConnection.Connection)
    
        //    If Not (rstLastCommunication.EOF And rstLastCommunication.BOF) Then
        //        GetLastCommunication = rstLastCommunication!LastCommunication
        //    Else
        //        GetLastCommunication = vbNullString
        //    End If

        //'<EhFooter>
        //PROC_EXIT:
        //    Set rstLastCommunication = Nothing
        //    Exit Function
        //PROC_ERROR:
        //    Call ErrorHandler(c_strSource)
        //    GoTo PROC_EXIT
        //'</EhFooter>
            return "";
        }

        public string GetNumberOfOpenIssues(string pstrClientCode){
            //Dim strSQL 
    
            //strSQL = "SELECT COUNT(*) AS NumberOfOpenIssues " & _
            //        "FROM ClientIssue " & _
            //        "WHERE fkClientCode = '" & pstrClientCode & "' " & _
            //            "AND CompletedDate IS NULL"
                
            //GetNumberOfOpenIssues = gobjConnection.Connection.Execute(strSQL)!NumberOfOpenIssues
            return "";
        }

    }
}

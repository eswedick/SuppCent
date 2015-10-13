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

        //public Event CurrentClientChanged(pstrCurrentClientCode As String)
        //public Event ClientListChanged()

        //----------------------------------------------------------------------------------------------
        //                                          PROPERTIES
        //----------------------------------------------------------------------------------------------

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
                return mrstClientList;
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
    
            mrstClientList = null;
            mrstCurrentClientContactList = null;

        }

        //----------------------------------------------------------------------------------------------
        //                                       public PROCEDURES
        //----------------------------------------------------------------------------------------------

        public string ClientCodeFromName(string pstrClientName){
        
            mdtClientList.Find "ClientName= '" & pstrClientName & "'", , , adBookmarkFirst
        
            if (Not mdtClientList.EOF) {
                return .Fields("ClientCode").Value();
            }
            else {
                return null;
            }

        }

        public void ConfigureClientCombo(pcboClient As SSOleDBCombo, bool pblnIncludeAllAsChoice = true){

            int intColPosition;
            string strSeparator;
            string strNewRow;

            With pcboClient
                .DataMode = ssDataModeAddItem
                .BackColorEven = &HFFFFFF
                .BackColorOdd = &HC0FFFF
                .ForeColorEven = &H0&
                .ForeColorOdd = &H0&
        
                .Columns.RemoveAll
                intColPosition = 0
                .Columns(intColPosition).Name = "ClientCode"
                .Columns(intColPosition).Caption = "Client Code"
                .Columns(intColPosition).DataType = vbString
                intColPosition = intColPosition + 1
        
                .Columns(intColPosition).Name = "ClientName"
                .Columns(intColPosition).Caption = "Client Name"
                .Columns(intColPosition).DataType = vbString
                intColPosition = intColPosition + 1
            
                .FieldSeparator = ";"
                strSeparator = .FieldSeparator
                .DataFieldList = "Column 0"
                .DataFieldToDisplay = "Column 1"
                .RemoveAll
                .Text = vbNullString
            End With
     
            If pblnIncludeAllAsChoice Then
                strNewRow = vbNullString +
                            strSeparator +
                            "All"
                    
                pcboClient.AddItem (strNewRow)
            End If
    
            With mrstClientList
        
                If Not (.BOF And .EOF) Then
            
                    .MoveFirst
                    Do Until .EOF
                        strNewRow = .Fields("ClientCode").Value +
                                    strSeparator +
                                    .Fields("ClientName").Value
                
                        pcboClient.AddItem (strNewRow)
                
                        .MoveNext
                    Loop
                End If
                pcboClient.MoveFirst
    
            End With


        }

        public void ConfigureClaimsUserCombo(pcboClaimsUser As SSOleDBCombo, Optional pblnIncludeAllAsChoice As Boolean = True){
    
            Dim intColPosition As Integer
            Dim strSeparator   As String
            Dim strNewRow      As String

            With pcboClaimsUser
                .DataMode = ssDataModeAddItem
                .BackColorEven = &HFFFFFF
                .BackColorOdd = &HC0FFFF
                .ForeColorEven = &H0&
                .ForeColorOdd = &H0&
        
                .Columns.RemoveAll
        
                intColPosition = 0
                .Columns(intColPosition).Name = "fkClientCode"
                .Columns(intColPosition).Caption = "Client Code"
                .Columns(intColPosition).DataType = vbString
                intColPosition = intColPosition + 1
        
                .Columns(intColPosition).Name = "ClaimsUserCode"
                .Columns(intColPosition).Caption = "User Code"
                .Columns(intColPosition).DataType = vbString
                intColPosition = intColPosition + 1
            
                .Columns(intColPosition).Name = "ClaimsUserName"
                .Columns(intColPosition).Caption = "User Name"
                .Columns(intColPosition).DataType = vbString
                intColPosition = intColPosition + 1
            
                .Columns(intColPosition).Name = "PhoneNumber"
                .Columns(intColPosition).Caption = "Phone"
                .Columns(intColPosition).DataType = vbString
                intColPosition = intColPosition + 1
        
                .Columns(intColPosition).Name = "FaxNumber"
                .Columns(intColPosition).Caption = "Fax"
                .Columns(intColPosition).DataType = vbString
                intColPosition = intColPosition + 1
            
                .Columns(intColPosition).Name = "EmailAddress"
                .Columns(intColPosition).Caption = "Email"
                .Columns(intColPosition).DataType = vbString
                intColPosition = intColPosition + 1
    
                .FieldSeparator = ";"
                strSeparator = .FieldSeparator
                .DataFieldList = "Column 1"
                .DataFieldToDisplay = "Column 2"
                .RemoveAll
                .Text = vbNullString
            End With
     
            If pblnIncludeAllAsChoice Then
                strNewRow = vbNullString +
                            strSeparator +
                            "All"
                    
                pcboClaimsUser.AddItem (strNewRow)
            End If
    
            With mrstCurrentClientContactList
                If Not (.BOF And .EOF) Then
                    .MoveFirst
                    Do Until .EOF
                        strNewRow = .Fields("fkClientCode").Value & strSeparator +
                                    .Fields("ClaimsUserCode").Value & strSeparator +
                                    .Fields("ClaimsUser").Value & strSeparator +
                                    .Fields("PhoneNumber").Value & strSeparator +
                                    .Fields("FaxNumber").Value & strSeparator +
                                    .Fields("EmailAddress").Value

                        pcboClaimsUser.AddItem (strNewRow)
                
                        .MoveNext
                    Loop
                End If
                pcboClaimsUser.MoveFirst
            End With

        }

        public void SetCurrentClaimsUser(pstrClaimsUserCode As String){

            mstrCurrentClaimsUser = pstrClaimsUserCode

        }

        public void FlagClientDataAsChanged(pstrClientCode As String){

            If mstrCurrentClientCode = pstrClientCode Then
                RaiseEvent CurrentClientChanged(mstrCurrentClientCode)
            End If

        }

        public void GetClients(){
            Dim strSQL As String

            If mrstClientList.State = adStateOpen Then mrstClientList.Close
    
            // Get list of clients from DB.
            strSQL = _
                "SELECT ClientCode, ClientName, PrimaryClaimsUserCode, InterfaceClaimsUserCode, " +
                "       RemoteAccessType, RemoteAccessAddress, SQLServerName, SQLServerIPAddress, " +
                "       TerminalServerName, TerminalServerIPAddress, Notes, CreatedDateTime, " +
                "       CreatedUser, ModifiedDateTime, ModifiedUser, Version, D.DeveloperName, fkTechnicalContact, fkPrimaryContactDeveloper " +
                "  FROM Client " +
                "   LEFT OUTER JOIN Developer AS D ON D.DeveloperCode = fkPrimaryContactDeveloper " +
                "  WHERE Active = 1"

            mrstClientList.CursorLocation = adUseClient
            mrstClientList.Open strSQL, gobjConnection.Connection, _
                adOpenStatic, adLockOptimistic, adCmdText
        
            Set GetClients = mrstClientList
    
        }

        public void ReloadClients(){

            Dim strSQL As String

            If mrstClientList.State = adStateOpen Then mrstClientList.Close
    
            // Get list of clients from DB.
            strSQL = _
                "SELECT ClientCode, ClientName, PrimaryClaimsUserCode, InterfaceClaimsUserCode, " +
                "       RemoteAccessType, RemoteAccessAddress, SQLServerName, SQLServerIPAddress, " +
                "       TerminalServerName, TerminalServerIPAddress, Notes, CreatedDateTime, " +
                "       CreatedUser, ModifiedDateTime, ModifiedUser, Version, D.DeveloperName, fkTechnicalContact, fkPrimaryContactDeveloper " +
                "  FROM Client " +
                "   LEFT OUTER JOIN Developer AS D ON D.DeveloperCode = fkPrimaryContactDeveloper " +
                "  WHERE Active = 1"

            mrstClientList.Open strSQL, gobjConnection.Connection, _
                adOpenKeyset, adLockOptimistic, adCmdText
    
            RaiseEvent ClientListChanged

        }


        public void SetCurrentClient(pstrCurrentClientCode As String){
    
            Dim strSQL  As String
    
            With mrstClientList
    
                .Find "ClientCode = '" & pstrCurrentClientCode & "'", , , adBookmarkFirst
        
                If Not .EOF Then
                    mrstCurrentClientContactList.Close
            
                    strSQL = _
                        "SELECT ClaimsUserCode, ClaimsUser, fkClientCode, PhoneNumber, FaxNumber, " +
                        "       EMailAddress, CreatedDateTime, CreatedUser, ModifiedDateTime, " +
                        "       ModifiedUser " +
                        "  FROM ClaimsUser " +
                        " WHERE fkClientCode = '" & .Fields("ClientCode").Value & "'"
                        
                    mrstCurrentClientContactList.Open strSQL, gobjConnection.Connection, _
                        adOpenKeyset, adLockOptimistic, adCmdText
             
                    mstrCurrentClientName = .Fields("ClientName").Value
                    mstrCurrentClientCode = .Fields("ClientCode").Value
                    mstrCurrentClientPrimaryUser = _
                        IfNull(.Fields("PrimaryClaimsUserCode").Value, vbNullString)
             
                    RaiseEvent CurrentClientChanged(.Fields("ClientCode").Value)
                Else
                    mstrCurrentClientName = vbNullString
                    mstrCurrentClientCode = vbNullString
                    mstrCurrentClientPrimaryUser = vbNullString
                End If
    
            End With

        }

        public string GetCurrentProductionVersion(){
    
            On Error GoTo PROC_ERROR
            Const c_strSource As String = "SupportCenter.clsClientList.GetCurrentProductionVersion"
    
            Dim strSQL As String
            Dim rstCurrentVersion As ADODB.Recordset
    
            GetCurrentProductionVersion = vbNullString
    
            strSQL = "SELECT LatestVersionNumber FROM Project"
    
            Set rstCurrentVersion = New ADODB.Recordset
            Call rstCurrentVersion.Open(strSQL, gobjConnection.Connection)
    
            With rstCurrentVersion
                If Not (.EOF And .BOF) Then
                    If .RecordCount > 0 Then
                        .MoveFirst
                        GetCurrentProductionVersion = !LatestVersionNumber
                    End If
                End If
            End With
    

        PROC_EXIT:
            Exit Function
        PROC_ERROR:
            Call ErrorHandler(c_strSource)
            GoTo PROC_EXIT

        }

        public bool NewVersionAvailable(ByVal pstrLatestVersion As String, _
                                            ByVal pstrClientVersion As String, _
                                            Optional ByVal plngMinMajorVersionDifference As Long = 1, _
                                            Optional ByVal plngMinMinorVersionDifference As Long = 1, _
                                            Optional ByVal plngMinRevisionVersionDifference As Long = 1){}
    
            On Error GoTo PROC_ERROR
            Const c_strSource As String = "SupportCenter.frmClientList.NewVersionAvailable"
    
    
            Dim lngProductionSegment As Long
            Dim lngClientSegment As Long
            Dim strProductionRestOfString As String
            Dim strClientRestOfString As String
    
            //check major version
            lngProductionSegment = Val(Mid$(pstrLatestVersion, 1, InStr(pstrLatestVersion, ".")))
            lngClientSegment = Val(Mid$(pstrClientVersion, 1, InStr(pstrClientVersion, ".")))
    
            If lngProductionSegment >= lngClientSegment + plngMinMajorVersionDifference Then
                NewVersionAvailable = True
                GoTo PROC_EXIT
            End If
    
            strProductionRestOfString = Mid$(pstrLatestVersion, InStr(pstrLatestVersion, ".") + 1, 999) & ".." 'appending .. so that following functions will work
            strClientRestOfString = Mid$(pstrClientVersion, InStr(pstrClientVersion, ".") + 1, 999) & ".." 'appending .. so that following functions will work
    
            //check minor version
            lngProductionSegment = Val(Mid$(strProductionRestOfString, 1, InStr(strProductionRestOfString, ".")))
            lngClientSegment = Val(Mid$(strClientRestOfString, 1, InStr(strClientRestOfString, ".")))
    
            If lngProductionSegment >= lngClientSegment + plngMinMinorVersionDifference Then
                NewVersionAvailable = True
                GoTo PROC_EXIT
            End If
    
            strProductionRestOfString = Mid$(strProductionRestOfString, InStr(strProductionRestOfString, "."), 999)
            strClientRestOfString = Mid$(strClientRestOfString, InStr(strClientRestOfString, "."))
    
            //check revision version
            lngProductionSegment = Val(Mid$(strProductionRestOfString, 1, InStr(strProductionRestOfString, ".")))
            lngClientSegment = Val(Mid$(strClientRestOfString, 1, InStr(strClientRestOfString, ".")))
    
            If lngProductionSegment >= lngClientSegment + plngMinRevisionVersionDifference Then
                NewVersionAvailable = True
                GoTo PROC_EXIT
            End If
    
            strProductionRestOfString = Mid$(pstrLatestVersion, InStr(pstrLatestVersion, "."), 999)
            strClientRestOfString = Mid$(pstrClientVersion, InStr(pstrClientVersion, "."))
    
            //no problem!
            NewVersionAvailable = False


        }


    }
}

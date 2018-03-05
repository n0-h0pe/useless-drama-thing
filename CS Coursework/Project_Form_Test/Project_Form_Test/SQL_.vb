Module SQL_

    Dim DBProvider As String = "Provider=Microsoft.ACE.OLEDB.12.0;"
    Dim DBPath As String = "path.accdb"
    Dim DBSource As String = "Data source=" & DBPath
    Dim SQL As String
    Dim CON As New OleDb.OleDbConnection(DBProvider & DBSource)

    Dim UserEntry As Boolean = True


    Public Function Confirm_Login(Username As String, Password As String)

        MsgBox("This works lol")
        Return Username

    End Function

End Module

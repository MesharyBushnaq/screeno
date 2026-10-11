Module Module1

    Public Property ConnectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Screeno\MyFocus.mdf;Integrated Security=True;Connect Timeout=30"

    Public Function GetConnectionString() As String
        Return ConnectionString
    End Function

End Module

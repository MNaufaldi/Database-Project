Imports System.Data
'Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Module ConnectDB
    Public conn As SqlConnection
    'Public conn As MySqlConnection
    Public stamp As String
    Public Function GetConnect()

        conn = New SqlConnection("Data Source=DESKTOP-08JCPM7\MY_SERVER;Initial Catalog=Hotel_System;Integrated Security=SSPI")
        Return conn
    End Function
    Public Function GetTimeStamp()
        Dim yy As String = Now.Year.ToString
        Dim m As String = Now.Month.ToString
        Dim d As String = Now.Day.ToString
        Dim h As String = Now.Hour.ToString
        Dim mm As String = Now.Minute.ToString
        Dim ss As String = Now.Second.ToString

        stamp = yy & m & d & h & mm & ss
        Return stamp
    End Function
End Module

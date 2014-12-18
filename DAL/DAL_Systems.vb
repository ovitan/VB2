Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient
Imports QLDVVTHH.DTO
Imports QLDVVTHH.DAL

Namespace DAL
	Public Class DAL_Systems
		Private data As New ConnectData()
		Public Function CreateIDCode(strID As String, field As String, table As String, length As Integer) As String
			Try
				Dim IDCode As String = strID & "000"
				Dim query As String = "select max(" & field.Trim() & ") from " & table.Trim() & " where left(" & field.Trim() & "," & strID.Length.ToString() & ")='" & strID.Trim() & "'"

				Dim dt As DataTable = data.ExcuteDataTable(query, Nothing)
				If dt.Rows(0)(0).ToString() <> "" Then
					IDCode = dt.Rows(0)(0).ToString()
				End If

				IDCode = IDCode.Substring(strID.Length)
				IDCode = "0000000000000000" & Convert.ToString(Convert.ToInt64(IDCode) + 1)
				IDCode = strID & IDCode.Substring(IDCode.Length - length + strID.Length)

				Return IDCode
			Catch ex As Exception
				Throw ex
			End Try
		End Function
	End Class
End Namespace

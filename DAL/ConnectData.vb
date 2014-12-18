Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Object
Imports QLDVVTHH.DAL
Namespace DAL

	Public Class ConnectData
		Private strConn As String = ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString
		Private cn As SqlConnection
		Private cmd As SqlCommand
		Private Function OpenConnect() As Boolean
			Try
				cn = New SqlConnection(strConn)
				cn.Open()
				Return True
			Catch
				Return False
			End Try
		End Function
		Private Sub CloseConnect()
			cn.Close()
			cn.Dispose()
			'cmd.Dispose();
		End Sub
		Public Sub Connect()
			If cn.State = ConnectionState.Closed Then
				cn.Open()
			End If
		End Sub
		Public Sub DisConnect()
			If cn.State = ConnectionState.Open Then
				cn.Close()
			End If
		End Sub
		Public Function ExcuteNonQuery(sql As String, prs As SqlParameter()) As Boolean
			Try
				OpenConnect()
				Dim cm As New SqlCommand(sql, cn)
				cm.CommandType = CommandType.Text
				If prs IsNot Nothing Then
					cm.Parameters.AddRange(prs)
				End If
				cm.ExecuteNonQuery()
				CloseConnect()
				Return True
			Catch ex As SqlException
				Return False
			End Try
		End Function
		Public Function ExcuteDataReader(sql As String, prs As SqlParameter()) As SqlDataReader
			Try
				OpenConnect()
				Dim cm As New SqlCommand(sql, cn)
				cm.CommandType = CommandType.Text
				If prs IsNot Nothing Then
					cm.Parameters.AddRange(prs)
				End If
				Dim dr As SqlDataReader = cm.ExecuteReader()
				Return dr
				

			Catch ex As Exception
				Return Nothing
			End Try
		End Function
		Public Function ExcuteDataTable(sql As String, prs As SqlParameter()) As DataTable
			Try
				OpenConnect()
				Dim cm As New SqlCommand(sql, cn)
				cm.CommandType = CommandType.Text
				If prs IsNot Nothing Then
					cm.Parameters.AddRange(prs)
				End If
				Dim dt As New DataTable()
				Dim da As New SqlDataAdapter(cm)
				da.Fill(dt)
				Return dt
			Catch ex As Exception
				Return Nothing
			End Try
		End Function
		Public Function ExcuteDataset(sql As String, prs As SqlParameter()) As DataSet
			Try
				OpenConnect()
				Dim cm As New SqlCommand(sql, cn)
				cm.CommandType = CommandType.Text
				If prs IsNot Nothing Then
					cm.Parameters.AddRange(prs)
				End If
				Dim ds As New DataSet()
				Dim da As New SqlDataAdapter(cm)
				da.Fill(ds)
				Return ds
			Catch generatedExceptionName As Exception
				Return Nothing
			End Try
		End Function
        Public Function MapDataReaderToObject(Of T)(dr As SqlDataReader) As List(Of T)
            Dim list As New List(Of T)()
            If dr IsNot Nothing Then
                While dr.Read()
                    Dim b As T = DirectCast(Activator.CreateInstance(GetType(T)), T)
                    For Each pr As Object In GetType(T).GetProperties()
                        If pr.CanWrite Then
                            Try
                                Dim value = Convert.ChangeType(dr(pr.Name), pr.PropertyType)
                                If pr.PropertyType.Name.Equals(GetType(String).Name) Then
                                    value = TryCast(value, String).Trim()
                                End If
                                pr.SetValue(b, value, Nothing)
                            Catch
                            End Try
                        End If
                    Next
                    list.Add(b)
                End While
            End If
            CloseConnect()
            Return list
        End Function
		Public Function GetTable(proc As String, ParamArray ob As Object()) As DataTable
			If Not OpenConnect() Then
				Return Nothing
			End If
			cmd = New SqlCommand()
			cmd.CommandText = proc
			cmd.CommandType = CommandType.StoredProcedure
			cmd.Connection = cn
			SqlCommandBuilder.DeriveParameters(cmd)
			For i As Integer = 1 To cmd.Parameters.Count - 1
				cmd.Parameters(i).Value = ob(i - 1)
			Next
			Dim da As New SqlDataAdapter()
			Try
				da.SelectCommand = cmd
				Dim dt As New DataTable()
				da.Fill(dt)
				CloseConnect()
				da.Dispose()
				Return dt
			Catch
				Return Nothing
			End Try
		End Function
		Public Function GetDataSet(proc As String, ParamArray ob As Object()) As DataSet
			If Not OpenConnect() Then
				Return Nothing
			End If
			cmd = New SqlCommand()
			cmd.CommandText = proc
			cmd.CommandType = CommandType.StoredProcedure
			cmd.Connection = cn
			SqlCommandBuilder.DeriveParameters(cmd)
			For i As Integer = 1 To cmd.Parameters.Count - 1
				cmd.Parameters(i).Value = ob(i - 1)
			Next
			Dim da As New SqlDataAdapter()
			Try
				da.SelectCommand = cmd
				Dim ds As New DataSet()
				da.Fill(ds)
				CloseConnect()
				da.Dispose()
				Return ds
			Catch ex As Exception
				Return Nothing
			End Try
		End Function
		Public Function ExcuteStore(proc As String, ParamArray ob As Object()) As Integer
			If Not OpenConnect() Then
				Return -1
			End If
			cmd = New SqlCommand()
			cmd.Connection = cn
			cmd.CommandText = proc
			cmd.CommandType = CommandType.StoredProcedure
			SqlCommandBuilder.DeriveParameters(cmd)
			For i As Integer = 1 To cmd.Parameters.Count - 1
				cmd.Parameters(i).Value = ob(i - 1)
			Next
			Try
				cmd.ExecuteNonQuery()
				CloseConnect()
				Return 1
			Catch ex As Exception
				Return -1
			End Try
		End Function
	End Class
End Namespace

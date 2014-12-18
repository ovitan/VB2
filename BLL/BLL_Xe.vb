Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports QLDVVTHH.DTO
Imports QLDVVTHH.DAL
Imports System.Data
Imports System.Data.SqlClient

Namespace BLL
	Public Class BLL_Xe
		Private dal_xe As New DAL_Xe()
		Public Function GetAll_Xe() As List(Of DTO_Xe)
			Return dal_xe.GetAll_Xe()
		End Function
		Public Function GetAll_Xe_1() As List(Of DTO_Xe)
			Return dal_xe.GetAll_Xe_1()
		End Function
		Public Function Create_Xe(xe As DTO_Xe) As Boolean
			Return dal_xe.Create_Xe(xe)
		End Function
		Public Function Update_Xe(xe As DTO_Xe) As Boolean
			Return dal_xe.Update_Xe(xe)
		End Function
		Public Function Delete_Xe(ma_xe As String) As Boolean
			Return dal_xe.Delete_Xe(ma_xe)
		End Function
	End Class
End Namespace

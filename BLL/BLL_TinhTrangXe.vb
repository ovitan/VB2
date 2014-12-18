Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports QLDVVTHH.DTO
Imports QLDVVTHH.DAL
Imports System.Data
Imports System.Data.SqlClient

Namespace BLL
	Class BLL_TinhTrangXe
		Private ttxe As New DAL_Tinhtrangxe()
		Public Function GetAll_TTXE() As List(Of DTO_TinhTrangXe)
			Return ttxe.GetAll_TTXE()
		End Function
		Public Function Create_TTxe(TTxe__1 As DTO_TinhTrangXe) As Boolean
			Return ttxe.Create_TTxe(TTxe__1)
		End Function
		Public Function Update_TTxe(TTxe__1 As DTO_TinhTrangXe) As Boolean
			Return ttxe.Update_TTxe(TTxe__1)
		End Function
		Public Function Delete_TTxe(ma_tt As String) As Boolean
			Return ttxe.Delete_TTxe(ma_tt)
		End Function
	End Class
End Namespace

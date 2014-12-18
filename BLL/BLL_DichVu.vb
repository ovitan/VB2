Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports QLDVVTHH.DTO
Imports QLDVVTHH.DAL
Imports System.Data
Imports System.Data.SqlClient

Namespace BLL
	Class BLL_DichVu
		Private dv As New DAL_DichVu()
		Public Function GetAll_DV() As List(Of DTO_DichVu)
			Return dv.GetAll_DV()
		End Function
		Public Function DOngia(dto As DTO_DichVu) As List(Of DTO_DichVu)
			Return dv.DOngia(dto)
		End Function
		Public Function Create_DV(DV__1 As DTO_DichVu) As Boolean
			Return dv.Create_DV(DV__1)
		End Function
		Public Function Update_DV(DV__1 As DTO_DichVu) As Boolean
			Return dv.Update_DVU(DV__1)
		End Function
		Public Function Delete_DV(ma_dv As String) As Boolean
			Return dv.Delete_DV(ma_dv)
		End Function
		Public Function KV() As List(Of DTO_DichVu)
			Return dv.KV()
		End Function
		Public Function PV() As List(Of DTO_DichVu)
			Return dv.PV()
		End Function
		Public Function KV_2() As List(Of DTO_DichVu)
			Return dv.KV_2()
		End Function
		Public Function PV_2(dvv As DTO_DichVu) As List(Of DTO_DichVu)
			Return dv.PV_2(dvv)
		End Function
		Public Function DOngia_2(dto As DTO_DichVu) As List(Of DTO_DichVu)
			Return dv.DOngia_2(dto)
		End Function
	End Class
End Namespace

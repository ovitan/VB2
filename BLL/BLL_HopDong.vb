Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports QLDVVTHH.DTO
Imports QLDVVTHH.DAL
Imports System.Data
Imports System.Data.SqlClient
Namespace BLL
	Public Class BLL_HopDong
		Private hd As New DAL_HopDong()
		Public Function _Bang_Ma_Khach_Hang() As DataTable
			Return hd._Bang_Ma_Khach_Hang()
		End Function
		Public Function _Ten_Khach_Hang_Theo_Ma_Khach_Hang(kh As DTO_KhachHang) As String
			Return hd._Ten_Khach_Hang_Theo_Ma_Khach_Hang(kh)
		End Function
		Public Function _Ma_Hop_Dong() As String
			Return hd._Ma_Hop_Dong()
		End Function
		Public Function _Them_Hop_Dong(dt_hd As DTO_HopDong) As Integer
			Return hd._Them_Hop_Dong(dt_hd)
		End Function
		Public Function _List_Hop_Dong_Cung_Khach_Hang(dt_hd As DTO_HopDong) As DTO_HopDong()
			Return hd._List_Hop_Dong_Cung_Khach_Hang(dt_hd)
		End Function
		Public Function _Xoa_Hop_Dong(dto As DTO_HopDong) As Boolean
			Return hd._Xoa_Hop_Dong(dto)
		End Function
		Public Function _Update_Hop_Dong(dto As DTO_HopDong) As Boolean
			Return hd._Update_Hop_Dong(dto)
		End Function
		Public Function _Tim_Khach_Hang_Hop_Dong(dto As DTO_HopDong) As DTO_HopDong()
			Return hd._Tim_Khach_Hang_Hop_Dong(dto)
		End Function
		Public Function GetAll_KH_HD_HH() As List(Of DTO_HopDong)
			Return hd.GetAll_KH_HD_HH()
		End Function
		Public Function GetAll_KH_ID(KHID As String) As List(Of DTO_HopDong)
			Return hd.GetAll_KH_ID(KHID)
		End Function
		Public Function Ma_HD() As List(Of DTO_HopDong)
			Return hd.Ma_HD()
		End Function
	End Class
End Namespace

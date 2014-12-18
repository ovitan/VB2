Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports QLDVVTHH.DTO
Imports QLDVVTHH.DAL
Imports System.Data
Imports System.Data.SqlClient

Namespace BLL
	Public Class BLL_HoaDon
		Public Function _Ma_Hoa_Don() As String
			Return New DAL_HoaDon()._Ma_Hoa_Don()
		End Function
		Public Function _Lap_Hoa_Hon_Van_Chuyen(hopdong As DTO_HopDong, hoadon As DTO_HoaDon) As Integer
			Return New DAL_HoaDon()._Lap_Hoa_Hon_Van_Chuyen(hopdong, hoadon)
		End Function
		Public Function _List_Hoa_Hon_Van_Chuyen(hoadon As DTO_HoaDon) As DTO_HoaDon()
			Return New DAL_HoaDon()._List_Hoa_Hon_Van_Chuyen(hoadon)
		End Function
		Public Function _List_Chi_Tiet_Hoa_Hon_Van_Chuyen(ct As DTO_Chi_Tiet_Hoa_Don) As DTO_BangKe()
			Return New DAL_HoaDon()._List_Chi_Tiet_Hoa_Hon_Van_Chuyen(ct)
		End Function
		Public Function _Xoa_Hoa_Don_Van_Chuyen(hoadon As DTO_HoaDon) As Integer
			Return New DAL_HoaDon()._Xoa_Hoa_Don_Van_Chuyen(hoadon)
		End Function
		Public Function _Tim_Hoa_Hon_Van_Chuyen(hoadon As DTO_HoaDon) As DTO_HoaDon()
			Return New DAL_HoaDon()._Tim_Hoa_Hon_Van_Chuyen(hoadon)
		End Function
		Public Function _List_Hoa_Don(hoadon As DTO_HoaDon) As DTO_HoaDon()
			Return New DAL_HoaDon()._List_Hoa_Don(hoadon)
		End Function
	End Class
End Namespace

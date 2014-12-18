Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports QLDVVTHH.DTO
Imports QLDVVTHH.DAL

Namespace BLL
	Public Class BLL_TraCuu
		Public Function _Tim_KhachHang(dto As DTO_KhachHang) As DTO_KhachHang()
			Return New DAL_TraCuu()._Tim_KhachHang(dto)
		End Function
		Public Function _Tim_NhanVien(dto As DTO_NhanVien) As DTO_NhanVien()
			Return New DAL_TraCuu()._Tim_NhanVien(dto)
		End Function
		Public Function _Tim_ThongTinXe(xe As DTO_Xe) As DTO_Xe()
			Return New DAL_TraCuu()._Tim_ThongTinXe(xe)
		End Function
		Public Function _Tim_HoaDon(dto As DTO_HoaDon) As DTO_HoaDon()
			Return New DAL_TraCuu()._Tim_HoaDon(dto)
		End Function
		Public Function _Tim_HopDong(dto As DTO_HopDong) As DTO_HopDong()
			Return New DAL_TraCuu()._Tim_HopDong(dto)
		End Function
	End Class
End Namespace

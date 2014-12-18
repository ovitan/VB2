Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Data
Imports QLDVVTHH.DTO
Imports QLDVVTHH.DAL

Namespace BLL
	Public Class BLL_BangKe
		Public Function _List_Hop_Dong(hd As DTO_HopDong) As DataTable
			Return New DAL_BangKe()._List_Hop_Dong(hd)
		End Function
		Public Function _Ma_Bang_Ke() As [String]
			Return New DAL_BangKe()._Ma_Bang_Ke()
		End Function
		Public Function _Them_BangKe(dto As DTO_BangKe) As Integer
			Return New DAL_BangKe()._Them_BangKe(dto)
		End Function
		Public Function DanhSachBangKe_TheoMaKhachHang_MaHopDong(dto As DTO_BangKe) As DTO_BangKe()
			Return New DAL_BangKe()._DanhSachBangKe_TheoMaKhachHang_MaHopDong(dto)
		End Function
		Public Function _CapNhat_BangKe(dto As DTO_BangKe) As Integer
			Return New DAL_BangKe()._CapNhat_BangKe(dto)
		End Function
		Public Function _Xoa_BangKe(dto As DTO_BangKe) As Integer
			Return New DAL_BangKe()._Xoa_BangKe(dto)
		End Function
		Public Function _Tim_BangKe(bangke As DTO_BangKe, hopdong As DTO_HopDong, khachhang As DTO_KhachHang) As DTO_BangKe()
			Return New DAL_BangKe()._Tim_BangKe(bangke, hopdong, khachhang)
		End Function
		Public Function _List_Ten_Khach_Hang() As DataTable
			Return New DAL_BangKe()._List_Ten_Khach_Hang()
		End Function
		Public Function _List_Ma_Dieu_Xe(_xe As DTO_DieuXe) As DTO_DieuXe()
			Return New DAL_BangKe()._List_Ma_Dieu_Xe(_xe)
		End Function
	End Class
End Namespace

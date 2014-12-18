Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports QLDVVTHH.DTO
Imports QLDVVTHH.DAL
Imports System.Data
Imports System.Data.SqlClient

Namespace BLL
	Class BLL_DieuXe
		Private dx As New DAL_DieuXe()
		Public Function GetAll_DX() As List(Of DTO_DieuXe)
			Return dx.GetAll_DX()
		End Function
		Public Function Get_TrongLuongXe(dto As DTO_Xe) As List(Of DTO_Xe)
			Return dx.Get_TrongLuongXe(dto)
		End Function
		Public Function Create_DX(DX__1 As DTO_DieuXe) As Boolean
			Return dx.Create_DX(DX__1)
		End Function
		Public Function Update_DX(DXE As DTO_DieuXe) As Boolean
			Return dx.Update_DX(DXE)
		End Function
		Public Function Delete_Dxe(ma_dx As String) As Boolean
			Return dx.Delete_Dxe(ma_dx)
		End Function
		Public Function _Ma_Dieu_Xe_Moi() As String
			Return New DAL_DieuXe()._Ma_Dieu_Xe_Moi()
		End Function
		Public Function Get_NoiNhan() As List(Of DTO_DieuXe)
			Return dx.Get_NoiNhan()
		End Function
		Public Function Get_NoiGiao() As List(Of DTO_DieuXe)
			Return dx.Get_NoiGiao()
		End Function
		'''//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		Public Function Get_List_Xe_DangOBai() As List(Of DTO_Xe)
			Return dx.Get_List_Xe_DangOBai()
		End Function
		Public Function Get_List_Xe_Nhan_Vien(nv As DTO_NhanVien) As List(Of DTO_NhanVien)
			Return dx.Get_List_Xe_Nhan_Vien(nv)
		End Function
		Public Function _List_Get_NoiNhan(bg As DTO_BangBaoGia) As List(Of DTO_DieuXe)
			Return dx._List_Get_NoiNhan(bg)
		End Function
		Public Function _List_Get_NoiGiao(dxx As DTO_DieuXe) As List(Of DTO_DieuXe)
			Return dx._List_Get_NoiGiao(dxx)
		End Function
		Public Function _List_Get_Dieu_Xe_By_KhachHang_HopDong(dxx As DTO_DieuXe) As List(Of DTO_DieuXe)
			Return dx._List_Get_Dieu_Xe_By_KhachHang_HopDong(dxx)
		End Function
		Public Function Delete_Dieu_Xe(dxx As DTO_DieuXe) As Boolean
			Return dx.Delete_Dieu_Xe(dxx)
		End Function
		Public Function _Get_Tong_Trong_Luong(dxx As DTO_DieuXe) As Single
			Return dx._Get_Tong_Trong_Luong(dxx)
		End Function
		Public Function Update_Dieu_Xe(DXE As DTO_DieuXe) As Boolean
			Return dx.Update_Dieu_Xe(DXE)
		End Function
		Public Function _List_Get_Ma_Bao_Gia(bg As DTO_BangBaoGia) As List(Of DTO_BangBaoGia)
			Return dx._List_Get_Ma_Bao_Gia(bg)
		End Function
	End Class
End Namespace

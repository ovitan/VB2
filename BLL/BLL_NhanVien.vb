Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports QLDVVTHH.DTO
Imports QLDVVTHH.DAL
Imports System.Data
Imports System.Data.SqlClient
Namespace BLL
	Public Class BLL_NhanVien
		Private nv As New DAL_NhanVien()
		'public List<DAL_NhanVien> GetAllNhanvien()
		'{
		'    return nv.GetAllNhanvien();
		'}
		Public Function dt_GetAll() As List(Of DTO_NhanVien)
			Return nv.dt_GetAll()
		End Function
		Public Function GetAll_NV_ID(NVID As String) As List(Of DTO_NhanVien)
			Return nv.GetAll_NV_ID(NVID)
		End Function
		'public List<DTO_NhanVien> GetAll_NV()
		'{
		'    return nv.GetAll_NV();
		'}
		Public Function Create_nv(nhanvien As DTO_NhanVien) As Boolean
			Return nv.Create_nv(nhanvien)
		End Function
		Public Function Update_nv(nhanvien As DTO_NhanVien) As Boolean
			Return nv.Update_nv(nhanvien)
		End Function
		Public Function Delete_nv(ma_nv As String) As Boolean
			Return nv.Delete_nv(ma_nv)
		End Function
	End Class
End Namespace

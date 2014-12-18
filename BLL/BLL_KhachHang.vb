Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports QLDVVTHH.DTO
Imports QLDVVTHH.DAL
Imports System.Data
Imports System.Data.SqlClient

Namespace BLL
	Public Class BLL_KhachHang
		Private KH As New DAL_KhachHang()
		Public Function GetAll_KH() As List(Of DTO_KhachHang)
			Return KH.GetAll_KH()
		End Function
		Public Function GetAll_KH_ID(KHID As String) As List(Of DTO_KhachHang)
			Return KH.GetAll_KH_ID(KHID)
		End Function
		'public DataTable GetAll_KH_ID(string KHID)
		'{
		'    return KH.GetAll_KH_ID(KHID);
		'}
		'public List<DTO_KhachHang> GetAll_KH_HD_HH()
		'{
		'    return KH.GetAll_KH_HD_HH();
		'}
		Public Function Create_KH(kh__1 As DTO_KhachHang) As Boolean
			Return KH.Create_KH(kh__1)
		End Function
		Public Function Update_KH(kh__1 As DTO_KhachHang) As Boolean
			Return KH.Update_KH(kh__1)
		End Function
		Public Function Delete_kh(ma_kh As String) As Boolean
			Return KH.Delete_kh(ma_kh)
		End Function
	End Class
End Namespace

Imports System.Collections.Generic
Imports System.Linq
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports QLDVVTHH.DTO
Imports QLDVVTHH.DAL

Namespace DAL
	Class DAL_Tinhtrangxe
		Private data As New ConnectData()
		Public Function GetAll_TTXE() As List(Of DTO_TinhTrangXe)
			Dim sql As String = "select * from dm_tinh_trang_xe"
			Dim dr As SqlDataReader = data.ExcuteDataReader(sql, Nothing)
			Return data.MapDataReaderToObject(Of DTO_TinhTrangXe)(dr)
		End Function
		Public Function Create_TTxe(TTxe As DTO_TinhTrangXe) As Boolean
			Dim sql As String = "insert into dm_tinh_trang_xe(ma_tinh_trang,ten_tinh_trang) values(@ma_tinh_trang,@ten_tinh_trang)"
			Dim prs As SqlParameter() = {New SqlParameter("@ma_tinh_trang", TTxe.ma_tinh_trang), New SqlParameter("@ten_tinh_trang", TTxe.ten_tinh_trang)}
			Return data.ExcuteNonQuery(sql, prs)
		End Function
		Public Function Update_TTxe(TTxe As DTO_TinhTrangXe) As Boolean
			Dim sql As String = "update dm_tinh_trang_xe set ten_tinh_trang=@ten_tinh_trang where ma_tinh_trang=@ma_tinh_trang"
			Dim prs As SqlParameter() = {New SqlParameter("@ma_tinh_trang", TTxe.ma_tinh_trang), New SqlParameter("@ten_tinh_trang", TTxe.ten_tinh_trang)}
			Return data.ExcuteNonQuery(sql, prs)
		End Function
		Public Function Delete_TTxe(ma_tt As String) As Boolean
			Dim sql As String = "delete [dm_tinh_trang_xe] where ma_tinh_trang = @ma_tinh_trang"
			Dim prs As SqlParameter() = {New SqlParameter("@ma_tinh_trang", ma_tt)}
			Return data.ExcuteNonQuery(sql, prs)
		End Function
	End Class
End Namespace

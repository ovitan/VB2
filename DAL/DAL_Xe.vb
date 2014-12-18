Imports System.Collections.Generic
Imports System.Linq
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports QLDVVTHH.DTO
Imports QLDVVTHH.DAL

Namespace DAL
	Public Class DAL_Xe
		Private data As New ConnectData()
		Public Function GetAll_Xe() As List(Of DTO_Xe)
			Dim listxe As New List(Of DTO_Xe)()
			Dim sql As String = "select *,B.ten_tinh_trang from dm_xe A join dm_tinh_trang_xe B on A.ma_tinh_trang=B.ma_tinh_trang order by ngay_tao desc"
			Dim dr As SqlDataReader = data.ExcuteDataReader(sql, Nothing)
			If dr IsNot Nothing Then
				While dr.Read()
					Dim xe As New DTO_Xe()
					xe.ma_so_xe = dr("ma_so_xe").ToString()
					'xe.ma_tinh_trang = Convert.ToInt32(dr["ma_tinh_trang"].ToString());
					xe.loai_xe = dr("loai_xe").ToString()
					xe.nhan_hieu = dr("nhan_hieu").ToString()
					xe.trong_luong = Convert.ToInt32(dr("trong_luong").ToString())
					xe.ngay_tao = Convert.ToDateTime(dr("ngay_tao").ToString())
					xe.ten_tinh_trang = dr("ten_tinh_trang").ToString()
					listxe.Add(xe)
				End While
				data.DisConnect()
			End If
			Return listxe
		End Function
		Public Function GetAll_Xe_1() As List(Of DTO_Xe)
			Dim listxe_1 As New List(Of DTO_Xe)()
			Dim sql As String = "select *,B.ten_tinh_trang from dm_xe A join dm_tinh_trang_xe B on A.ma_tinh_trang=B.ma_tinh_trang and ten_tinh_trang=N'Đang ở bãi' order by ngay_tao desc"
			Dim dr As SqlDataReader = data.ExcuteDataReader(sql, Nothing)
			If dr IsNot Nothing Then
				While dr.Read()
					Dim xe As New DTO_Xe()
					xe.ma_so_xe = dr("ma_so_xe").ToString()
					xe.ma_tinh_trang = Convert.ToInt32(dr("ma_tinh_trang").ToString())
					xe.loai_xe = dr("loai_xe").ToString()
					xe.nhan_hieu = dr("nhan_hieu").ToString()
					xe.trong_luong = Convert.ToInt32(dr("trong_luong").ToString())
					xe.ngay_tao = Convert.ToDateTime(dr("ngay_tao").ToString())
					xe.ten_tinh_trang = dr("ten_tinh_trang").ToString()
					listxe_1.Add(xe)
				End While
				data.DisConnect()
			End If
			Return listxe_1
		End Function
		Public Function Create_Xe(xe As DTO_Xe) As Boolean
			Dim sql As String = "insert into dm_xe(ma_so_xe,trong_luong,loai_xe,nhan_hieu,ma_tinh_trang,ngay_tao) values(@ma_so_xe,@trong_luong,@loai_xe,@nhan_hieu,@ma_tinh_trang,@ngay_tao)"
			Dim prs As SqlParameter() = {New SqlParameter("@ma_so_xe", xe.ma_so_xe), New SqlParameter("@trong_luong", xe.trong_luong), New SqlParameter("@loai_xe", xe.loai_xe), New SqlParameter("@nhan_hieu", xe.nhan_hieu), New SqlParameter("@ma_tinh_trang", xe.ma_tinh_trang.ToString()), New SqlParameter("@ngay_tao", xe.ngay_tao)}
			Return data.ExcuteNonQuery(sql, prs)
		End Function
		Public Function Update_Xe(xe As DTO_Xe) As Boolean
			Dim sql As String = "update dm_xe set trong_luong=@trong_luong,loai_xe=@loai_xe,nhan_hieu=@nhan_hieu,ma_tinh_trang=@ma_tinh_trang,ngay_tao=@ngay_tao where ma_so_xe=@ma_so_xe"
			Dim prs As SqlParameter() = {New SqlParameter("@ma_so_xe", xe.ma_so_xe), New SqlParameter("@trong_luong", xe.trong_luong), New SqlParameter("@loai_xe", xe.loai_xe), New SqlParameter("@nhan_hieu", xe.nhan_hieu), New SqlParameter("@ma_tinh_trang", xe.ma_tinh_trang), New SqlParameter("@ngay_tao", xe.ngay_tao)}
			Return data.ExcuteNonQuery(sql, prs)
		End Function
		Public Function Delete_Xe(ma_so_xe As String) As Boolean
			Dim sql As String = "delete dm_xe where ma_so_xe=@ma_so_xe"
			Dim prs As SqlParameter() = {New SqlParameter("@ma_so_xe", ma_so_xe)}
			Return data.ExcuteNonQuery(sql, prs)
		End Function
	End Class
End Namespace

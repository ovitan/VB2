Imports System.Collections.Generic
Imports System.Linq
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports QLDVVTHH.DTO
Imports QLDVVTHH.DAL

Namespace DAL
	Class DAL_DichVu
		Private data As New ConnectData()
		Public Function GetAll_DV() As List(Of DTO_DichVu)
			Dim sql As String = "select * from dm_dich_vu"
			Dim dr As SqlDataReader = data.ExcuteDataReader(sql, Nothing)
			Return data.MapDataReaderToObject(Of DTO_DichVu)(dr)
		End Function
		Public Function KV() As List(Of DTO_DichVu)
			Dim sql As String = "select khu_vuc from dm_dich_vu"
			Dim dr As SqlDataReader = data.ExcuteDataReader(sql, Nothing)
			Return data.MapDataReaderToObject(Of DTO_DichVu)(dr)
		End Function
		Public Function KV_2() As List(Of DTO_DichVu)
			Dim sql As String = "select distinct khu_vuc from dm_dich_vu"
			Dim dt As DataTable = data.ExcuteDataTable(sql, Nothing)
			If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
				Dim dvv As New List(Of DTO_DichVu)()
				For Each dr As DataRow In dt.Rows
					Dim d As New DTO_DichVu()
					d.khu_vuc = dr("khu_vuc").ToString()
					dvv.Add(d)
				Next
				Return dvv
			End If
			Return Nothing
		End Function
		Public Function PV() As List(Of DTO_DichVu)
			Dim sql As String = "select phan_vung from dm_dich_vu"
			Dim dr As SqlDataReader = data.ExcuteDataReader(sql, Nothing)
			Return data.MapDataReaderToObject(Of DTO_DichVu)(dr)
		End Function
		Public Function PV_2(dv As DTO_DichVu) As List(Of DTO_DichVu)
			Dim sql As String = "select phan_vung from dm_dich_vu where khu_vuc='" & dv.khu_vuc.Trim() & "'"
			Dim dt As DataTable = data.ExcuteDataTable(sql, Nothing)
			If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
				Dim dvv As New List(Of DTO_DichVu)()
				For Each dr As DataRow In dt.Rows
					Dim d As New DTO_DichVu()
					d.phan_vung = dr("phan_vung").ToString()
					dvv.Add(d)
				Next
				Return dvv
			End If
			Return Nothing
		End Function
		Public Function DOngia(dto As DTO_DichVu) As List(Of DTO_DichVu)
			Dim sql As String = "select * from dm_dich_vu  where khu_vuc='" & dto.khu_vuc.Trim() & "'"
			Dim dr As SqlDataReader = data.ExcuteDataReader(sql, Nothing)
			Return data.MapDataReaderToObject(Of DTO_DichVu)(dr)
		End Function
		Public Function DOngia_2(dto As DTO_DichVu) As List(Of DTO_DichVu)
			Dim sql As String = "select * from dm_dich_vu  where khu_vuc='" & dto.khu_vuc.Trim() & "' and phan_vung='" & dto.phan_vung.Trim() & "'"
			Dim dr As SqlDataReader = data.ExcuteDataReader(sql, Nothing)
			Return data.MapDataReaderToObject(Of DTO_DichVu)(dr)
		End Function
		Public Function Create_DV(DV As DTO_DichVu) As Boolean
			Dim sql As String = "insert into dm_dich_vu(khu_vuc,phan_vung,don_gia_chuyen,don_gia_tan) values(@khu_vuc,@phan_vung,@don_gia_chuyen,@don_gia_tan)"
			Dim prs As SqlParameter() = {New SqlParameter("@khu_vuc", DV.khu_vuc), New SqlParameter("@phan_vung", DV.phan_vung), New SqlParameter("@don_gia_chuyen", DV.don_gia_chuyen), New SqlParameter("@don_gia_tan", DV.don_gia_tan)}
			Return data.ExcuteNonQuery(sql, prs)
		End Function
		Public Function Update_DVU(DV As DTO_DichVu) As Boolean
			Dim sql As String = "update dm_dich_vu set phan_vung=@phan_vung,don_gia_chuyen=@don_gia_chuyen,don_gia_tan=@don_gia_tan where khu_vuc=@khu_vuc"
			Dim prs As SqlParameter() = {New SqlParameter("@khu_vuc", DV.khu_vuc), New SqlParameter("@phan_vung", DV.phan_vung), New SqlParameter("@don_gia_chuyen", DV.don_gia_chuyen), New SqlParameter("@don_gia_tan", DV.don_gia_tan)}
			Return data.ExcuteNonQuery(sql, prs)
		End Function
		Public Function Delete_DV(ma_dv As String) As Boolean
			Dim sql As String = "delete [dm_dich_vu] where khu_vuc=@khu_vuc"
				'new SqlParameter("@phan_vung",ma_dv)
			Dim prs As SqlParameter() = {New SqlParameter("@khu_vuc", ma_dv)}
			Return data.ExcuteNonQuery(sql, prs)
		End Function
	End Class
End Namespace

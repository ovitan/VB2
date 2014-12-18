Imports System.Collections.Generic
Imports System.Linq
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports QLDVVTHH.DTO
Imports QLDVVTHH.DAL

Namespace DAL
	Public Class DAL_NhanVien
		Private data As New ConnectData()


		'public DataTable dt_GetAll()
		'{
		'    string sql = "select * from dm_nhan_vien";
		'    return data.ExcuteDataTable(sql, null);
		'}
		Public Function dt_GetAll() As List(Of DTO_NhanVien)
			Dim sql As String = "select *,B.ma_so_xe from dm_xe A join dm_nhan_vien B on A.ma_so_xe=B.ma_so_xe order by A.ngay_tao desc"
			Dim dr As SqlDataReader = data.ExcuteDataReader(sql, Nothing)
			Return data.MapDataReaderToObject(Of DTO_NhanVien)(dr)
		End Function
		'public List<DTO_NhanVien> GetAll_NV()
		'{
		'    string sql = "select * from dm_nhan_vien";
		'    SqlDataReader dr = data.ExcuteDataReader(sql, null);
		'    return data.MapDataReaderToObject<DTO_NhanVien>(dr);
		'}
		Public Function GetAll_NV_ID(NVID As String) As List(Of DTO_NhanVien)
			Dim sql As String = "select *,B.ma_so_xe from dm_nhan_vien A join dm_xe B on A.ma_so_xe = B.ma_so_xe where A.ma_so_xe = @ma_so_xe"
			Dim prs As SqlParameter() = {New SqlParameter("@ma_so_xe", NVID)}
			Dim dr As SqlDataReader = data.ExcuteDataReader(sql, prs)
			Return data.MapDataReaderToObject(Of DTO_NhanVien)(dr)
		End Function
		Public Function Create_nv(nhanvien As DTO_NhanVien) As Boolean
			Dim sql As String = "insert into dm_nhan_vien(ma_nhan_vien,ten_nhan_vien,ma_so_xe,cmnd,dia_chi,dien_thoai,nam_sinh,ngay_tao,chucvu) values(@ma_nhan_vien,@ten_nhan_vien,@ma_so_xe,@cmnd,@dia_chi,@dien_thoai,@nam_sinh,@ngay_tao,@chucvu)"
			Dim prs As SqlParameter() = {New SqlParameter("@ma_nhan_vien", nhanvien.ma_nhan_vien), New SqlParameter("@ten_nhan_vien", nhanvien.ten_nhan_vien), New SqlParameter("@ma_so_xe", nhanvien.ma_so_xe), New SqlParameter("@cmnd", nhanvien.cmnd), New SqlParameter("@dia_chi", nhanvien.dia_chi), New SqlParameter("@dien_thoai", nhanvien.dien_thoai), _
				New SqlParameter("@nam_sinh", nhanvien.nam_sinh), New SqlParameter("@ngay_tao", nhanvien.ngay_tao), New SqlParameter("@chucvu", nhanvien.chucvu)}
			Return data.ExcuteNonQuery(sql, prs)
		End Function
		Public Function Update_nv(nhanvien As DTO_NhanVien) As Boolean
			Dim sql As String = "update dm_nhan_vien set ten_nhan_vien=@ten_nhan_vien,ma_so_xe=@ma_so_xe,cmnd=@cmnd,dia_chi=@dia_chi,dien_thoai=@dien_thoai,nam_sinh=@nam_sinh,ngay_tao=@ngay_tao,chucvu=@chucvu where ma_nhan_vien=@ma_nhan_vien"
			Dim prs As SqlParameter() = {New SqlParameter("@ma_nhan_vien", nhanvien.ma_nhan_vien), New SqlParameter("@ten_nhan_vien", nhanvien.ten_nhan_vien), New SqlParameter("@ma_so_xe", nhanvien.ma_so_xe), New SqlParameter("@cmnd", nhanvien.cmnd), New SqlParameter("@dia_chi", nhanvien.dia_chi), New SqlParameter("@dien_thoai", nhanvien.dien_thoai), _
				New SqlParameter("@nam_sinh", nhanvien.nam_sinh), New SqlParameter("@ngay_tao", nhanvien.ngay_tao), New SqlParameter("@chucvu", nhanvien.chucvu)}
			Return data.ExcuteNonQuery(sql, prs)
		End Function
		Public Function Delete_nv(ma_nv As String) As Boolean
			Dim sql As String = "delete [dm_nhan_vien] where ma_nhan_vien = @ma_nhan_vien"
			Dim prs As SqlParameter() = {New SqlParameter("@ma_nhan_vien", ma_nv)}
			Return data.ExcuteNonQuery(sql, prs)
		End Function
	End Class
End Namespace

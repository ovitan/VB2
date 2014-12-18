Imports System.Collections.Generic
Imports System.Linq
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports QLDVVTHH.DTO
Imports QLDVVTHH.DAL

Namespace DAL
	Public Class DAL_KhachHang
		Private data As New ConnectData()
		'public DataTable GetAll_KH()
		'{
		'    string sql = "select * from dm_khach_hang";
		'    return data.ExcuteDataTable(sql, null);
		'}
		Public Function GetAll_KH() As List(Of DTO_KhachHang)
			Dim sql As String = "select * from dm_khach_hang"
			Dim dr As SqlDataReader = data.ExcuteDataReader(sql, Nothing)
			Return data.MapDataReaderToObject(Of DTO_KhachHang)(dr)
		End Function
		'public List<DTO_KhachHang> GetAll_KH_HD_HH()
		'{
		'    string sql = "select *, A.ten_khach_hang, B.ma_hop_dong, B.loaihanghoa, A.ma_khach_hang from dm_khach_hang A join dm_hop_dong B on A.ma_khach_hang = B.ma_khach_hang order by B.ngay_tao desc";
		'    SqlDataReader dr = data.ExcuteDataReader(sql, null);
		'    return data.MapDataReaderToObject<DTO_KhachHang>(dr);
		'}
		Public Function GetAll_KH_ID(KHID As String) As List(Of DTO_KhachHang)
			Dim sql As String = "select A.ten_khach_hang, B.ma_hop_dong, B.loaihanghoa, A.ma_khach_hang from dm_khach_hang A join dm_hop_dong B on A.ma_khach_hang = B.ma_khach_hang where B.ma_khach_hang = @ma_khach_hang"
			Dim prs As SqlParameter() = {New SqlParameter("@ma_khach_hang", KHID)}
			Dim dr As SqlDataReader = data.ExcuteDataReader(sql, prs)
			Return data.MapDataReaderToObject(Of DTO_KhachHang)(dr)
		End Function
		'public DataTable GetAll_KH_ID(string KHID)
		'{
		'    string sql = "select ma_hop_dong from dm_khach_hang A join dm_hop_dong B on A.ma_khach_hang = B.ma_khach_hang where A.ma_khach_hang = @ma_khach_hang";
		'    SqlParameter[] prs = 
		'    {
		'        new SqlParameter("@ma_khach_hang",KHID)
		'    };
		'    return data.ExcuteDataTable(sql, prs);
		'}
		Public Function Create_KH(kh As DTO_KhachHang) As Boolean
			Dim sql As String = "insert into dm_khach_hang(ma_khach_hang,ten_khach_hang,ma_so_thue,fax,dia_chi,dien_thoai,ngay_tao) values(@ma_khach_hang,@ten_khach_hang,@ma_so_thue,@fax,@dia_chi,@dien_thoai,@ngay_tao)"
			Dim prs As SqlParameter() = {New SqlParameter("@ma_khach_hang", kh.ma_khach_hang), New SqlParameter("@ten_khach_hang", kh.ten_khach_hang), New SqlParameter("@ma_so_thue", kh.ma_so_thue), New SqlParameter("@fax", kh.fax), New SqlParameter("@dia_chi", kh.dia_chi), New SqlParameter("@dien_thoai", kh.dien_thoai), _
				New SqlParameter("@ngay_tao", kh.ngay_tao)}
			Return data.ExcuteNonQuery(sql, prs)
		End Function
		Public Function Update_KH(kh As DTO_KhachHang) As Boolean
			Dim sql As String = "update dm_khach_hang set ten_khach_hang=@ten_khach_hang,ma_so_thue=@ma_so_thue,dia_chi=@dia_chi,dien_thoai=@dien_thoai,fax=@fax,ngay_tao=@ngay_tao where ma_khach_hang=@ma_khach_hang"
			Dim prs As SqlParameter() = {New SqlParameter("@ma_khach_hang", kh.ma_khach_hang), New SqlParameter("@ten_khach_hang", kh.ten_khach_hang), New SqlParameter("@ma_so_thue", kh.ma_so_thue), New SqlParameter("@fax", kh.fax), New SqlParameter("@dia_chi", kh.dia_chi), New SqlParameter("@dien_thoai", kh.dien_thoai), _
				New SqlParameter("@ngay_tao", kh.ngay_tao)}
			Return data.ExcuteNonQuery(sql, prs)
		End Function
		Public Function Delete_kh(ma_kh As String) As Boolean
			Dim sql As String = "delete [dm_khach_hang] where ma_khach_hang = @ma_khach_hang"
			Dim prs As SqlParameter() = {New SqlParameter("@ma_khach_hang", ma_kh)}
			Return data.ExcuteNonQuery(sql, prs)
		End Function
	End Class
End Namespace

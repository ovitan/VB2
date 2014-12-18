Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient
Imports QLDVVTHH.DTO
Namespace DAL
	Public Class DAL_INAN
		Private data As New ConnectData()
		'IN KHACH HANG
		Public Function _Luu_Data_Khach_Hang_Rpt() As Integer
			Dim i As Integer = 0
			Dim sql As String = "Delete from rpt_khachhang Insert into rpt_khachhang(stt,makhachhang,tenkhachhang,ma_so_thue,dia_chi,dien_thoai,fax,ngay_tao) select ROW_NUMBER() OVER (Order by dm_khach_hang.ma_khach_hang desc) as stt,ma_khach_hang,ten_khach_hang,ma_so_thue,dia_chi,dien_thoai,fax,ngay_tao from dm_khach_hang order by ma_khach_hang desc"
			Dim kq As Boolean = data.ExcuteNonQuery(sql, Nothing)
			If kq = False Then
				i = 1
			End If
			Return i
		End Function
		'IN NHAN VIEN
		Public Function _Luu_Data_Nhan_Vien_Rpt() As Integer
			Dim i As Integer = 0
			Dim sql As String = "Delete from rpt_nhanvien Insert into rpt_nhanvien(stt,ma_nhan_vien,ten_nhan_vien,dia_chi,dien_thoai,cmnd,chucvu,nam_sinh) select ROW_NUMBER() OVER (Order by dm_nhan_vien.ma_nhan_vien desc) as stt,ma_nhan_vien,ten_nhan_vien,dia_chi,dien_thoai,cmnd,chucvu,nam_sinh  from dm_nhan_vien order by ma_nhan_vien desc"
			Dim kq As Boolean = data.ExcuteNonQuery(sql, Nothing)
			If kq = False Then
				i = 1
			End If
			Return i
		End Function
		'IN XE
		Public Function _Luu_Data_Xe_Rpt() As Integer
			Dim i As Integer = 0
			Dim sql As String = "Delete from rpt_xe Insert into rpt_xe(stt,ma_so_xe,loai_xe,trong_luong,nhan_hieu) select ROW_NUMBER() OVER (Order by dm_xe.ma_so_xe desc) as stt,ma_so_xe,loai_xe,trong_luong,nhan_hieu from dm_xe order by dm_xe.ma_so_xe desc"
			Dim kq As Boolean = data.ExcuteNonQuery(sql, Nothing)
			If kq = False Then
				i = 1
			End If
			Return i
		End Function
		'IN HOA DON
		Public Function _Luu_Data_Hoa_Don(dto As DTO_HoaDon) As Integer
			Dim i As Integer = 0
			Dim sql As String = "Delete from rpt_hoadon " & "Insert into rpt_hoadon(stt,ma_hoa_don,ma_khach_hang,ma_hop_dong,tenkhachhang,ngay_tao,tongkhoiluong,tongcuocvanchuyen,tu_ngay,den_ngay,diachi,sodienthoai,masotheu,fax,ngaybatdau,ngayketthuc,ma_bang_ke,ngay_van_chuyen,khoi_luong,don_gia_tan,don_gia_chuyen,noi_nhan,noi_giao,so_xe,ghi_chu) " & "select ROW_NUMBER() OVER (Order by dm_bang_ke.ma_bang_ke desc) as stt,dm_hoa_don.ma_hoa_don,dm_hoa_don.ma_khach_hang,dm_hoa_don.ma_hop_dong,dm_khach_hang.ten_khach_hang,dm_hoa_don.ngay_tao,tongkhoiluong,tongcuocvanchuyen,tu_ngay,den_ngay,dm_khach_hang.dia_chi,dm_khach_hang.dien_thoai,dm_khach_hang.ma_so_thue,fax,ngaybatdau,ngayketthuc,ma_bang_ke,ngay_van_chuyen,khoi_luong,don_gia_tan,don_gia_chuyen,noi_nhan,noi_giao,so_xe,ghi_chu " & "from dm_hoa_don,dm_khach_hang,dm_bang_ke,dm_hoa_don_chi_tiet,dm_hop_dong " & "where dm_hoa_don.ma_hoa_don=dm_hoa_don_chi_tiet.ma_hoa_don and dm_hoa_don_chi_tiet.mabangke=dm_bang_ke.ma_bang_ke and dm_bang_ke.makhachhang=dm_khach_hang.ma_khach_hang and dm_hop_dong.ma_hop_dong=dm_hoa_don.ma_hop_dong " & "and dm_hoa_don.ma_hoa_don=@mahd order by dm_bang_ke.ngay_tao desc"
			Dim para As SqlParameter() = {New SqlParameter("@mahd", dto.ma_hoa_don.Trim())}
			Dim kq As Boolean = data.ExcuteNonQuery(sql, para)
			If kq = False Then
				i = 1
			End If
			Return i
		End Function
	End Class
End Namespace

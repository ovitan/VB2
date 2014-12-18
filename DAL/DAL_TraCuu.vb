Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports QLDVVTHH.DTO
Imports System.Data
Imports System.Data.SqlClient

Namespace DAL
	Public Class DAL_TraCuu
		Private data As New ConnectData()
		'TIM KHACH HANG
		Public Function _Tim_KhachHang(dto As DTO_KhachHang) As DTO_KhachHang()
			Dim sql As String = "select * from dm_khach_hang where ma_khach_hang like '%" & dto.ma_khach_hang.Trim() & "%' and ten_khach_hang like N'%" & dto.ten_khach_hang.Trim() & "%'"
			Dim dt As DataTable = data.ExcuteDataTable(sql, Nothing)
			If dt.Rows.Count > 0 Then
				Dim khachhang As DTO_KhachHang() = New DTO_KhachHang(dt.Rows.Count - 1) {}
				For i As Integer = 0 To dt.Rows.Count - 1
					khachhang(i) = New DTO_KhachHang()
					khachhang(i).ma_khach_hang = dt.Rows(i)("ma_khach_hang").ToString()
					khachhang(i).ten_khach_hang = dt.Rows(i)("ten_khach_hang").ToString()
					khachhang(i).ma_so_thue = dt.Rows(i)("ma_so_thue").ToString()
					khachhang(i).dia_chi = dt.Rows(i)("dia_chi").ToString()
					khachhang(i).dien_thoai = dt.Rows(i)("dien_thoai").ToString()
					khachhang(i).fax = dt.Rows(i)("fax").ToString()
				Next
				Return khachhang
			End If
			Return Nothing
		End Function
		'TIM NHAN VIEN
		Public Function _Tim_NhanVien(dto As DTO_NhanVien) As DTO_NhanVien()
			Dim sql As String = "select * from dm_nhan_vien where  ma_nhan_vien like '%" & dto.ma_nhan_vien.Trim() & "%' and ten_nhan_vien like N'%" & dto.ten_nhan_vien.Trim() & "%' "
			Dim dt As DataTable = data.ExcuteDataTable(sql, Nothing)
			If dt.Rows.Count > 0 Then
				Dim khachhang As DTO_NhanVien() = New DTO_NhanVien(dt.Rows.Count - 1) {}
				For i As Integer = 0 To dt.Rows.Count - 1
					khachhang(i) = New DTO_NhanVien()
					khachhang(i).ma_nhan_vien = dt.Rows(i)("ma_nhan_vien").ToString()
					khachhang(i).ten_nhan_vien = dt.Rows(i)("ten_nhan_vien").ToString()
					khachhang(i).cmnd = dt.Rows(i)("cmnd").ToString()
					khachhang(i).dia_chi = dt.Rows(i)("dia_chi").ToString()
					khachhang(i).dien_thoai = dt.Rows(i)("dien_thoai").ToString()
					khachhang(i).nam_sinh = Convert.ToDateTime(dt.Rows(i)("nam_sinh").ToString())
					khachhang(i).chucvu = dt.Rows(i)("chucvu").ToString()
				Next
				Return khachhang
			End If
			Return Nothing
		End Function
		'TIM THONG TIN XE
		Public Function _Tim_ThongTinXe(xe As DTO_Xe) As DTO_Xe()
			Dim sql As String = "select * from dm_xe,dm_tinh_trang_xe where dm_xe.ma_tinh_trang=dm_tinh_trang_xe.ma_tinh_trang and ma_so_xe like '%" & xe.ma_so_xe.Trim() & "%' "
			Dim dt As DataTable = data.ExcuteDataTable(sql, Nothing)
			If dt.Rows.Count > 0 Then
				Dim Xxe As DTO_Xe() = New DTO_Xe(dt.Rows.Count - 1) {}
				For i As Integer = 0 To dt.Rows.Count - 1
					Xxe(i) = New DTO_Xe()
					Xxe(i).ma_so_xe = dt.Rows(i)("ma_so_xe").ToString()
					Xxe(i).loai_xe = dt.Rows(i)("loai_xe").ToString()
					Xxe(i).trong_luong = Single.Parse(dt.Rows(i)("trong_luong").ToString())
					Xxe(i).nhan_hieu = dt.Rows(i)("nhan_hieu").ToString()
					Xxe(i).ten_tinh_trang = dt.Rows(i)("ten_tinh_trang").ToString()
					Xxe(i).ngay_tao = Convert.ToDateTime(dt.Rows(i)("ngay_tao").ToString())
				Next
				Return Xxe
			End If
			Return Nothing
		End Function
		'TIM HOA DON
		Public Function _Tim_HoaDon(dto As DTO_HoaDon) As DTO_HoaDon()
			Dim sql As String = "declare @dem int " & "select @dem=COUNT(*)  from dm_hoa_don,dm_khach_hang,dm_hop_dong where dm_hoa_don.ma_khach_hang=dm_khach_hang.ma_khach_hang and dm_hop_dong.ma_hop_dong=dm_hoa_don.ma_hop_dong and ma_hoa_don like '%" & dto.ma_hoa_don.Trim() & "%' and dm_hop_dong.ma_hop_dong like '%%' and dm_khach_hang.ma_khach_hang like '%%' " & "if(@dem>0) " & "begin " & "select dm_hoa_don.*,ten_khach_hang  from dm_hoa_don,dm_khach_hang,dm_hop_dong where dm_hoa_don.ma_khach_hang=dm_khach_hang.ma_khach_hang and dm_hop_dong.ma_hop_dong=dm_hoa_don.ma_hop_dong and ma_hoa_don like '%" & dto.ma_hoa_don.Trim() & "%' and dm_hop_dong.ma_hop_dong like '%%' and dm_khach_hang.ma_khach_hang like '%%' " & "end " & "else " & "begin " & "select @dem=COUNT(*)  from dm_hoa_don,dm_khach_hang,dm_hop_dong where dm_hoa_don.ma_khach_hang=dm_khach_hang.ma_khach_hang and dm_hop_dong.ma_hop_dong=dm_hoa_don.ma_hop_dong and ma_hoa_don like '%%' and dm_hop_dong.ma_hop_dong like '%" & dto.ma_hoa_don.Trim() & "%' and dm_khach_hang.ma_khach_hang like '%%' " & "if(@dem>0) " & "begin " & "select dm_hoa_don.*,ten_khach_hang  from dm_hoa_don,dm_khach_hang,dm_hop_dong where dm_hoa_don.ma_khach_hang=dm_khach_hang.ma_khach_hang and dm_hop_dong.ma_hop_dong=dm_hoa_don.ma_hop_dong and ma_hoa_don like '%%' and dm_hop_dong.ma_hop_dong like '%" & dto.ma_hoa_don.Trim() & "%' and dm_khach_hang.ma_khach_hang like '%%' " & "end " & "else " & "begin " & "select dm_hoa_don.*,ten_khach_hang  from dm_hoa_don,dm_khach_hang,dm_hop_dong where dm_hoa_don.ma_khach_hang=dm_khach_hang.ma_khach_hang and dm_hop_dong.ma_hop_dong=dm_hoa_don.ma_hop_dong and ma_hoa_don like '%%' and dm_hop_dong.ma_hop_dong like '%%' and dm_khach_hang.ma_khach_hang like '%" & dto.ma_hoa_don.Trim() & "%' " & "end " & "end "
			Dim dt As DataTable = data.ExcuteDataTable(sql, Nothing)
			If dt.Rows.Count > 0 Then
				Dim Xxe As DTO_HoaDon() = New DTO_HoaDon(dt.Rows.Count - 1) {}
				For i As Integer = 0 To dt.Rows.Count - 1
					Xxe(i) = New DTO_HoaDon()
					Xxe(i).ma_hoa_don = dt.Rows(i)("ma_hoa_don").ToString()
					Xxe(i).ma_khach_hang = dt.Rows(i)("ma_khach_hang").ToString()
					Xxe(i).ma_hop_dong = dt.Rows(i)("ma_hop_dong").ToString()
					Xxe(i).tenkhachhang = dt.Rows(i)("ten_khach_hang").ToString()
					'Xxe[i].ngay_tao = Convert.ToDateTime(dt.Rows[i]["ngay_tao"].ToString());
					'Xxe[i].tu_ngay = Convert.ToDateTime(dt.Rows[i]["tu_ngay"].ToString());
					'Xxe[i].den_ngay = Convert.ToDateTime(dt.Rows[i]["den_ngay"].ToString());
					Xxe(i).tong_khoi_luong = Single.Parse(dt.Rows(i)("tongkhoiluong").ToString())
					Xxe(i).tong_cuot_van_chuyen = Single.Parse(dt.Rows(i)("tongcuocvanchuyen").ToString())
				Next
				Return Xxe
			End If
			Return Nothing
		End Function
		'TIM HOA DON
		Public Function _Tim_HopDong(dto As DTO_HopDong) As DTO_HopDong()
			Dim sql As String = "select dm_hop_dong.*,ten_khach_hang from dm_hop_dong,dm_khach_hang where dm_khach_hang.ma_khach_hang=dm_hop_dong.ma_khach_hang and ma_hop_dong like '%" & dto.ma_hop_dong.Trim() & "%' "
			Dim dt As DataTable = data.ExcuteDataTable(sql, Nothing)
			If dt.Rows.Count > 0 Then
				Dim hd As DTO_HopDong() = New DTO_HopDong(dt.Rows.Count - 1) {}
				For i As Integer = 0 To dt.Rows.Count - 1
					hd(i) = New DTO_HopDong()
					hd(i).ma_hop_dong = dt.Rows(i)("ma_hop_dong").ToString()
					hd(i).ma_khach_hang = dt.Rows(i)("ma_khach_hang").ToString()
					hd(i).ngay_tao = Convert.ToDateTime(dt.Rows(i)("ngay_tao").ToString())
					hd(i).ngay_bat_dau = Convert.ToDateTime(dt.Rows(i)("ngaybatdau").ToString())
					hd(i).ngay_ket_thuc = Convert.ToDateTime(dt.Rows(i)("ngayketthuc").ToString())
					hd(i).loaihanghoa = dt.Rows(i)("loaihanghoa").ToString()
					hd(i).lotrinhvanchuyen = dt.Rows(i)("lotrinhvanchuyen").ToString()
					hd(i).phuongthucvanchuyen = dt.Rows(i)("phuongthucvanchuyen").ToString()
					hd(i).giatrihopdong = dt.Rows(i)("giatrihopdong").ToString()
					hd(i).phuongthucthanhtoan = dt.Rows(i)("phuongthucthanhtoan").ToString()
					hd(i).ten_khach_hang = dt.Rows(i)("ten_khach_hang").ToString()
				Next
				Return hd
			End If
			Return Nothing
		End Function
	End Class
End Namespace

Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports QLDVVTHH.DTO
Imports System.Data
Imports System.Data.SqlClient
Namespace DAL
	Public Class DAL_BangKe
		Private data As New ConnectData()
		Public Function _Them_BangKe(dto As DTO_BangKe) As Integer
			Dim i As Integer = 0
			Try
				Dim sql As String = "insert into dm_bang_ke(ma_dieu_xe,ma_bang_ke,ma_khach_hang,so_xe,ngay_van_chuyen,noi_nhan,noi_giao,khoi_luong,don_gia_tan,don_gia_chuyen,ghi_chu) values(@ma_dieu_xe,@mabangke,@makh,@soxe,@ngayvanchuyen,@noinhan,@noigiao,@khoiluong,@dongiatan,@dongiachuyen,@ghichu) "
				Dim prs As SqlParameter() = {New SqlParameter("@ma_dieu_xe", dto.ma_dieu_xe.Trim()), New SqlParameter("@mabangke", dto.ma_bang_ke.Trim()), New SqlParameter("@makh", dto.ma_khach_hang.Trim()), New SqlParameter("@soxe", dto.so_xe.Trim()), New SqlParameter("@ngayvanchuyen", dto.ngay_van_chuyen), New SqlParameter("@noinhan", dto.noi_nhan.Trim()), _
					New SqlParameter("@noigiao", dto.noi_giao.Trim()), New SqlParameter("@khoiluong", dto.khoi_luong), New SqlParameter("@dongiatan", dto.don_gia_tan), New SqlParameter("@dongiachuyen", dto.don_gia_chuyen), New SqlParameter("@ghichu", dto.ghi_chu)}
				data.ExcuteNonQuery(sql, prs)
			Catch
				i = 1
			End Try
			Return i
		End Function
		Public Function _List_Hop_Dong(hd As DTO_HopDong) As DataTable
			Dim sql As String = "select ma_hop_dong from dm_hop_dong where ma_khach_hang=@mahd order by ma_hop_dong desc"
			Dim prs As SqlParameter() = {New SqlParameter("@mahd", hd.ma_khach_hang.Trim())}
			Return data.ExcuteDataTable(sql, prs)
		End Function
		Public Function _Ma_Bang_Ke() As [String]
			Dim ma As String = DateTime.Now.Day.ToString()
			If DateTime.Now.Month.ToString().Length > 1 Then
				ma += DateTime.Now.Month.ToString()
			Else
				ma += "0" & DateTime.Now.Month.ToString()
			End If
			ma += DateTime.Now.Year.ToString().Substring(2, 2)
			Return New DAL_Systems().CreateIDCode(ma, "ma_bang_ke", "dm_bang_ke", 10)
		End Function
		Public Function _DanhSachBangKe_TheoMaKhachHang_MaHopDong(dto As DTO_BangKe) As DTO_BangKe()
			Dim sql As String = "select ma_bang_ke,dm_bang_ke.ma_khach_hang,ma_dieu_xe,so_xe,ngay_van_chuyen,khoi_luong,noi_nhan,noi_giao,ghi_chu,don_gia_chuyen,don_gia_tan from dm_bang_ke,dm_hop_dong where dm_bang_ke.ma_khach_hang=dm_hop_dong.ma_khach_hang and ngay_van_chuyen >= dm_hop_dong.ngay_bat_dau and ngay_van_chuyen<= ngay_ket_thuc and dm_bang_ke.ma_khach_hang=@mkh and ma_hop_dong=@mahd order by ngay_van_chuyen desc"
			Dim prs As SqlParameter() = {New SqlParameter("@mkh", dto.ma_khach_hang.Trim()), New SqlParameter("@mahd", dto.ma_bang_ke.Trim())}
			Dim dt As DataTable = data.ExcuteDataTable(sql, prs)
			If dt.Rows.Count > 0 Then
				Dim BangKe As DTO_BangKe() = New DTO_BangKe(dt.Rows.Count - 1) {}
				For i As Integer = 0 To dt.Rows.Count - 1
					BangKe(i) = New DTO_BangKe()
					BangKe(i).ma_bang_ke = dt.Rows(i)("ma_bang_ke").ToString()
					BangKe(i).ma_dieu_xe = dt.Rows(i)("ma_dieu_xe").ToString()
					BangKe(i).ma_khach_hang = dt.Rows(i)("ma_khach_hang").ToString()
					BangKe(i).ngay_van_chuyen = Convert.ToDateTime(dt.Rows(i)("ngay_van_chuyen").ToString())
					BangKe(i).khoi_luong = Single.Parse(dt.Rows(i)("khoi_luong").ToString())
					BangKe(i).noi_nhan = dt.Rows(i)("noi_nhan").ToString()
					BangKe(i).noi_giao = dt.Rows(i)("noi_giao").ToString()
					BangKe(i).so_xe = dt.Rows(i)("so_xe").ToString()
					BangKe(i).don_gia_tan = Single.Parse(dt.Rows(i)("don_gia_tan").ToString())
					BangKe(i).don_gia_chuyen = Single.Parse(dt.Rows(i)("don_gia_chuyen").ToString())
					BangKe(i).ghi_chu = dt.Rows(i)("ghi_chu").ToString()
				Next
				Return BangKe
			End If
			Return Nothing
		End Function
		Public Function _CapNhat_BangKe(dto As DTO_BangKe) As Integer
			Dim i As Integer = 0
			Dim query As String = "select * from dm_hoa_don_chi_tiet where ma_bang_ke=@mabangke"
			Dim qpr As SqlParameter() = {New SqlParameter("@mabangke", dto.ma_bang_ke.Trim())}
			Dim dt As DataTable = data.ExcuteDataTable(query, qpr)
			If dt.Rows.Count > 0 Then
				i = 1
			End If
			If i = 0 Then
				Dim sql As String = "update dm_bang_ke set ma_dieu_xe=@madieuxe,khoi_luong=@khoi_luong,ngay_van_chuyen=@ngay_van_chuyen,noi_giao=@noi_giao,noi_nhan=@noi_nhan,don_gia_tan=@don_gia_tan,don_gia_chuyen=@don_gia_chuyen,ghi_chu=@ghi_chu,so_xe=@so_xe where ma_khach_hang=@makhachhang and ma_bang_ke=@ma_bang_ke "
				Dim prs As SqlParameter() = {New SqlParameter("@madieuxe", dto.ma_dieu_xe.Trim()), New SqlParameter("@ma_bang_ke", dto.ma_bang_ke.Trim()), New SqlParameter("@makhachhang", dto.ma_khach_hang.Trim()), New SqlParameter("@so_xe", dto.so_xe.Trim()), New SqlParameter("@ngay_van_chuyen", dto.ngay_van_chuyen), New SqlParameter("@noi_nhan", dto.noi_nhan.Trim()), _
					New SqlParameter("@noi_giao", dto.noi_giao.Trim()), New SqlParameter("@khoi_luong", dto.khoi_luong), New SqlParameter("@don_gia_tan", dto.don_gia_tan), New SqlParameter("@don_gia_chuyen", dto.don_gia_chuyen), New SqlParameter("@ghi_chu", dto.ghi_chu)}
				data.ExcuteNonQuery(sql, prs)
			End If
			Return i
		End Function
		Public Function _Xoa_BangKe(dto As DTO_BangKe) As Integer
			Dim i As Integer = 0
			Dim query As String = "select * from dm_hoa_don_chi_tiet where ma_bang_ke=@mabangke"
			Dim qpr As SqlParameter() = {New SqlParameter("@mabangke", dto.ma_bang_ke.Trim())}
			Dim dt As DataTable = data.ExcuteDataTable(query, qpr)
			If dt.Rows.Count > 0 Then
				i = 1
			End If
			Dim query2 As String = "select * from dm_bang_ke where ma_bang_ke=@mabangke"
			Dim qpr2 As SqlParameter() = {New SqlParameter("@mabangke", dto.ma_bang_ke.Trim())}
			Dim dt2 As DataTable = data.ExcuteDataTable(query2, qpr2)
			If dt2.Rows.Count = 0 Then
				i = 2
			End If
			If i = 0 Then
				Dim sql As String = "delete from dm_bang_ke where ma_bang_ke=@ma_bang_ke"
				Dim prs As SqlParameter() = {New SqlParameter("@ma_bang_ke", dto.ma_bang_ke.Trim())}
				data.ExcuteNonQuery(sql, prs)
			End If
			Return i
		End Function
		Public Function _Tim_BangKe(bangke__1 As DTO_BangKe, hopdong As DTO_HopDong, khachhang As DTO_KhachHang) As DTO_BangKe()
			Dim truyvan As String = ""
			If khachhang.ma_khach_hang.Trim() <> "" Then
				truyvan += "and dm_khach_hang.ma_khach_hang=@mkh "
			End If
			If khachhang.ten_khach_hang.Trim() <> "" Then
				truyvan += "and ten_khach_hang like N'%" & khachhang.ten_khach_hang.Trim() & "%' "
			End If
			If hopdong.ma_hop_dong.Trim() <> "" Then
				truyvan += "and ngay_van_chuyen >= dm_hop_dong.ngay_bat_dau and ngay_van_chuyen<= dm_hop_dong.ngay_ket_thuc "
			End If
			If bangke__1.ma_bang_ke.Trim() <> "" Then
				truyvan += "and ma_bang_ke=@mbk "
			End If
			If bangke__1.so_xe.Trim() <> "" Then
				truyvan += "and so_xe like N'%" & bangke__1.so_xe.Trim() & "%' "
			End If
			If bangke__1.noi_nhan.Trim() <> "" Then
				truyvan += "and noi_nhan like N'%" & bangke__1.noi_nhan.Trim() & "%' "
			End If
			If bangke__1.noi_giao.Trim() <> "" Then
				truyvan += "and noi_giao like N'%" & bangke__1.noi_giao.Trim() & "%'"
			End If
			If bangke__1.khoi_luong.ToString().Trim() <> "" AndAlso bangke__1.khoi_luong > 0 Then
				truyvan += "and khoi_luong like N'%" & bangke__1.khoi_luong.ToString().Trim() & "%'"
			End If
			If bangke__1.don_gia_chuyen.ToString().Trim() <> "" AndAlso bangke__1.don_gia_chuyen > 0 Then
				truyvan += "and don_gia_chuyen like N'%" & bangke__1.don_gia_chuyen.ToString().Trim() & "%'"
			End If
			If bangke__1.don_gia_tan.ToString().Trim() <> "" AndAlso bangke__1.don_gia_tan > 0 Then
				truyvan += "and don_gia_tan like N'%" & bangke__1.don_gia_tan.ToString().Trim() & "%' "
			End If
			If bangke__1.ghi_chu.Trim() <> "" Then
				truyvan += "and ghi_chu like N'%" & bangke__1.ghi_chu.Trim() & "%'"
			End If
			Dim sql As String = "select distinct ma_bang_ke,ma_dieu_xe,dm_khach_hang.ma_khach_hang,so_xe,ngay_van_chuyen,khoi_luong,noi_nhan,noi_giao,ghi_chu,don_gia_chuyen,don_gia_tan " & "from dm_bang_ke,dm_hop_dong,dm_khach_hang " & "where dm_khach_hang.ma_khach_hang=dm_bang_ke.ma_khach_hang and dm_hop_dong.ma_khach_hang=dm_khach_hang.ma_khach_hang " & truyvan & " and dm_hop_dong.ma_hop_dong=@mhd and ngay_van_chuyen<= @ngayvanchuyen order by ngay_van_chuyen desc"
			Dim prs As SqlParameter() = {New SqlParameter("@mkh", khachhang.ma_khach_hang.Trim()), New SqlParameter("@mbk", bangke__1.ma_bang_ke.Trim()), New SqlParameter("@mhd", hopdong.ma_hop_dong.Trim()), New SqlParameter("@ngayvanchuyen", bangke__1.ngay_van_chuyen)}
			Dim dt As DataTable = data.ExcuteDataTable(sql, prs)
			If dt.Rows.Count > 0 Then
				Dim BangKe__2 As DTO_BangKe() = New DTO_BangKe(dt.Rows.Count - 1) {}
				For i As Integer = 0 To dt.Rows.Count - 1
					BangKe__2(i) = New DTO_BangKe()
					BangKe__2(i).ma_bang_ke = dt.Rows(i)("ma_bang_ke").ToString()
					BangKe__2(i).ma_dieu_xe = dt.Rows(i)("ma_dieu_xe").ToString()
					BangKe__2(i).ma_khach_hang = dt.Rows(i)("ma_khach_hang").ToString()
					BangKe__2(i).ngay_van_chuyen = Convert.ToDateTime(dt.Rows(i)("ngay_van_chuyen").ToString())
					BangKe__2(i).khoi_luong = Single.Parse(dt.Rows(i)("khoi_luong").ToString())
					BangKe__2(i).noi_nhan = dt.Rows(i)("noi_nhan").ToString()
					BangKe__2(i).noi_giao = dt.Rows(i)("noi_giao").ToString()
					BangKe__2(i).so_xe = dt.Rows(i)("so_xe").ToString()
					BangKe__2(i).don_gia_tan = Single.Parse(dt.Rows(i)("don_gia_tan").ToString())
					BangKe__2(i).don_gia_chuyen = Single.Parse(dt.Rows(i)("don_gia_chuyen").ToString())
					BangKe__2(i).ghi_chu = dt.Rows(i)("ghi_chu").ToString()
				Next
				Return BangKe__2
			End If
			Return Nothing
		End Function
		Public Function _List_Ten_Khach_Hang() As DataTable
			Dim sql As String = "select ten_khach_hang,ma_khach_hang from dm_khach_hang order by ma_khach_hang desc"
			Return data.ExcuteDataTable(sql, Nothing)
		End Function
		Public Function _List_Ma_Dieu_Xe(_xe As DTO_DieuXe) As DTO_DieuXe()
			'string sql = "select ma_dieu_xe,ma_so_xe,dm_dieu_xe.noi_nhan,dm_dieu_xe.noi_giao,so_tan,ngay_dieu_xe,don_gia_tan,don_gia_chuyen from dm_dieu_xe,dm_bang_bao_gia where ma_khach_hang=@mkh and dm_bang_bao_gia.noi_nhan=dm_dieu_xe.noi_nhan and dm_bang_bao_gia.noi_giao=dm_dieu_xe.noi_giao and ngay_ve is not NULL and tinh_trang_thanh_toan=0 and ma_dieu_xe not in (select distinct ma_dieu_xe from dm_bang_ke where dm_bang_ke.ma_khach_hang=@mkh ) "; //and ngay_ve=NULL and tinh_trang_thanh_toan=NULL;
			Dim sql As String = "select distinct ma_dieu_xe,dm_dieu_xe.noi_nhan,dm_dieu_xe.noi_giao,sum(so_tan) as so_tan,ngay_dieu_xe,don_gia_tan,don_gia_chuyen " & "from dm_dieu_xe,dm_bang_bao_gia " & "where ma_khach_hang=@mkh and dm_bang_bao_gia.noi_nhan=dm_dieu_xe.noi_nhan and dm_bang_bao_gia.noi_giao=dm_dieu_xe.noi_giao " & "and ngay_ve is not NULL and tinh_trang_thanh_toan=0 and ma_dieu_xe  " & "not in (select distinct ma_dieu_xe from dm_bang_ke where dm_bang_ke.ma_khach_hang=@mkh ) " & "group by ma_dieu_xe,dm_dieu_xe.noi_nhan,dm_dieu_xe.noi_giao,ngay_dieu_xe,don_gia_tan,don_gia_chuyen "
			Dim prs As SqlParameter() = {New SqlParameter("@mkh", _xe.ma_khach_hang.Trim())}
			Dim dt As DataTable = data.ExcuteDataTable(sql, prs)
			If dt.Rows.Count > 0 Then
				Dim _xx As DTO_DieuXe() = New DTO_DieuXe(dt.Rows.Count - 1) {}
				For i As Integer = 0 To dt.Rows.Count - 1
					_xx(i) = New DTO_DieuXe()
					_xx(i).ma_dieu_xe = dt.Rows(i)("ma_dieu_xe").ToString()
					Dim msx As String = "select ma_so_xe from dm_dieu_xe,dm_bang_bao_gia where ma_khach_hang='" & _xe.ma_khach_hang.Trim() & "' and dm_bang_bao_gia.noi_nhan=dm_dieu_xe.noi_nhan and dm_bang_bao_gia.noi_giao=dm_dieu_xe.noi_giao and ngay_ve is not NULL and tinh_trang_thanh_toan=0 and ma_dieu_xe='" & _xx(i).ma_dieu_xe.Trim() & "'"
					Dim dtt As DataTable = data.ExcuteDataTable(msx, Nothing)
					For Each dr As DataRow In dtt.Rows
						_xx(i).ma_so_xe += dr("ma_so_xe").ToString().Trim() & " ; "
					Next
					_xx(i).noi_nhan = dt.Rows(i)("noi_nhan").ToString()
					_xx(i).noi_giao = dt.Rows(i)("noi_giao").ToString()
					_xx(i).so_tan = Single.Parse(dt.Rows(i)("so_tan").ToString()).ToString()
					_xx(i).ngay_dieu_xe = Convert.ToDateTime(dt.Rows(i)("ngay_dieu_xe").ToString())
					_xx(i).don_gia_tan = Single.Parse(dt.Rows(i)("don_gia_tan").ToString())
					_xx(i).don_gia_chuyen = Single.Parse(dt.Rows(i)("don_gia_chuyen").ToString())
				Next
				Return _xx
			End If
			Return Nothing
		End Function
	End Class
End Namespace

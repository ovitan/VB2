Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports QLDVVTHH.DTO
Imports System.Data
Imports System.Data.SqlClient

Namespace DAL
	Public Class DAL_HoaDon
		Private data As New ConnectData()
		Public Function _Ma_Hoa_Don() As String
			Dim ma As String = ""
			If DateTime.Now.Month.ToString().Length > 1 Then
				ma += DateTime.Now.Month.ToString()
			Else
				ma += "0" & DateTime.Now.Month.ToString()
			End If
			ma += DateTime.Now.Year.ToString().Substring(2, 2)
			Return New DAL_Systems().CreateIDCode(ma, "so_hoa_don", "dm_hoa_don", 7)
		End Function

		Public Function _Lap_Hoa_Hon_Van_Chuyen(hopdong As DTO_HopDong, hoadon As DTO_HoaDon) As Integer
			Dim i As Integer = 0

			Dim kt As String = "select * from dm_hoa_don where so_hoa_don=@mhhd "
			Dim ktpara As SqlParameter() = {New SqlParameter("@mhhd", hoadon.ma_hoa_don.Trim())}
			Dim dtkt As DataTable = data.ExcuteDataTable(kt, ktpara)
			If dtkt.Rows.Count > 0 Then
				Return InlineAssignHelper(i, 2)
			End If

			Dim ngayxuathd As String = "select top 1 * from dm_hoa_don where ma_hop_dong=@mhd order by ngay_xuat desc"
			Dim kthd As SqlParameter() = {New SqlParameter("@mhd", hopdong.ma_hop_dong.Trim())}
			Dim dtkthd As DataTable = data.ExcuteDataTable(ngayxuathd, kthd)

			Dim ngayvc As String = "ngay_van_chuyen<=@ngayxuathoadon "
			Dim ngaygioihan As DateTime = DateTime.Now
			If dtkthd.Rows.Count > 0 Then
				For Each dr As DataRow In dtkthd.Rows
					ngayvc = "ngay_van_chuyen<=@ngayxuathoadon and ngay_van_chuyen >@gioihanngay "
					ngaygioihan = Convert.ToDateTime(dr("ngay_xuat").ToString())
				Next
			End If

			Dim query1 As String = "select * " & "from " & "(select dm_bang_ke.* " & "from dm_bang_ke,dm_hop_dong " & "where dm_bang_ke.ma_khach_hang=dm_hop_dong.ma_khach_hang " & "and ngay_van_chuyen>=ngay_bat_dau and ngay_van_chuyen <= ngay_ket_thuc " & "and dm_bang_ke.ma_khach_hang=@mkh " & "and ma_hop_dong=@mhd) as KQ " & "where  " & ngayvc
			Dim para1 As SqlParameter() = {New SqlParameter("@mkh", hopdong.ma_khach_hang.Trim()), New SqlParameter("@mhd", hopdong.ma_hop_dong.Trim()), New SqlParameter("@ngayxuathoadon", hoadon.ngay_Xuat_hoa_don), New SqlParameter("@gioihanngay", ngaygioihan)}
			Dim KQ_BangKe As DataTable = data.ExcuteDataTable(query1, para1)
			Dim tongkhoiluong As Single = 0
			Dim tongthanhtien As Single = 0
			If KQ_BangKe IsNot Nothing AndAlso KQ_BangKe.Rows.Count > 0 Then
				For Each dr As DataRow In KQ_BangKe.Rows
					tongkhoiluong += Single.Parse(dr("khoi_luong").ToString())
					tongthanhtien += (Single.Parse(dr("don_gia_chuyen").ToString()) + (If((Single.Parse(dr("khoi_luong").ToString()) > 15), (Single.Parse(dr("khoi_luong").ToString()) - 15) * (Single.Parse(dr("don_gia_tan").ToString())), 0)))
				Next
			End If
			Dim tongthanhtiensau_theu As Single = (tongthanhtien) + (tongthanhtien * 10 / 100)

			Dim sql As String = "insert into dm_hoa_don(so_hoa_don,ma_hop_dong,ma_khach_hang,tongcuocvanchuyen,ngay_xuat,thue,tong_cong)" & " values (@ma_hoa_don,@ma_hop_dong,@ma_khach_hang,@tongcuocvanchuyen,@ngay_xuat,@thue,@tong_cong) "
			Dim para2 As SqlParameter() = {New SqlParameter("@ma_hoa_don", hoadon.ma_hoa_don.Trim()), New SqlParameter("@ma_hop_dong", hopdong.ma_hop_dong.Trim()), New SqlParameter("@ma_khach_hang", hopdong.ma_khach_hang), New SqlParameter("@tongcuocvanchuyen", tongthanhtien), New SqlParameter("@ngay_xuat", hoadon.ngay_Xuat_hoa_don), New SqlParameter("@thue", (tongthanhtien * 10 / 100)), _
				New SqlParameter("@tong_cong", tongthanhtiensau_theu)}
			Dim kq As Boolean = data.ExcuteNonQuery(sql, para2)
			If kq = True Then
				Dim insertquey As String = "insert into dm_hoa_don_chi_tiet(ma_hoa_don,ma_bang_ke) values (@ma_hoa_don,@mabangke)"
				Dim kq2 As Boolean = True
				For Each dr_i As DataRow In KQ_BangKe.Rows
					Dim para3 As SqlParameter() = {New SqlParameter("@ma_hoa_don", hoadon.ma_hoa_don.Trim()), New SqlParameter("@mabangke", dr_i("ma_bang_ke").ToString())}
					kq2 = data.ExcuteNonQuery(insertquey, para3)
				Next
				If kq2 = False Then
					i = 1
				End If
			End If
			Return i
		End Function

		Public Function _List_Hoa_Hon_Van_Chuyen(hoadon As DTO_HoaDon) As DTO_HoaDon()
			Dim sql As String = "select * from dm_hoa_don where ma_khach_hang=@mkh and ma_hop_dong=@mhd order by ngay_xuat desc"
			Dim para As SqlParameter() = {New SqlParameter("@mkh", hoadon.ma_khach_hang.Trim()), New SqlParameter("@mhd", hoadon.ma_hop_dong.Trim())}
			Dim dt As DataTable = data.ExcuteDataTable(sql, para)
			If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
				Dim dto As DTO_HoaDon() = New DTO_HoaDon(dt.Rows.Count - 1) {}
				For i As Integer = 0 To dt.Rows.Count - 1
					dto(i) = New DTO_HoaDon()
					dto(i).ma_hoa_don = dt.Rows(i)("so_hoa_don").ToString()
					dto(i).ma_hop_dong = dt.Rows(i)("ma_hop_dong").ToString()
					dto(i).ma_khach_hang = dt.Rows(i)("ma_khach_hang").ToString()
					'dto[i].tong_khoi_luong = float.Parse(dt.Rows[i]["tongkhoiluong"].ToString());
					dto(i).tong_cuot_van_chuyen = Single.Parse(dt.Rows(i)("tongcuocvanchuyen").ToString())
					dto(i).theu = Single.Parse(dt.Rows(i)("thue").ToString())
					dto(i).tong_cong = Single.Parse(dt.Rows(i)("tong_cong").ToString())
					dto(i).ngay_Xuat_hoa_don = Convert.ToDateTime(dt.Rows(i)("ngay_xuat").ToString())
				Next
				Return dto
			End If
			Return Nothing
		End Function

		Public Function _List_Chi_Tiet_Hoa_Hon_Van_Chuyen(ct As DTO_Chi_Tiet_Hoa_Don) As DTO_BangKe()
			Dim sql As String = "select dm_bang_ke.* from dm_bang_ke,dm_hoa_don_chi_tiet where dm_bang_ke.ma_bang_ke=dm_hoa_don_chi_tiet.ma_bang_ke and ma_hoa_don=@mhd "
			Dim prs As SqlParameter() = {New SqlParameter("@mhd", ct.ma_hoa_don.Trim())}
			Dim dt As DataTable = data.ExcuteDataTable(sql, prs)
			If dt.Rows.Count > 0 Then
				Dim BangKe As DTO_BangKe() = New DTO_BangKe(dt.Rows.Count - 1) {}
				For i As Integer = 0 To dt.Rows.Count - 1
					BangKe(i) = New DTO_BangKe()
					BangKe(i).ma_bang_ke = dt.Rows(i)("ma_bang_ke").ToString()
					BangKe(i).ma_khach_hang = dt.Rows(i)("ma_khach_hang").ToString()
					BangKe(i).ngay_van_chuyen = Convert.ToDateTime(dt.Rows(i)("ngay_van_chuyen").ToString())
					BangKe(i).khoi_luong = Single.Parse(dt.Rows(i)("khoi_luong").ToString())
					BangKe(i).noi_nhan = dt.Rows(i)("noi_nhan").ToString()
					BangKe(i).noi_giao = dt.Rows(i)("noi_giao").ToString()
					BangKe(i).don_gia_tan = Single.Parse(dt.Rows(i)("don_gia_tan").ToString())
					BangKe(i).don_gia_chuyen = Single.Parse(dt.Rows(i)("don_gia_chuyen").ToString())
					BangKe(i).ghi_chu = dt.Rows(i)("ghi_chu").ToString()
					BangKe(i).ma_dieu_xe = dt.Rows(i)("ma_dieu_xe").ToString()
					Dim msx As String = "select ma_so_xe from dm_dieu_xe,dm_bang_bao_gia where ma_khach_hang='" & ct.ma_khach_hang.Trim() & "' and dm_bang_bao_gia.noi_nhan=dm_dieu_xe.noi_nhan and dm_bang_bao_gia.noi_giao=dm_dieu_xe.noi_giao and ngay_ve is not NULL and tinh_trang_thanh_toan=0 and ma_dieu_xe='" & dt.Rows(i)("ma_dieu_xe").ToString().Trim() & "'"
					Dim dtt As DataTable = data.ExcuteDataTable(msx, Nothing)
					For Each dr As DataRow In dtt.Rows
						BangKe(i).so_xe += dr("ma_so_xe").ToString().Trim() & " ; "
					Next
				Next
				Return BangKe
			End If
			Return Nothing
		End Function

		Public Function _Xoa_Hoa_Don_Van_Chuyen(hoadon As DTO_HoaDon) As Integer
			Dim i As Integer = 0
			Dim sql As String = "delete from dm_hoa_don_chi_tiet where ma_hoa_don=@mhd delete from dm_hoa_don where so_hoa_don=@mhd "
			Dim para As SqlParameter() = {New SqlParameter("@mhd", hoadon.ma_hoa_don.Trim())}
			Dim kq As Boolean = data.ExcuteNonQuery(sql, para)
			If kq = False Then
				i = 1
			End If
			Return i
		End Function

		Public Function _Tim_Hoa_Hon_Van_Chuyen(hoadon As DTO_HoaDon) As DTO_HoaDon()
			Dim query As String = ""
			If hoadon.ma_khach_hang.Trim() <> "" Then
				query = " ma_khach_hang=@mkh "
			End If
			If hoadon.ma_hop_dong.Trim() <> "" Then
				query += (If(String.IsNullOrEmpty(query), "", " and "))
				query += " ma_hop_dong=@mhd "
			End If
			If hoadon.ma_hoa_don.Trim() <> "" Then
				query += (If(String.IsNullOrEmpty(query), "", " and "))
				query += " so_hoa_don=@mahd "
			End If
			Dim sql As String = "select * from dm_hoa_don where " & query & " order by ngay_xuat desc"
			Dim para As SqlParameter() = {New SqlParameter("@mkh", hoadon.ma_khach_hang.Trim()), New SqlParameter("@mhd", hoadon.ma_hop_dong.Trim()), New SqlParameter("@mahd", hoadon.ma_hoa_don.Trim())}
			Dim dt As DataTable = data.ExcuteDataTable(sql, para)
			If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
				Dim dto As DTO_HoaDon() = New DTO_HoaDon(dt.Rows.Count - 1) {}
				For i As Integer = 0 To dt.Rows.Count - 1
					dto(i) = New DTO_HoaDon()
					dto(i).ma_hoa_don = dt.Rows(i)("so_hoa_don").ToString()
					dto(i).ma_hop_dong = dt.Rows(i)("ma_hop_dong").ToString()
					dto(i).ma_khach_hang = dt.Rows(i)("ma_khach_hang").ToString()
					dto(i).tong_cuot_van_chuyen = Single.Parse(dt.Rows(i)("tongcuocvanchuyen").ToString())
					dto(i).theu = Single.Parse(dt.Rows(i)("thue").ToString())
					dto(i).tong_cong = Single.Parse(dt.Rows(i)("tong_cong").ToString())
					dto(i).ngay_Xuat_hoa_don = Convert.ToDateTime(dt.Rows(i)("ngay_xuat").ToString())
				Next
				Return dto
			End If
			Return Nothing
		End Function

		Public Function _List_Hoa_Don(hoadon As DTO_HoaDon) As DTO_HoaDon()
			Dim sql As String = "select ma_hoa_don,ngay_tao,tongcuocvanchuyen from dm_hoa_don where ma_khach_hang =@mkh and ma_hop_dong=@mhd "

			Dim para As SqlParameter() = {New SqlParameter("@mkh", hoadon.ma_khach_hang.Trim()), New SqlParameter("@mhd", hoadon.ma_hop_dong.Trim())}
			Dim dt As DataTable = data.ExcuteDataTable(sql, para)
			If dt.Rows.Count > 0 Then
				Dim HOADON_LIST As DTO_HoaDon() = New DTO_HoaDon(dt.Rows.Count - 1) {}
				For i As Integer = 0 To dt.Rows.Count - 1
					HOADON_LIST(i) = New DTO_HoaDon()
					HOADON_LIST(i).ma_hoa_don = dt.Rows(i)("so_hoa_don").ToString()
					HOADON_LIST(i).tong_cuot_van_chuyen = Single.Parse(dt.Rows(i)("tongcuocvanchuyen").ToString())
				Next
				Return HOADON_LIST
			End If
			Return Nothing
		End Function
		Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
			target = value
			Return value
		End Function
	End Class
End Namespace

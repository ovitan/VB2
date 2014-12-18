Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports QLDVVTHH.DTO
Imports QLDVVTHH.DAL
Imports System.Data
Imports System.Data.SqlClient

Namespace DAL
	Public Class DAL_CongNo
		Private data As New ConnectData()

		Public Function _Ma_Cong_No() As String
			Return New DAL_Systems().CreateIDCode("NO", "ma_cong_no", "dm_cong_no", 5)
		End Function

		Public Function _List_Hoa_Don(hoadon As DTO_HoaDon) As DTO_HoaDon()
			Dim sql As String = "select so_hoa_don,ngay_xuat,tong_cong from dm_hoa_don where ma_khach_hang =@mkh and ma_hop_dong=@mhd and so_hoa_don not in (select  dm_cong_no.so_hoa_don from dm_cong_no where dm_cong_no.ma_khach_hang=@mkh )"

			Dim para As SqlParameter() = {New SqlParameter("@mkh", hoadon.ma_khach_hang.Trim()), New SqlParameter("@mhd", hoadon.ma_hop_dong.Trim())}
			Dim dt As DataTable = data.ExcuteDataTable(sql, para)
			If dt.Rows.Count > 0 Then
				Dim HOADON_LIST As DTO_HoaDon() = New DTO_HoaDon(dt.Rows.Count - 1) {}
				For i As Integer = 0 To dt.Rows.Count - 1
					HOADON_LIST(i) = New DTO_HoaDon()
					HOADON_LIST(i).ma_hoa_don = dt.Rows(i)("so_hoa_don").ToString()
					HOADON_LIST(i).ngay_Xuat_hoa_don = Convert.ToDateTime(dt.Rows(i)("ngay_xuat").ToString())
					HOADON_LIST(i).tong_cuot_van_chuyen = Single.Parse(dt.Rows(i)("tong_cong").ToString())
				Next
				Return HOADON_LIST
			End If
			Return Nothing
		End Function

		Public Function _Them_Cong_No_Khach_Hang(hoadon As DTO_HoaDon, congno As DTO_CongNo) As Integer
			Dim i As Integer = 0
			Dim sql As String = "select * from dm_hoa_don where so_hoa_don=@mhd "
			Dim para As SqlParameter() = {New SqlParameter("@mhd", hoadon.ma_hoa_don.Trim())}
			Dim dt As DataTable = data.ExcuteDataTable(sql, para)
			If dt.Rows.Count > 0 Then
				For Each dr As DataRow In dt.Rows
					Dim insert As String = "insert into dm_cong_no(ma_cong_no,ma_khach_hang,so_hoa_don,so_tien_thanh_toan,ngay_xuat_hd)" & " values(@ma_cong_no,@ma_khach_hang,@so_hoa_don,@so_tien_thanh_toan,@ngay_xuat_hd)"
					Dim para2 As SqlParameter() = {New SqlParameter("@ma_cong_no", congno.ma_cong_no.Trim()), New SqlParameter("@ma_khach_hang", dr("ma_khach_hang").ToString()), New SqlParameter("@so_hoa_don", dr("so_hoa_don").ToString()), New SqlParameter("@so_tien_thanh_toan", Single.Parse(dr("tong_cong").ToString())), New SqlParameter("@ngay_xuat_hd", Convert.ToDateTime(dr("ngay_xuat").ToString()))}
					Dim kq As Boolean = data.ExcuteNonQuery(insert, para2)
					If kq = False Then
						i = 1
					End If
				Next
			End If
			Return i
		End Function

		Public Function _List_View_Cong_No_Khach_Hang(congno As DTO_CongNo) As DTO_CongNo()
			Dim sql As String = "select dm_cong_no.* from dm_cong_no,dm_hoa_don " & "where dm_cong_no.so_hoa_don=dm_hoa_don.so_hoa_don " & "and dm_cong_no.ma_khach_hang=@mkh and ma_hop_dong=@mhd "
			Dim para As SqlParameter() = {New SqlParameter("@mkh", congno.ma_khach_hang.Trim()), New SqlParameter("@mhd", congno.ma_cong_no.Trim())}
			Dim dt As DataTable = data.ExcuteDataTable(sql, para)
			If dt.Rows.Count > 0 Then
				Dim CONGNO_ As DTO_CongNo() = New DTO_CongNo(dt.Rows.Count - 1) {}
				For i As Integer = 0 To dt.Rows.Count - 1
					CONGNO_(i) = New DTO_CongNo()
					CONGNO_(i).ma_cong_no = dt.Rows(i)("ma_cong_no").ToString()
					CONGNO_(i).ma_khach_hang = dt.Rows(i)("ma_khach_hang").ToString()
					CONGNO_(i).ma_hoa_don = dt.Rows(i)("so_hoa_don").ToString()
					CONGNO_(i).so_tien_thanh_toan = Single.Parse(dt.Rows(i)("so_tien_thanh_toan").ToString())
					CONGNO_(i).ngay_xuat_hd = Convert.ToDateTime(dt.Rows(i)("ngay_xuat_hd").ToString())
				Next
				Return CONGNO_
			End If
			Return Nothing
		End Function

		Public Function _Xoa_Cong_No(congno As DTO_CongNo) As Integer
			Dim i As Integer = 0
			Dim sql As String = "delete from dm_cong_no where so_hoa_don=@mhd "
			Dim para As SqlParameter() = {New SqlParameter("@mhd", congno.ma_hoa_don.Trim())}
			Dim kq As Boolean = data.ExcuteNonQuery(sql, para)
			If kq = False Then
				i = 1
			End If
			Return i
		End Function

		Public Function _Them_Thanh_Toan_Cong_No(tt As DTO_ThanhToan) As Integer
			Dim i As Integer = 0
			Dim sql As String = "insert into dm_thanhtoan(ma_hop_dong,ma_khach_hang,dathanhtoan,ngay_thanh_toan) values(@mahopdong,@makhachhang,@sotienthanhtoan,@ngay_thanh_toan)"
			Dim para As SqlParameter() = {New SqlParameter("@mahopdong", tt.ma_hop_dong.Trim()), New SqlParameter("@makhachhang", tt.ma_khach_hang.Trim()), New SqlParameter("@sotienthanhtoan", tt.so_tien_thanh_toan), New SqlParameter("@ngay_thanh_toan", tt.ngay_thanh_toan)}
			Dim kq As Boolean = data.ExcuteNonQuery(sql, para)
			If kq = False Then
				i = 1
			End If
			Return i
		End Function

		Public Function _List_View_Thanh_Toan(tt As DTO_ThanhToan) As DTO_ThanhToan()
			Dim sql As String = "select * from  dm_thanhtoan where ma_hop_dong=@mhd and ma_khach_hang=@mkh "
			Dim para As SqlParameter() = {New SqlParameter("@mkh", tt.ma_khach_hang.Trim()), New SqlParameter("@mhd", tt.ma_hop_dong.Trim())}
			Dim dt As DataTable = data.ExcuteDataTable(sql, para)
			If dt.Rows.Count > 0 Then
				Dim THANHTOAN As DTO_ThanhToan() = New DTO_ThanhToan(dt.Rows.Count - 1) {}
				For i As Integer = 0 To dt.Rows.Count - 1
					THANHTOAN(i) = New DTO_ThanhToan()
					THANHTOAN(i).ma_hop_dong = dt.Rows(i)("ma_hop_dong").ToString()
					THANHTOAN(i).ma_khach_hang = dt.Rows(i)("ma_khach_hang").ToString()
					THANHTOAN(i).ngay_thanh_toan = Convert.ToDateTime(dt.Rows(i)("ngay_thanh_toan").ToString())
					THANHTOAN(i).so_tien_thanh_toan = Single.Parse(dt.Rows(i)("dathanhtoan").ToString())
					THANHTOAN(i).ma_thanh_toan = Integer.Parse(dt.Rows(i)("ma_thanh_toan").ToString())
				Next
				Return THANHTOAN
			End If
			Return Nothing
		End Function

		Public Function _Xoa_So_Tien_Thanh_Toan(tt As DTO_ThanhToan) As Integer
			Dim i As Integer = 0
			Dim sql As String = "delete from  dm_thanhtoan where ma_thanh_toan=@matt "
			Dim para As SqlParameter() = {New SqlParameter("@matt", tt.ma_thanh_toan)}
			Dim kq As Boolean = data.ExcuteNonQuery(sql, para)
			If kq = False Then
				i = 1
			End If
			Return i
		End Function

		Public Function _Thong_Ke_Cong_No(congno As DTO_CongNo) As DTO_CongNo()
			Dim sql As String = "select T1.ma_hop_dong,T1.ma_khach_hang,ten_khach_hang,TIENNO,TONGTRA  " & "from " & "(select dm_khach_hang.ma_khach_hang,dm_khach_hang.ten_khach_hang,dm_hoa_don.ma_hop_dong,SUM(so_tien_thanh_toan) as TIENNO " & "from dm_cong_no,dm_hoa_don,dm_khach_hang " & "where dm_cong_no.so_hoa_don=dm_hoa_don.so_hoa_don and dm_khach_hang.ma_khach_hang=dm_hoa_don.ma_khach_hang " & "group by dm_khach_hang.ma_khach_hang,dm_khach_hang.ten_khach_hang,dm_hoa_don.ma_hop_dong) as T1 " & "left outer join " & "(select ma_hop_dong,ma_khach_hang,SUM(dathanhtoan) as TONGTRA from dm_thanhtoan  " & "group by ma_hop_dong,ma_khach_hang) as T2 on T1.ma_khach_hang=T2.ma_khach_hang "
			Dim dt As DataTable = data.ExcuteDataTable(sql, Nothing)
			If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
				Dim CONGNO_ As DTO_CongNo() = New DTO_CongNo(dt.Rows.Count - 1) {}
				For i As Integer = 0 To dt.Rows.Count - 1
					CONGNO_(i) = New DTO_CongNo()
					CONGNO_(i).ma_hop_dong = dt.Rows(i)("ma_hop_dong").ToString()
					CONGNO_(i).ma_khach_hang = dt.Rows(i)("ma_khach_hang").ToString()
					CONGNO_(i).tongno = Single.Parse(dt.Rows(i)("TIENNO").ToString())
					CONGNO_(i).tongtra = Single.Parse("0" & dt.Rows(i)("TONGTRA").ToString())
					CONGNO_(i).tenkhachhang = dt.Rows(i)("ten_khach_hang").ToString()
				Next
				Return CONGNO_
			End If
			Return Nothing
		End Function
		Public Function _check_ma_hoa_don_cong_no(hd As DTO_HoaDon) As Integer
			Dim i As Integer = 0
			Dim sql As String = "select * from dm_cong_no where so_hoa_don=@shd and ma_khach_hang=@mkh"
			Dim para As SqlParameter() = {New SqlParameter("@shd", hd.ma_hoa_don.Trim()), New SqlParameter("@mkh", hd.ma_khach_hang)}
			Dim dt As DataTable = data.ExcuteDataTable(sql, para)
			If dt.Rows.Count > 0 Then
				i = 1
			End If
			Return i
		End Function
	End Class
End Namespace

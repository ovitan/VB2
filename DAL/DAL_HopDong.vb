Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient
Imports QLDVVTHH.DTO
Imports QLDVVTHH.DAL
Namespace DAL
	Public Class DAL_HopDong
		Private data As New ConnectData()
		Public Function _Bang_Ma_Khach_Hang() As DataTable
			Dim sql As String = "select ma_khach_hang from dm_khach_hang"
			Return data.ExcuteDataTable(sql, Nothing)
		End Function
		Public Function Ma_HD() As List(Of DTO_HopDong)
			Dim sql As String = "select ma_hop_dong from dm_hop_dong"
			'SqlDataReader dr = data.ExcuteDataReader(sql, null);
			'return data.MapDataReaderToObject<DTO_HopDong>(dr);
			Dim dt As DataTable = data.ExcuteDataTable(sql, Nothing)
			If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
				Dim _hdd As New List(Of DTO_HopDong)()
				For Each dr As DataRow In dt.Rows
					Dim hdd As New DTO_HopDong()
					hdd.ma_hop_dong = dr("ma_hop_dong").ToString()
					_hdd.Add(hdd)
				Next
				Return _hdd
			End If
			Return Nothing
		End Function
		Public Function GetAll_KH_HD_HH() As List(Of DTO_HopDong)
			Dim sql As String = "select A.ten_khach_hang, B.ma_hop_dong, B.loaihanghoa, A.ma_khach_hang from dm_khach_hang A join dm_hop_dong B on A.ma_khach_hang = B.ma_khach_hang order by B.ngay_tao desc"
			Dim dr As SqlDataReader = data.ExcuteDataReader(sql, Nothing)
			Return data.MapDataReaderToObject(Of DTO_HopDong)(dr)
		End Function
		Public Function GetAll_KH_ID(KHID As String) As List(Of DTO_HopDong)
			Dim sql As String = "select A.ten_khach_hang, B.ma_hop_dong, B.loaihanghoa, A.ma_khach_hang from dm_khach_hang A join dm_hop_dong B on A.ma_khach_hang = B.ma_khach_hang where B.ma_khach_hang = @ma_khach_hang"
			Dim prs As SqlParameter() = {New SqlParameter("@ma_khach_hang", KHID)}
			Dim dr As SqlDataReader = data.ExcuteDataReader(sql, prs)
			Return data.MapDataReaderToObject(Of DTO_HopDong)(dr)
		End Function
		Public Function _Ten_Khach_Hang_Theo_Ma_Khach_Hang(kh As DTO_KhachHang) As String
			Dim name As String = ""
			Dim sql As String = "select ten_khach_hang,ma_so_thue,dien_thoai,fax,dia_chi from dm_khach_hang where ma_khach_hang=@thamsoma"
			Dim prs As SqlParameter() = {New SqlParameter("@thamsoma", kh.ma_khach_hang.Trim())}
			Dim dt As DataTable = data.ExcuteDataTable(sql, prs)
			For Each dr As DataRow In dt.Rows
				name = "Mã Số Thuế :" & dr("ma_so_thue").ToString() & " - Số Điện Thoại : " & dr("dien_thoai").ToString() & " - Fax:" & dr("fax").ToString() & " - Địa Chỉ :" & dr("dia_chi").ToString()
			Next
			Return name
		End Function
		Public Function _Ma_Hop_Dong() As String
			Return New DAL_Systems().CreateIDCode("HD", "ma_hop_dong", "dm_hop_dong", 5)
		End Function
		Protected Function CreateIDCode(strID As String, field As String, table As String, length As Integer) As String
			Try
				Dim IDCode As String = strID & "000"
				Dim query As String = "select max(" & field.Trim() & ") from " & table.Trim() & " where left(" & field.Trim() & "," & strID.Length.ToString() & ")='" & strID.Trim() & "'"

				Dim dt As DataTable = data.ExcuteDataTable(query, Nothing)

				IDCode = dt.Rows(0)(0).ToString()

				IDCode = IDCode.Substring(strID.Length)
				IDCode = "0000000000000000" & Convert.ToString(Convert.ToInt64(IDCode) + 1)
				IDCode = strID & IDCode.Substring(IDCode.Length - length + strID.Length)

				Return IDCode
			Catch ex As Exception
				Throw
			End Try
		End Function
		Public Function _Them_Hop_Dong(hd As DTO_HopDong) As Integer
			Dim i As Integer = 0
			Try
				Dim sql As String = "insert into dm_hop_dong(ma_hop_dong,ma_khach_hang,ngay_tao,ngay_bat_dau,ngay_ket_thuc,loaihanghoa,lotrinhvanchuyen,phuongthucvanchuyen,giatrihopdong,phuongthucthanhtoan) " & "values (@ma_hop_dong,@ma_khach_hang,@ngay_tao,@ngaybatdau,@ngayketthuc,@loaihanghoa,@lotrinhvanchuyen,@phuongthucvanchuyen,@giatrihopdong,@phuongthucthanhtoan)"
				Dim prs As SqlParameter() = {New SqlParameter("@ma_hop_dong", hd.ma_hop_dong.Trim()), New SqlParameter("@ma_khach_hang", hd.ma_khach_hang.Trim()), New SqlParameter("@ngay_tao", hd.ngay_tao), New SqlParameter("@ngaybatdau", hd.ngay_bat_dau), New SqlParameter("@ngayketthuc", hd.ngay_ket_thuc), New SqlParameter("@loaihanghoa", hd.loaihanghoa), _
					New SqlParameter("@lotrinhvanchuyen", hd.lotrinhvanchuyen), New SqlParameter("@phuongthucvanchuyen", hd.phuongthucvanchuyen), New SqlParameter("@giatrihopdong", hd.giatrihopdong), New SqlParameter("@phuongthucthanhtoan", hd.phuongthucthanhtoan)}
				data.ExcuteNonQuery(sql, prs)
				i = 1
			Catch
				i = 0
			End Try
			Return i
		End Function
		Public Function _List_Hop_Dong_Cung_Khach_Hang(hd As DTO_HopDong) As DTO_HopDong()
			Dim sql As String = "select ma_hop_dong,dm_khach_hang.ma_khach_hang,ten_khach_hang,ngay_bat_dau,ngay_ket_thuc from dm_hop_dong,dm_khach_hang where dm_khach_hang.ma_khach_hang=dm_hop_dong.ma_khach_hang and dm_khach_hang.ma_khach_hang=@makh"
			Dim prs As SqlParameter() = {New SqlParameter("@makh", hd.ma_khach_hang.Trim())}
			Dim dt As DataTable = data.ExcuteDataTable(sql, prs)
			If dt.Rows.Count > 0 Then
				Dim hopdong As DTO_HopDong() = New DTO_HopDong(dt.Rows.Count - 1) {}
				For i As Integer = 0 To dt.Rows.Count - 1
					hopdong(i) = New DTO_HopDong()
					hopdong(i).ma_hop_dong = dt.Rows(i)("ma_hop_dong").ToString()
					hopdong(i).ma_khach_hang = dt.Rows(i)("ma_khach_hang").ToString()
					hopdong(i).ten_khach_hang = dt.Rows(i)("ten_khach_hang").ToString()
					hopdong(i).ngay_bat_dau = Convert.ToDateTime(dt.Rows(i)("ngay_bat_dau").ToString())
					hopdong(i).ngay_ket_thuc = Convert.ToDateTime(dt.Rows(i)("ngay_ket_thuc").ToString())
				Next
				Return hopdong
			End If
			Return Nothing
		End Function
		Public Function _Xoa_Hop_Dong(dto As DTO_HopDong) As Boolean
			Dim kt As Boolean = True
			Try
				Dim sql1 As String = "select * from dm_hoa_don where ma_hop_dong=@mahd"
				Dim prs As SqlParameter() = {New SqlParameter("@mahd", dto.ma_hop_dong)}
				Dim dt As DataTable = data.ExcuteDataTable(sql1, prs)
				If dt.Rows.Count = 0 OrElse dt Is Nothing Then
					Dim sql2 As String = "delete from dm_hop_dong where ma_hop_dong=@mahd"
					Dim prs2 As SqlParameter() = {New SqlParameter("@mahd", dto.ma_hop_dong)}
					data.ExcuteNonQuery(sql2, prs2)
				Else
					kt = False
				End If
			Catch
				kt = False
			End Try
			Return kt
		End Function
		Public Function _Update_Hop_Dong(dto As DTO_HopDong) As Boolean
			Dim up As Boolean = True
			Try
				Dim sql As String = "update dm_hop_dong set ngay_bat_dau=@ngaybd,ngay_ket_thuc=@ngaykt,loaihanghoa=@loaihanghoa,lotrinhvanchuyen=@lotrinhvanchuyen,phuongthucvanchuyen=@phuongthucvanchuyen,giatrihopdong=@giatrihopdong,phuongthucthanhtoan=@phuongthucthanhtoan where ma_hop_dong=@mahd and ma_khach_hang=@makh"

				Dim prs As SqlParameter() = {New SqlParameter("@mahd", dto.ma_hop_dong), New SqlParameter("@makh", dto.ma_khach_hang), New SqlParameter("@ngaybd", dto.ngay_bat_dau), New SqlParameter("@ngaykt", dto.ngay_ket_thuc), New SqlParameter("@loaihanghoa", dto.loaihanghoa), New SqlParameter("@lotrinhvanchuyen", dto.lotrinhvanchuyen), _
					New SqlParameter("@phuongthucvanchuyen", dto.phuongthucvanchuyen), New SqlParameter("@giatrihopdong", dto.giatrihopdong), New SqlParameter("@phuongthucthanhtoan", dto.phuongthucthanhtoan)}
				data.ExcuteNonQuery(sql, prs)
			Catch
				up = False
			End Try
			Return up
		End Function
		Public Function _Tim_Khach_Hang_Hop_Dong(dto As DTO_HopDong) As DTO_HopDong()
			Dim url As String = ""
			If (dto.ma_hop_dong = "" OrElse dto.ma_hop_dong Is Nothing) AndAlso dto.ma_khach_hang <> "" Then
				url = "and dm_khach_hang.ma_khach_hang=@makh"
			Else
				If dto.ma_khach_hang <> "" Then
					url = "and dm_khach_hang.ma_khach_hang=@makh and ma_hop_dong=@mahd"
				Else
					url = "and  ma_hop_dong=@mahd"
				End If
			End If
			Dim sql As String = "select * from dm_khach_hang,dm_hop_dong where dm_khach_hang.ma_khach_hang=dm_hop_dong.ma_khach_hang " & url
			

			Dim prs As SqlParameter() = {New SqlParameter("@makh", dto.ma_khach_hang), New SqlParameter("@mahd", dto.ma_hop_dong)}
			Dim dt As DataTable = data.ExcuteDataTable(sql, prs)
			If dt.Rows.Count > 0 Then
				Dim hopdong As DTO_HopDong() = New DTO_HopDong(dt.Rows.Count - 1) {}
				For i As Integer = 0 To dt.Rows.Count - 1
					hopdong(i) = New DTO_HopDong()
					hopdong(i).ma_hop_dong = dt.Rows(i)("ma_hop_dong").ToString()
					hopdong(i).ma_khach_hang = dt.Rows(i)("ma_khach_hang").ToString()
					hopdong(i).ten_khach_hang = dt.Rows(i)("ten_khach_hang").ToString()
					hopdong(i).ngay_bat_dau = Convert.ToDateTime(dt.Rows(i)("ngay_bat_dau").ToString())
					hopdong(i).ngay_ket_thuc = Convert.ToDateTime(dt.Rows(i)("ngay_ket_thuc").ToString())
					hopdong(i).lotrinhvanchuyen = dt.Rows(i)("lotrinhvanchuyen").ToString()
					hopdong(i).phuongthucvanchuyen = dt.Rows(i)("phuongthucvanchuyen").ToString()
					hopdong(i).loaihanghoa = dt.Rows(i)("loaihanghoa").ToString()
					hopdong(i).giatrihopdong = dt.Rows(i)("giatrihopdong").ToString()
					hopdong(i).phuongthucthanhtoan = dt.Rows(i)("phuongthucthanhtoan").ToString()
				Next
				Return hopdong
			End If

			Return Nothing
		End Function

	End Class
End Namespace

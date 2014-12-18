Imports System.Collections.Generic
Imports System.Linq
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports QLDVVTHH.DTO
Imports QLDVVTHH.DAL

Namespace DAL
	Class DAL_DieuXe
		Private data As New ConnectData()
		Public Function GetAll_DX() As List(Of DTO_DieuXe)
			Dim sql As String = "select ma_dieu_xe,ma_so_xe,so_tan,A.ma_khach_hang,noi_giao,noi_nhan,ngay_dieu_xe,ngay_ve,ma_so_xe,dia_chi,fax,ngay_tao, B.ten_khach_hang,case tinh_trang_thanh_toan when 0 then N'Chưa Thanh Toán' when 1 then N'Đã Thanh Toán' end as 'tinh_trang_thanh_toan' from dm_dieu_xe A join dm_khach_hang B on A.ma_khach_hang = B.ma_khach_hang"
			Dim dr As SqlDataReader = data.ExcuteDataReader(sql, Nothing)
			Return data.MapDataReaderToObject(Of DTO_DieuXe)(dr)
		End Function
		Public Function Get_TrongLuongXe(dto As DTO_Xe) As List(Of DTO_Xe)
			Dim sql As String = "select * from dm_xe  where ma_so_xe='" & dto.ma_so_xe.Trim() & "'"
			Dim dr As SqlDataReader = data.ExcuteDataReader(sql, Nothing)
			Return data.MapDataReaderToObject(Of DTO_Xe)(dr)
		End Function
		Public Function Create_DX(DX As DTO_DieuXe) As Boolean
			Dim sql As String = "insert into dm_dieu_xe(ma_hop_dong,ma_dieu_xe,ma_so_xe,ma_khach_hang,noi_giao,noi_nhan,so_tan,ngay_dieu_xe,tinh_trang_thanh_toan) values(@ma_hop_dong,@ma_dieu_xe,@ma_so_xe,@ma_khach_hang,@noi_giao,@noi_nhan,@so_tan,@ngay_dieu_xe,0)"
			Dim prs As SqlParameter() = {New SqlParameter("@ma_hop_dong", DX.ma_hop_dong.Trim()), New SqlParameter("@ma_dieu_xe", DX.ma_dieu_xe.Trim()), New SqlParameter("@ma_so_xe", DX.ma_so_xe.Trim()), New SqlParameter("@ma_khach_hang", DX.ma_khach_hang.Trim()), New SqlParameter("@noi_giao", DX.noi_giao.Trim()), New SqlParameter("@noi_nhan", DX.noi_nhan.Trim()), _
				New SqlParameter("@ngay_dieu_xe", DX.ngay_dieu_xe), New SqlParameter("@so_tan", DX.so_tan)}
			If data.ExcuteNonQuery(sql, prs) = True Then
				Dim Update As String = "Update dm_xe set ma_tinh_trang=2 where ma_so_xe='" & DX.ma_so_xe.Trim() & "' "
				data.ExcuteNonQuery(Update, Nothing)
			End If
			Return True
		End Function
		Public Function Update_DX(DXE As DTO_DieuXe) As Boolean
			Dim sql As String = "update dm_dieu_xe set ngay_ve=@ngay_ve,tinh_trang_thanh_toan=@tinh_trang_thanh_toan, ma_so_xe=@ma_so_xe,ma_khach_hang=@ma_khach_hang,noi_giao=@noi_giao,noi_nhan=@noi_nhan,so_tan=@so_tan,ngay_dieu_xe=@ngay_dieu_xe where ma_dieu_xe=@ma_dieu_xe"
			Dim prs As SqlParameter() = {New SqlParameter("@ma_dieu_xe", DXE.ma_dieu_xe), New SqlParameter("@ma_so_xe", DXE.ma_so_xe), New SqlParameter("@ma_khach_hang", DXE.ma_khach_hang), New SqlParameter("@noi_giao", DXE.noi_giao), New SqlParameter("@noi_nhan", DXE.noi_nhan), New SqlParameter("@ngay_dieu_xe", DXE.ngay_dieu_xe), _
				New SqlParameter("@so_tan", DXE.so_tan), New SqlParameter("@ngay_ve", DXE.ngay_ve), New SqlParameter("@tinh_trang_thanh_toan", DXE.tttt)}
			If data.ExcuteNonQuery(sql, prs) = True Then
				Dim Update As String = "Update dm_xe set ma_tinh_trang=1 where ma_so_xe='" & DXE.ma_so_xe.Trim() & "' "
				data.ExcuteNonQuery(Update, Nothing)
			End If
			Return True
		End Function
		Public Function Delete_Dxe(ma_dx As String) As Boolean
			Dim sql As String = "delete [dm_dieu_xe] where ma_dieu_xe = @ma_dieu_xe"
			Dim prs As SqlParameter() = {New SqlParameter("@ma_dieu_xe", ma_dx)}
			Return data.ExcuteNonQuery(sql, prs)
		End Function

		Public Function Get_NoiNhan() As List(Of DTO_DieuXe)
			Dim sql As String = "select noi_nhan from dm_bang_bao_gia"
			Dim dr As SqlDataReader = data.ExcuteDataReader(sql, Nothing)
			Return data.MapDataReaderToObject(Of DTO_DieuXe)(dr)
		End Function
		Public Function Get_NoiGiao() As List(Of DTO_DieuXe)
			Dim sql As String = "select noi_giao from dm_bang_bao_gia"
			Dim dr As SqlDataReader = data.ExcuteDataReader(sql, Nothing)
			Return data.MapDataReaderToObject(Of DTO_DieuXe)(dr)
		End Function
		'''//////////////////////////////////////////////////////////////////DUNG CHUNG/////////////////////////////////////////////////////////////////////////////////
		Public Function _Ma_Dieu_Xe_Moi() As String
			Return New DAL_Systems().CreateIDCode("D", "ma_dieu_xe", "dm_dieu_xe", 7)
		End Function
		'''////////////////////////////////////////////////////////////////CODE DIEU XE GIAO DIEN TTDieuXe//////////////////////////////////////////////////////////////
		Public Function Delete_Dieu_Xe(dxx As DTO_DieuXe) As Boolean
			Dim check As String = "select * from dm_bang_ke where ma_dieu_xe='" & dxx.ma_dieu_xe.Trim() & "'"
			Dim dtt As DataTable = data.ExcuteDataTable(check, Nothing)
			If dtt IsNot Nothing AndAlso dtt.Rows.Count > 0 Then
				Return False
			End If
			Dim update_xe As String = "Update dm_xe set ma_tinh_trang=1 where ma_so_xe in (select ma_so_xe from dm_dieu_xe where ma_dieu_xe =@ma_dieu_xe) "
			Dim prs1 As SqlParameter() = {New SqlParameter("@ma_dieu_xe", dxx.ma_dieu_xe.Trim())}
			If data.ExcuteNonQuery(update_xe, prs1) = True Then
				Dim sql As String = "delete from dm_dieu_xe where ma_dieu_xe =@ma_dieu_xe "
				Dim prs2 As SqlParameter() = {New SqlParameter("@ma_dieu_xe", dxx.ma_dieu_xe.Trim())}

				Return data.ExcuteNonQuery(sql, prs2)
			End If
			Return False
		End Function
		Public Function Update_Dieu_Xe(DXE As DTO_DieuXe) As Boolean
			Dim sql As String = "update dm_dieu_xe set ngay_ve=@ngay_ve,tinh_trang_thanh_toan=@tinh_trang_thanh_toan where ma_dieu_xe=@ma_dieu_xe and ma_so_xe=@ma_so_xe"
			Dim prs As SqlParameter() = {New SqlParameter("@ma_dieu_xe", DXE.ma_dieu_xe.Trim()), New SqlParameter("@ma_so_xe", DXE.ma_so_xe.Trim()), New SqlParameter("@ma_khach_hang", DXE.ma_khach_hang.Trim()), New SqlParameter("@noi_giao", DXE.noi_giao), New SqlParameter("@noi_nhan", DXE.noi_nhan), New SqlParameter("@ngay_dieu_xe", DXE.ngay_dieu_xe), _
				New SqlParameter("@so_tan", DXE.so_tan), New SqlParameter("@ngay_ve", DXE.ngay_ve), New SqlParameter("@tinh_trang_thanh_toan", DXE.tttt)}
			If data.ExcuteNonQuery(sql, prs) = True Then
				Dim Update As String = "Update dm_xe set ma_tinh_trang=1 where ma_so_xe='" & DXE.ma_so_xe.Trim() & "' "
				data.ExcuteNonQuery(Update, Nothing)
			End If
			Return True
		End Function
		Public Function Get_List_Xe_DangOBai() As List(Of DTO_Xe)
			Dim sql As String = "select dm_xe.*,ten_tinh_trang from dm_xe,dm_tinh_trang_xe where dm_xe.ma_tinh_trang=dm_tinh_trang_xe.ma_tinh_trang and dm_xe.ma_tinh_trang=1 order by dm_xe.trong_luong desc"
			Dim dt As DataTable = data.ExcuteDataTable(sql, Nothing)
			If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
				Dim xe As New List(Of DTO_Xe)()
				For Each dr As DataRow In dt.Rows
					Dim xx As New DTO_Xe()
					xx.ma_so_xe = dr("ma_so_xe").ToString()
					xx.trong_luong = Single.Parse(dr("trong_luong").ToString())
					xx.nhan_hieu = dr("nhan_hieu").ToString()
					xx.ten_tinh_trang = dr("ten_tinh_trang").ToString()
					xx.loai_xe = dr("loai_xe").ToString()
					xe.Add(xx)
				Next
				Return xe
			End If
			Return Nothing
		End Function
		Public Function Get_List_Xe_Nhan_Vien(nv As DTO_NhanVien) As List(Of DTO_NhanVien)
			Dim sql As String = "select * from dm_nhan_vien where ma_so_xe='" & nv._ma_so_xe.Trim() & "'"
			Dim dt As DataTable = data.ExcuteDataTable(sql, Nothing)
			If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
				Dim nn As New List(Of DTO_NhanVien)()
				For Each dr As DataRow In dt.Rows
					Dim nvv As New DTO_NhanVien()
					nvv.ma_nhan_vien = dr("ma_nhan_vien").ToString()
					nvv.ten_nhan_vien = dr("ten_nhan_vien").ToString()
					nvv.cmnd = dr("cmnd").ToString()
					nvv.dia_chi = dr("dia_chi").ToString()
					nvv.dien_thoai = dr("dien_thoai").ToString()
					nvv.nam_sinh = Convert.ToDateTime(dr("nam_sinh").ToString())
					nvv.chucvu = dr("chucvu").ToString()
					nn.Add(nvv)
				Next
				Return nn
			End If
			Return Nothing
		End Function
		Public Function _List_Get_Ma_Bao_Gia(bg As DTO_BangBaoGia) As List(Of DTO_BangBaoGia)
			Dim sql As String = "select ma_bao_gia from dm_bang_bao_gia where ma_hop_dong='" & bg.ma_hop_dong.Trim() & "' and Getdate()>=tu_ngay and getdate()<= den_ngay "
			Dim dt As DataTable = data.ExcuteDataTable(sql, Nothing)
			If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
				Dim xx As New List(Of DTO_BangBaoGia)()
				For Each dr As DataRow In dt.Rows
					Dim dxe As New DTO_BangBaoGia()
					dxe.ma_bao_gia = dr("ma_bao_gia").ToString()
					xx.Add(dxe)
				Next
				Return xx
			End If
			Return Nothing
		End Function
		Public Function _List_Get_NoiNhan(bg As DTO_BangBaoGia) As List(Of DTO_DieuXe)
			Dim sql As String = "select distinct noi_nhan from dm_bang_bao_gia where ma_bao_gia='" & bg.ma_bao_gia.Trim() & "'"
			Dim dt As DataTable = data.ExcuteDataTable(sql, Nothing)
			If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
				Dim xx As New List(Of DTO_DieuXe)()
				For Each dr As DataRow In dt.Rows
					Dim dxe As New DTO_DieuXe()
					dxe.noi_nhan = dr("noi_nhan").ToString()
					xx.Add(dxe)
				Next
				Return xx
			End If
			Return Nothing
		End Function
		Public Function _List_Get_NoiGiao(dxx As DTO_DieuXe) As List(Of DTO_DieuXe)
			Dim sql As String = "select distinct noi_giao from dm_bang_bao_gia where noi_nhan=N'" & dxx.noi_nhan.Trim() & "'"
			Dim dt As DataTable = data.ExcuteDataTable(sql, Nothing)
			If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
				Dim xx As New List(Of DTO_DieuXe)()
				For Each dr As DataRow In dt.Rows
					Dim dxe As New DTO_DieuXe()
					dxe.noi_giao = dr("noi_giao").ToString()
					xx.Add(dxe)
				Next
				Return xx
			End If
			Return Nothing
		End Function
		Public Function _List_Get_Dieu_Xe_By_KhachHang_HopDong(dxx As DTO_DieuXe) As List(Of DTO_DieuXe)
			Dim sql As String = "select ma_hop_dong,trong_luong,ma_dieu_xe,A.ma_so_xe,so_tan,A.ma_khach_hang,noi_giao,noi_nhan,ngay_dieu_xe,ngay_ve,dia_chi,fax,B.ngay_tao, B.ten_khach_hang,case tinh_trang_thanh_toan when 0 then N'Chưa Thanh Toán' when 1 then N'Đã Thanh Toán' end as 'tinh_trang_thanh_toan' from dm_dieu_xe A join dm_khach_hang B on A.ma_khach_hang = B.ma_khach_hang and ma_hop_dong='" & dxx.ma_hop_dong.Trim() & "' , dm_xe where dm_xe.ma_so_xe=A.ma_so_xe  order by ma_dieu_xe desc,trong_luong desc"
			Dim dt As DataTable = data.ExcuteDataTable(sql, Nothing)
			If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
				Dim dxe As New List(Of DTO_DieuXe)()
				For Each dr As DataRow In dt.Rows
					Dim xx As New DTO_DieuXe()
					xx.ma_hop_dong = dr("ma_hop_dong").ToString()
					xx.ma_dieu_xe = dr("ma_dieu_xe").ToString()
					xx.so_tan = dr("so_tan").ToString()
					xx.ma_khach_hang = dr("ma_khach_hang").ToString()
					xx.noi_giao = dr("noi_giao").ToString()
					xx.noi_nhan = dr("noi_nhan").ToString()
					xx.ngay_dieu_xe = Convert.ToDateTime(dr("ngay_dieu_xe").ToString())
					If dr("ngay_ve").ToString() <> "" Then
						xx.ngay_ve = Convert.ToDateTime(dr("ngay_ve").ToString())
					End If
					xx.ma_so_xe = dr("ma_so_xe").ToString()
					xx.ten_khach_hang = dr("ten_khach_hang").ToString()
					xx.tinh_trang_thanh_toan = dr("tinh_trang_thanh_toan").ToString()
					xx.tai_trong_xe = Single.Parse(dr("trong_luong").ToString())
					dxe.Add(xx)
				Next
				Return dxe
			End If
			Return Nothing
		End Function
		Public Function _Get_Tong_Trong_Luong(dxx As DTO_DieuXe) As Single
			Dim tong_tan As Single = 0
			Dim sql As String = "select sum(so_tan) as so_tan from dm_dieu_xe where ma_dieu_xe='" & dxx.ma_dieu_xe.Trim() & "'"
			Dim dt As DataTable = data.ExcuteDataTable(sql, Nothing)
			If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
				tong_tan = Single.Parse("0" & dt.Rows(0)(0).ToString())
			End If
			Return tong_tan
		End Function

	End Class
End Namespace

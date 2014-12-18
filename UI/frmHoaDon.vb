Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports QLDVVTHH.BLL
Imports QLDVVTHH.DTO

Namespace UI
	Public Partial Class frmHoaDon
		Inherits Form
		Private auto As New AutoCompleteStringCollection()
		Public Sub New()
			InitializeComponent()
			_AUTO_COMPLE_MA_KHACH_HANG()
			_combobox_ten_khach_hang()
			_Ma_Hoa_Don()
		End Sub
		Private Sub _Ma_Hoa_Don()
			txtmahoadon.Text = New BLL_HoaDon()._Ma_Hoa_Don()
		End Sub
		Private Sub _AUTO_COMPLE_MA_KHACH_HANG()
			Dim dt As DataTable = New BLL_HopDong()._Bang_Ma_Khach_Hang()
			If dt.Rows.Count > 0 Then
				For Each dr As DataRow In dt.Rows
					auto.Add(dr("ma_khach_hang").ToString())
				Next
			End If
			txtmakhachhang.AutoCompleteMode = AutoCompleteMode.Suggest
			txtmakhachhang.AutoCompleteSource = AutoCompleteSource.CustomSource
			txtmakhachhang.AutoCompleteCustomSource = auto
		End Sub
		Private Sub _Load_Combobox_Hop_Dong(makh As String)
			Dim dto As New DTO_HopDong()
			dto.ma_khach_hang = makh
			cbmahopdong.DataSource = New BLL_BangKe()._List_Hop_Dong(dto)
			cbmahopdong.DisplayMember = "ma_hop_dong"
			cbmahopdong.ValueMember = "ma_hop_dong"
		End Sub

		Private Sub txtmakhachhang_TextChanged(sender As Object, e As EventArgs)
			If txtmakhachhang.Text.Trim() <> "" Then
				Dim dto As New DTO_KhachHang()
				dto.ma_khach_hang = txtmakhachhang.Text.Trim().ToString()

				_Load_Combobox_Hop_Dong(dto.ma_khach_hang)
			Else
				lvhoadon.Items.Clear()
				lvchitiethoadon.Items.Clear()
			End If
		End Sub

		Private Sub _combobox_ten_khach_hang()
			Dim dt As DataTable = New BLL_BangKe()._List_Ten_Khach_Hang()
			Dim row As DataRow = dt.NewRow()
			row("ten_khach_hang") = ""
			row("ma_khach_hang") = ""
			dt.Rows.InsertAt(row, 0)

			cbkhachhang.DisplayMember = "ten_khach_hang"
			cbkhachhang.ValueMember = "ma_khach_hang"
			cbkhachhang.DataSource = dt



			cbkhachhang.SelectedIndex = 0
		End Sub

		Private Sub cbkhachhang_SelectedIndexChanged(sender As Object, e As EventArgs)
			lvhoadon.Items.Clear()
			If cbkhachhang.Text.Trim() <> "" Then
				txtmakhachhang.Text = cbkhachhang.SelectedValue.ToString()
			End If
		End Sub

		Private Sub btntaoma_Click(sender As Object, e As EventArgs)
			_Ma_Hoa_Don()
		End Sub

		Private Sub btnthoat_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		Private Sub btnthem_Click(sender As Object, e As EventArgs)
			Dim message As String = ""
			If txtmakhachhang.Text.Trim() = "" Then
				message += "Chưa Nhập Mã Khách Hàng "
			End If
			If cbmahopdong.Text.Trim() = "" Then
				message += If(String.IsNullOrEmpty(message), "", "-" & " Chưa Nhập Mã Hợp Đồng ")
			End If
			If txtmahoadon.Text.Trim() = "" Then
				message += If(String.IsNullOrEmpty(message), "", "-" & " Chưa Nhập Mã Hóa Đơn ")
			End If
			If message = "" Then
				Dim hopdong As New DTO_HopDong()
				hopdong.ma_hop_dong = cbmahopdong.Text.Trim()
				hopdong.ma_khach_hang = txtmakhachhang.Text.Trim()


				Dim hoadon As New DTO_HoaDon()
				hoadon.ma_hoa_don = txtmahoadon.Text.Trim()
				hoadon.ngay_Xuat_hoa_don = dtvngayxuathoadon.Value
				Dim i As Integer = New BLL_HoaDon()._Lap_Hoa_Hon_Van_Chuyen(hopdong, hoadon)
				If i = 0 Then
					MessageBox.Show("Lập Hóa Đơn Thành Công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
					_List_View_Hoa_Don()
					txtmahoadon.Text = New BLL_HoaDon()._Ma_Hoa_Don()
				End If
				If i = 1 Then
					MessageBox.Show("Lập Hóa Đơn Thất Bại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
				End If
				If i = 2 Then
					MessageBox.Show("Mã Hóa Đã Tồn Tại Không Thể Lập Hóa Đơn.Vui Lòng Chọn Mã Hóa Đơn Mới !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
				End If
			End If
			If message <> "" Then
				MessageBox.Show("Bạn " & message & " !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
			End If
		End Sub

		Private Sub cbmahopdong_SelectedIndexChanged(sender As Object, e As EventArgs)
			If cbmahopdong.Text.Trim() <> "" Then
				_List_View_Hoa_Don()
				Dim hd As New DTO_HopDong()
				hd.ma_hop_dong = cbmahopdong.Text.Trim()
				hd.ma_khach_hang = txtmakhachhang.Text.Trim()
				If New BLL_BangBaoGia()._DS_Date_ThoiGianHopDong(hd) IsNot Nothing Then
					For Each dto As DTO_HopDong In New BLL_BangBaoGia()._DS_Date_ThoiGianHopDong(hd)
						dtvngayxuathoadon.Value = dto.ngay_bat_dau
					Next
				End If
			End If
		End Sub
		Private Sub _List_View_Hoa_Don()
			lvhoadon.Items.Clear()
			Dim hoadon As New DTO_HoaDon()
			hoadon.ma_khach_hang = txtmakhachhang.Text.Trim()
			hoadon.ma_hop_dong = cbmahopdong.Text.Trim()
			Dim STT As Integer = 1
			If New BLL_HoaDon()._List_Hoa_Hon_Van_Chuyen(hoadon) IsNot Nothing AndAlso New BLL_HoaDon()._List_Hoa_Hon_Van_Chuyen(hoadon).Count() > 0 Then
				For Each hd As DTO_HoaDon In New BLL_HoaDon()._List_Hoa_Hon_Van_Chuyen(hoadon)
					Dim list As New ListViewItem(STT.ToString())

					Dim lv1 As New ListViewItem.ListViewSubItem(list, hd.ma_hoa_don.Trim())
					list.SubItems.Add(lv1)
					Dim lv2 As New ListViewItem.ListViewSubItem(list, hd.tong_cuot_van_chuyen.ToString("###,###,###"))
					list.SubItems.Add(lv2)
					Dim lv3 As New ListViewItem.ListViewSubItem(list, hd.theu.ToString("###,###,###"))
					list.SubItems.Add(lv3)
					Dim lv4 As New ListViewItem.ListViewSubItem(list, hd.tong_cong.ToString("###,###,###"))
					list.SubItems.Add(lv4)
					Dim lv5 As New ListViewItem.ListViewSubItem(list, hd.ngay_Xuat_hoa_don.ToShortDateString())
					list.SubItems.Add(lv5)


					lvhoadon.Items.Add(list)
					STT += 1
				Next
			End If
			lvchitiethoadon.Items.Clear()
		End Sub
		Private Sub _List_View_Chi_Tiet_Hoa_Don(mahoadon As String, makh As String)
			lvchitiethoadon.Items.Clear()
			Dim STT As Integer = 1
			Dim tongcong As Single = 0
			Dim ct As New DTO_Chi_Tiet_Hoa_Don()
			ct.ma_hoa_don = mahoadon.ToString()
			ct.ma_khach_hang = makh
			If New BLL_HoaDon()._List_Chi_Tiet_Hoa_Hon_Van_Chuyen(ct) IsNot Nothing Then
				For Each dto As DTO_BangKe In New BLL_HoaDon()._List_Chi_Tiet_Hoa_Hon_Van_Chuyen(ct)
					Dim lvi As New ListViewItem(STT.ToString())
					Dim ite1 As New ListViewItem.ListViewSubItem(lvi, dto.ma_bang_ke)
					lvi.SubItems.Add(ite1)
					Dim ite2 As New ListViewItem.ListViewSubItem(lvi, dto.ngay_van_chuyen.ToShortDateString())
					lvi.SubItems.Add(ite2)
					Dim ite22 As New ListViewItem.ListViewSubItem(lvi, dto.ma_dieu_xe.Trim())
					lvi.SubItems.Add(ite22)
					Dim ite3 As New ListViewItem.ListViewSubItem(lvi, dto.so_xe)
					lvi.SubItems.Add(ite3)
					Dim ite4 As New ListViewItem.ListViewSubItem(lvi, dto.noi_nhan)
					lvi.SubItems.Add(ite4)
					Dim ite5 As New ListViewItem.ListViewSubItem(lvi, dto.noi_giao)
					lvi.SubItems.Add(ite5)
					Dim ite6 As New ListViewItem.ListViewSubItem(lvi, dto.khoi_luong.ToString())
					lvi.SubItems.Add(ite6)
					Dim ite7 As New ListViewItem.ListViewSubItem(lvi, dto.don_gia_chuyen.ToString("###,###,###"))
					lvi.SubItems.Add(ite7)
					Dim ite8 As New ListViewItem.ListViewSubItem(lvi, dto.don_gia_tan.ToString("###,###,###"))
					lvi.SubItems.Add(ite8)
					Dim ite9 As New ListViewItem.ListViewSubItem(lvi, (dto.don_gia_chuyen + (If(dto.khoi_luong > 15, ((dto.khoi_luong - 15) * dto.don_gia_tan), 0))).ToString("###,###,###"))
					lvi.SubItems.Add(ite9)
					Dim ite10 As New ListViewItem.ListViewSubItem(lvi, dto.ghi_chu)
					lvi.SubItems.Add(ite10)

					lvchitiethoadon.Items.Add(lvi)
					STT += 1
					tongcong += (dto.don_gia_chuyen + (If(dto.khoi_luong > 15, ((dto.khoi_luong - 15) * dto.don_gia_tan), 0)))
				Next
			End If
			lvchitiethoadon.View = View.Details
			_Tinh_TongCong_Thue_ThanhTien("Tổng Cộng", tongcong)
			_Tinh_TongCong_Thue_ThanhTien("Thếu 10%", tongcong * 10 / 100)
			_Tinh_TongCong_Thue_ThanhTien("Tổng Thành Tiền", tongcong + (tongcong * 10 / 100))
		End Sub
		Private Sub _Tinh_TongCong_Thue_ThanhTien(tengiatri As String, giatri As Single)
			If lvchitiethoadon.Items.Count > 0 Then
				Dim MA As New ListViewItem("")
				MA.UseItemStyleForSubItems = False

				Dim lv1 As New ListViewItem.ListViewSubItem(MA, "")
				MA.SubItems.Add(lv1)
				Dim lv11 As New ListViewItem.ListViewSubItem(MA, "")
				MA.SubItems.Add(lv11)
				Dim lv2 As New ListViewItem.ListViewSubItem(MA, "")
				MA.SubItems.Add(lv2)
				Dim lv3 As New ListViewItem.ListViewSubItem(MA, "")
				MA.SubItems.Add(lv3)
				Dim lv4 As New ListViewItem.ListViewSubItem(MA, "")
				MA.SubItems.Add(lv4)
				Dim lv5 As New ListViewItem.ListViewSubItem(MA, "")
				MA.SubItems.Add(lv5)
				Dim lv6 As New ListViewItem.ListViewSubItem(MA, "")
				MA.SubItems.Add(lv6)
				Dim lv7 As New ListViewItem.ListViewSubItem(MA, "")
				MA.SubItems.Add(lv7)
				Dim lv8 As New ListViewItem.ListViewSubItem(MA, tengiatri)
				MA.SubItems.Add(lv8)



				lv8.ForeColor = System.Drawing.Color.Blue
				lv8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, System.Drawing.FontStyle.Regular)

				Dim lv9 As New ListViewItem.ListViewSubItem(MA, giatri.ToString("###,###,###"))
				MA.SubItems.Add(lv9)

				lv9.ForeColor = System.Drawing.Color.Red
				lv9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, System.Drawing.FontStyle.Regular)

				Dim lv10 As New ListViewItem.ListViewSubItem(MA, "VNĐ")
				MA.SubItems.Add(lv10)

				lv10.ForeColor = System.Drawing.Color.Red
				lv10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, System.Drawing.FontStyle.Regular)


				lvchitiethoadon.Items.Add(MA)
			End If
		End Sub

		Private Sub lvhoadon_SelectedIndexChanged(sender As Object, e As EventArgs)
			For Each item As ListViewItem In lvhoadon.Items
				If item.Selected Then
					txtmahoadon.Text = item.SubItems(1).Text
					_List_View_Chi_Tiet_Hoa_Don(item.SubItems(1).Text, cbkhachhang.SelectedValue.ToString())
				End If
			Next
		End Sub

		Private Sub btnxoa_Click(sender As Object, e As EventArgs)
			If txtmahoadon.Text.Trim() <> "" Then
				Dim kq As DialogResult = MessageBox.Show("Bạn Chắc Chắc Muốn Xóa Mã Hóa Đơn : " & txtmahoadon.Text.Trim() & " !", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
				If kq = DialogResult.Yes Then
					Dim hoadon As New DTO_HoaDon()
					hoadon.ma_hoa_don = txtmahoadon.Text.Trim()
					Dim i As Integer = New BLL_HoaDon()._Xoa_Hoa_Don_Van_Chuyen(hoadon)
					If i = 0 Then
						MessageBox.Show("Xóa Hóa Đơn Thành Công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
						_List_View_Hoa_Don()
						lvchitiethoadon.Items.Clear()
					Else
						MessageBox.Show("Xóa Hóa Đơn Thất Bại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
					End If
				End If
			Else
				MessageBox.Show("Bạn Chưa Chọn Hóa Đơn Cần Xóa !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
			End If
		End Sub

		Private Sub mntsxoalv_Click(sender As Object, e As EventArgs)
			Dim kq As DialogResult = MessageBox.Show("Bạn Chắc Chắc Muốn Xóa  Hóa Đơn!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
			If kq = DialogResult.Yes Then
				For Each item As ListViewItem In lvhoadon.Items
					If item.Selected Then
						Dim hoadon As New DTO_HoaDon()
						hoadon.ma_hoa_don = item.SubItems(1).Text
						Dim i As Integer = New BLL_HoaDon()._Xoa_Hoa_Don_Van_Chuyen(hoadon)

						If i = 0 Then
						End If
					End If
				Next
				_List_View_Hoa_Don()
				lvchitiethoadon.Items.Clear()
			End If
		End Sub

		Private Sub btntim_Click(sender As Object, e As EventArgs)
			lvhoadon.Items.Clear()
			Dim hoadon As New DTO_HoaDon()
			hoadon.ma_khach_hang = txtmakhachhang.Text.Trim()
			hoadon.ma_hop_dong = cbmahopdong.Text.Trim()
			hoadon.ma_hoa_don = txtmahoadon.Text.Trim()
			Dim STT As Integer = 1
			If New BLL_HoaDon()._Tim_Hoa_Hon_Van_Chuyen(hoadon) IsNot Nothing AndAlso New BLL_HoaDon()._Tim_Hoa_Hon_Van_Chuyen(hoadon).Count() > 0 Then
				For Each hd As DTO_HoaDon In New BLL_HoaDon()._Tim_Hoa_Hon_Van_Chuyen(hoadon)
					Dim list As New ListViewItem(STT.ToString())

					Dim lv1 As New ListViewItem.ListViewSubItem(list, hd.ma_hoa_don.Trim())
					list.SubItems.Add(lv1)
					Dim lv2 As New ListViewItem.ListViewSubItem(list, hd.tong_cuot_van_chuyen.ToString("###,###,###"))
					list.SubItems.Add(lv2)
					Dim lv3 As New ListViewItem.ListViewSubItem(list, hd.theu.ToString("###,###,###"))
					list.SubItems.Add(lv3)
					Dim lv4 As New ListViewItem.ListViewSubItem(list, hd.tong_cong.ToString("###,###,###"))
					list.SubItems.Add(lv4)
					Dim lv5 As New ListViewItem.ListViewSubItem(list, hd.ngay_Xuat_hoa_don.ToShortDateString())
					list.SubItems.Add(lv5)

					lvhoadon.Items.Add(list)
					STT += 1
				Next
			End If
		End Sub

		Private Sub btncongno_Click(sender As Object, e As EventArgs)
			Dim message As String = ""
			For Each item As ListViewItem In lvhoadon.Items
				If item.Selected Then
					Dim kq As DialogResult = MessageBox.Show("Bạn Muôn Thêm Mã Hóa Đơn : " & item.SubItems(1).Text & " Vào Công Nợ Khách Hàng !", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
					If kq = DialogResult.Yes Then
						If txtmakhachhang.Text.Trim() = "" Then
							message += "Chưa Nhập Mã Khách Hàng "
						End If
						If cbmahopdong.Text.Trim() = "" Then
							message += If(String.IsNullOrEmpty(message), "", "-")
							message += " Chưa Chọn Mã Hợp Đồng"
						End If
						Dim hd As New DTO_HoaDon()
						hd.ma_hoa_don = item.SubItems(1).Text
						hd.ma_khach_hang = txtmakhachhang.Text.Trim()
						If New BLL_CongNo()._check_ma_hoa_don_cong_no(hd) = 1 Then
							message += If(String.IsNullOrEmpty(message), "", "-")
							message += " Mã Hóa Đơn Đã Lưu Vào Công Nợ Khách Hàng "
						End If
						If message <> "" Then
							MessageBox.Show(" " & message & "!", "Thống Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
						End If
						If message = "" Then
							Dim hoadon As New DTO_HoaDon()
							hoadon.ma_khach_hang = txtmakhachhang.Text.Trim()
							hoadon.ma_hop_dong = cbmahopdong.Text.Trim()
							hoadon.ma_hoa_don = item.SubItems(1).Text

							Dim congno As New DTO_CongNo()
							congno.ma_cong_no = New BLL_CongNo()._Ma_Cong_No()

							Dim i As Integer = New BLL_CongNo()._Them_Cong_No_Khach_Hang(hoadon, congno)
							If i = 0 Then
								MessageBox.Show("Thêm Công Nợ Thành Công! ", "Thống Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
							Else
								MessageBox.Show("Thêm Công Nợ Thất Bại! ", "Thống Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
							End If
						End If
					End If
				End If
			Next
		End Sub
	End Class
End Namespace

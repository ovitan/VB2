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
	Public Partial Class frmCongNo
		Inherits Form
		Private auto As New AutoCompleteStringCollection()

		Private _TongTien_Thanh_Toan As Single = 0

		Public Sub New()
			InitializeComponent()
			_AUTO_COMPLE_MA_KHACH_HANG()
			_combobox_ten_khach_hang()
			_Ma_Cong_No()
		End Sub

		Private Sub _Ma_Cong_No()
			txtmacongno.Text = New BLL_CongNo()._Ma_Cong_No()
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

		Private Sub _Load_Combobox_Hop_Dong(makh As String)
			Dim dto As New DTO_HopDong()
			dto.ma_khach_hang = makh
			cbmahopdong.DataSource = New BLL_BangKe()._List_Hop_Dong(dto)
			cbmahopdong.DisplayMember = "ma_hop_dong"
			cbmahopdong.ValueMember = "ma_hop_dong"
		End Sub

		Private Sub _Load_Combobox_Hoa_Don()
			Dim hoadon As New DTO_HoaDon()
			hoadon.ma_khach_hang = txtmakhachhang.Text.Trim()
			hoadon.ma_hop_dong = cbmahopdong.Text.Trim()
			cbhoadon.DataSource = New BLL_CongNo()._List_Hoa_Don(hoadon)
			cbhoadon.DisplayMember = "ma_hoa_don"
			cbhoadon.ValueMember = "tong_cuot_van_chuyen"
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

		Private Sub cbkhachhang_SelectedIndexChanged(sender As Object, e As EventArgs)
			If cbkhachhang.Text.Trim() <> "" Then
				lvcongno.Items.Clear()
				lvthanhtoan.Items.Clear()
				txtmakhachhang.Text = cbkhachhang.SelectedValue.ToString()
			End If
		End Sub

		Private Sub txtmakhachhang_TextChanged(sender As Object, e As EventArgs)
			If txtmakhachhang.Text.Trim() <> "" Then
				Dim dto As New DTO_KhachHang()
				dto.ma_khach_hang = txtmakhachhang.Text.Trim().ToString()
				_Load_Combobox_Hop_Dong(dto.ma_khach_hang)
			Else
				lvcongno.Items.Clear()
				lvthanhtoan.Items.Clear()
			End If
		End Sub

		Private Sub btnthoat_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		Private Sub cbmahopdong_SelectedIndexChanged(sender As Object, e As EventArgs)
			If txtmakhachhang.Text.Trim() <> "" AndAlso cbmahopdong.Text.Trim() <> "" Then
				_Load_Combobox_Hoa_Don()
				_Load_List_View_Thanh_Toan()

				_Load_List_View_Cong_No()
			End If
		End Sub

		Private Sub cbhoadon_SelectedIndexChanged(sender As Object, e As EventArgs)
			If cbhoadon.Text.Trim() <> "" Then
				txtsotien.Text = Single.Parse(cbhoadon.SelectedValue.ToString()).ToString("###,###,###")
				Dim hoadon As New DTO_HoaDon()
				hoadon.ma_khach_hang = txtmakhachhang.Text.Trim()
				hoadon.ma_hop_dong = cbmahopdong.Text.Trim()
				For Each hd As DTO_HoaDon In New BLL_CongNo()._List_Hoa_Don(hoadon)
							'dtpngayxuathoadon.Value = hd.ngay_tao;
					If hd.ma_hoa_don.Trim() = cbhoadon.Text.Trim() Then
					End If
				Next
			End If
		End Sub

		Private Sub btnluucongno_Click(sender As Object, e As EventArgs)
			Dim message As String = ""
			If txtmakhachhang.Text.Trim() = "" Then
				message += "Chưa Nhập Mã Khách Hàng "
			End If
			If cbmahopdong.Text.Trim() = "" Then
				message += If(String.IsNullOrEmpty(message), "", "-")
				message += " Chưa Chọn Mã Hợp Đồng"
			End If
			If txtmacongno.Text.Trim() = "" Then
				message += If(String.IsNullOrEmpty(message), "", "-")
				message += " Chưa Nhập Mã Công Nơ"
			End If
			If cbhoadon.Text.Trim() = "" Then
				message += If(String.IsNullOrEmpty(message), "", "-")
				message += " Chưa Chọn Mã Hóa Đơn "
			End If
			If message <> "" Then
				MessageBox.Show("Bạn " & message & "!", "Thống Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
			End If
			If message = "" Then
				Dim hoadon As New DTO_HoaDon()
				hoadon.ma_khach_hang = txtmakhachhang.Text.Trim()
				hoadon.ma_hop_dong = cbmahopdong.Text.Trim()
				hoadon.ma_hoa_don = cbhoadon.Text.Trim()

				Dim congno As New DTO_CongNo()
				congno.ma_cong_no = txtmacongno.Text.Trim()

				Dim i As Integer = New BLL_CongNo()._Them_Cong_No_Khach_Hang(hoadon, congno)
				If i = 0 Then
					MessageBox.Show("Thêm Công Nợ Thành Công! ", "Thống Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
					_Ma_Cong_No()
					_Load_List_View_Thanh_Toan()
					_Load_List_View_Cong_No()
				Else
					MessageBox.Show("Thêm Công Nợ Thất Bại! ", "Thống Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
				End If
			End If
		End Sub

		Private Sub btntaoma_Click(sender As Object, e As EventArgs)
			_Ma_Cong_No()
		End Sub

		Private Sub _Load_List_View_Cong_No()
			If txtmakhachhang.Text.Trim() <> "" Then
				lvcongno.Items.Clear()

				Dim congno As New DTO_CongNo()
				congno.ma_khach_hang = txtmakhachhang.Text.Trim()
				congno.ma_cong_no = cbmahopdong.Text.Trim()
				Dim STT As Integer = 1
				Dim tongcongno As Single = 0
				If New BLL_CongNo()._List_View_Cong_No_Khach_Hang(congno) IsNot Nothing Then
					For Each co As DTO_CongNo In New BLL_CongNo()._List_View_Cong_No_Khach_Hang(congno)
						Dim item As New ListViewItem(STT.ToString())

						Dim lv1 As New ListViewItem.ListViewSubItem(item, co.ngay_xuat_hd.ToShortDateString())
						item.SubItems.Add(lv1)

						Dim lv2 As New ListViewItem.ListViewSubItem(item, co.ma_hoa_don.Trim())
						item.SubItems.Add(lv2)

						Dim lv3 As New ListViewItem.ListViewSubItem(item, co.so_tien_thanh_toan.ToString("###,###,###"))
						item.SubItems.Add(lv3)

						Dim lv4 As New ListViewItem.ListViewSubItem(item, "VNĐ")
						item.SubItems.Add(lv4)

						lvcongno.Items.Add(item)
						STT += 1
						tongcongno += co.so_tien_thanh_toan
					Next
				End If

				Dim itemm As New ListViewItem("")
				itemm.UseItemStyleForSubItems = False

				Dim lvv1 As New ListViewItem.ListViewSubItem(itemm, "")
				itemm.SubItems.Add(lvv1)

				Dim lvv2 As New ListViewItem.ListViewSubItem(itemm, "Tổng Cộng")
				itemm.SubItems.Add(lvv2)
				lvv2.ForeColor = System.Drawing.Color.Blue
				lvv2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, System.Drawing.FontStyle.Regular)

				Dim lvv3 As New ListViewItem.ListViewSubItem(itemm, tongcongno.ToString("###,###,###"))
				itemm.SubItems.Add(lvv3)
				lvv3.ForeColor = System.Drawing.Color.Red
				lvv3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, System.Drawing.FontStyle.Regular)

				Dim lvv4 As New ListViewItem.ListViewSubItem(itemm, "VNĐ")
				itemm.SubItems.Add(lvv4)
				lvv4.ForeColor = System.Drawing.Color.Red
				lvv4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, System.Drawing.FontStyle.Regular)
				lvcongno.Items.Add(itemm)
				'TONG TIEN THANH TOAN 
				Dim itemm2 As New ListViewItem("")
				itemm2.UseItemStyleForSubItems = False

				Dim lvv12 As New ListViewItem.ListViewSubItem(itemm2, "")
				itemm2.SubItems.Add(lvv12)

				Dim lvv22 As New ListViewItem.ListViewSubItem(itemm2, "Tổng Tiền Thanh Toán")
				itemm2.SubItems.Add(lvv22)
				lvv22.ForeColor = System.Drawing.Color.Blue
				lvv22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, System.Drawing.FontStyle.Regular)

				Dim lvv32 As New ListViewItem.ListViewSubItem(itemm2, _TongTien_Thanh_Toan.ToString("###,###,###"))
				itemm2.SubItems.Add(lvv32)
				lvv32.ForeColor = System.Drawing.Color.Red
				lvv32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, System.Drawing.FontStyle.Regular)

				Dim lvv42 As New ListViewItem.ListViewSubItem(itemm2, "VNĐ")
				itemm2.SubItems.Add(lvv42)
				lvv42.ForeColor = System.Drawing.Color.Red
				lvv42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, System.Drawing.FontStyle.Regular)

				lvcongno.Items.Add(itemm2)
				'TONG TIEN CON LAI
				Dim itemm3 As New ListViewItem("")
				itemm3.UseItemStyleForSubItems = False

				Dim lvv13 As New ListViewItem.ListViewSubItem(itemm3, "")
				itemm3.SubItems.Add(lvv13)

				Dim lvv23 As New ListViewItem.ListViewSubItem(itemm3, "Số Tiền Còn Lại")
				itemm3.SubItems.Add(lvv23)
				lvv23.ForeColor = System.Drawing.Color.Blue
				lvv23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, System.Drawing.FontStyle.Regular)

				Dim lvv33 As New ListViewItem.ListViewSubItem(itemm3, (tongcongno - _TongTien_Thanh_Toan).ToString("###,###,###"))
				itemm3.SubItems.Add(lvv33)
				lvv33.ForeColor = System.Drawing.Color.Red
				lvv33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, System.Drawing.FontStyle.Regular)

				Dim lvv43 As New ListViewItem.ListViewSubItem(itemm3, "VNĐ")
				itemm3.SubItems.Add(lvv42)
				lvv43.ForeColor = System.Drawing.Color.Red
				lvv43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, System.Drawing.FontStyle.Regular)



				lvcongno.Items.Add(itemm3)
				_TongTien_Thanh_Toan = 0
			End If
		End Sub

		Private Sub mnxoa_Click(sender As Object, e As EventArgs)
			For Each item As ListViewItem In lvcongno.Items
				If item.Selected AndAlso item.SubItems(0).Text.Trim() <> "" Then
					Dim kq As DialogResult = MessageBox.Show("Bạn Chắc Chắc Muốn Xóa Mã Hóa Đơn :" & item.SubItems(2).Text.Trim() & " Và Số Tiền : " & item.SubItems(3).Text.Trim() & "VNĐ!", "Thống Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
					If kq = DialogResult.Yes Then
						Dim congno As New DTO_CongNo()
						congno.ma_hoa_don = item.SubItems(2).Text.Trim()
						Dim i As Integer = New BLL_CongNo()._Xoa_Cong_No(congno)
						If i = 0 Then
							_Load_List_View_Thanh_Toan()
							_Load_List_View_Cong_No()
						Else
							MessageBox.Show("Xóa Thất Bại. Vui Lòng Kiểm Tra Lại! ", "Thống Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
						End If
					End If
				End If
			Next
			For Each item As ListViewItem In lvthanhtoan.Items
				If item.Selected AndAlso item.SubItems(0).Text.Trim() <> "" Then
					Dim kq As DialogResult = MessageBox.Show("Bạn Chắc Chắc Muốn Xóa Số Tiền :" & item.SubItems(2).Text.Trim() & "VNĐ!", "Thống Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
					If kq = DialogResult.Yes Then
						Dim tt As New DTO_ThanhToan()
						tt.ma_thanh_toan = Integer.Parse(item.SubItems(4).Text.Trim())
						Dim i As Integer = New BLL_CongNo()._Xoa_So_Tien_Thanh_Toan(tt)
						If i = 0 Then
							_Load_List_View_Thanh_Toan()
							_Load_List_View_Cong_No()
						Else
							MessageBox.Show("Xóa Thất Bại. Vui Lòng Kiểm Tra Lại! ", "Thống Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
						End If
					End If
				End If
			Next
		End Sub

		Private Sub btnthemthanhtoan_Click(sender As Object, e As EventArgs)
			Dim message As String = ""
			If txtmakhachhang.Text.Trim() = "" Then
				message += "Chưa Nhập Mã Khách Hàng "
			End If
			If cbmahopdong.Text.Trim() = "" Then
                message += If(String.IsNullOrEmpty(message), "", "-")
				message += " Chưa Chọn Mã Hợp Đồng"
			End If
			If message <> "" Then
				MessageBox.Show("Bạn " & message & "!", "Thống Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
			End If
			If message = "" Then
				Dim tt As New DTO_ThanhToan()
				tt.ma_hop_dong = cbmahopdong.Text.Trim()
				tt.ma_khach_hang = txtmakhachhang.Text.Trim()
				tt.ngay_thanh_toan = dtpngaythanhtoan.Value
				tt.so_tien_thanh_toan = Single.Parse(txtsotienthanhtoan.Text.Trim())

				Dim i As Integer = New BLL_CongNo()._Them_Thanh_Toan_Cong_No(tt)
				If i = 0 Then
					MessageBox.Show("Thêm Thanh Toán Thành Công! ", "Thống Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
					_Load_List_View_Thanh_Toan()
					_Load_List_View_Cong_No()
				Else
					MessageBox.Show("Thêm Thanh Toán Thất Bại! ", "Thống Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
				End If
			End If
		End Sub

		Private Sub _Load_List_View_Thanh_Toan()
			If txtmakhachhang.Text.Trim() <> "" Then
				lvthanhtoan.Items.Clear()
				Dim tt As New DTO_ThanhToan()
				tt.ma_khach_hang = txtmakhachhang.Text.Trim()
				tt.ma_hop_dong = cbmahopdong.Text.Trim()
				Dim STT As Integer = 1
				Dim tongcong As Single = 0
				If New BLL_CongNo()._List_View_Thanh_Toan(tt) IsNot Nothing Then
					For Each dto As DTO_ThanhToan In New BLL_CongNo()._List_View_Thanh_Toan(tt)
						Dim item As New ListViewItem(STT.ToString())

						Dim lv1 As New ListViewItem.ListViewSubItem(item, dto.ngay_thanh_toan.ToShortDateString())
						item.SubItems.Add(lv1)

						Dim lv2 As New ListViewItem.ListViewSubItem(item, dto.so_tien_thanh_toan.ToString("###,###,###"))
						item.SubItems.Add(lv2)

						Dim lv3 As New ListViewItem.ListViewSubItem(item, "VNĐ")
						item.SubItems.Add(lv3)

						Dim lv4 As New ListViewItem.ListViewSubItem(item, dto.ma_thanh_toan.ToString())
						item.SubItems.Add(lv4)

						lvthanhtoan.Items.Add(item)
						STT += 1
						tongcong += dto.so_tien_thanh_toan
					Next
				Else
					_TongTien_Thanh_Toan = 0
				End If

				_TongTien_Thanh_Toan += tongcong

				Dim itemm As New ListViewItem("")
				itemm.UseItemStyleForSubItems = False


				Dim lvv2 As New ListViewItem.ListViewSubItem(itemm, "Tổng Cộng")
				itemm.SubItems.Add(lvv2)
				lvv2.ForeColor = System.Drawing.Color.Blue
				lvv2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, System.Drawing.FontStyle.Regular)

				Dim lvv3 As New ListViewItem.ListViewSubItem(itemm, tongcong.ToString("###,###,###"))
				itemm.SubItems.Add(lvv3)
				lvv3.ForeColor = System.Drawing.Color.Red
				lvv3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, System.Drawing.FontStyle.Regular)

				Dim lvv4 As New ListViewItem.ListViewSubItem(itemm, "VNĐ")
				itemm.SubItems.Add(lvv4)
				lvv4.ForeColor = System.Drawing.Color.Red
				lvv4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, System.Drawing.FontStyle.Regular)

				lvthanhtoan.Items.Add(itemm)
			End If
		End Sub

	End Class
End Namespace

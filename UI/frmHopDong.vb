Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports QLDVVTHH.BLL
Imports QLDVVTHH.DTO
Imports QLDVVTHH.DAL

Namespace UI
	Public Partial Class frmHopDong
		Inherits Form
		Private auto As New AutoCompleteStringCollection()
		Private bll_hd As BLL_HopDong = Nothing
		Public Sub New()
			bll_hd = New BLL_HopDong()
			InitializeComponent()
			_AUTO_COMPLE_MA_KHACH_HANG()
			_ma_hop_dong()
			_combobox_ten_khach_hang()
		End Sub

		Private Sub _AUTO_COMPLE_MA_KHACH_HANG()
			Dim dt As DataTable = New BLL_HopDong()._Bang_Ma_Khach_Hang()
			If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
				For Each dr As DataRow In dt.Rows
					auto.Add(dr("ma_khach_hang").ToString())
				Next
			End If
			txtmakhachhang.AutoCompleteMode = AutoCompleteMode.Suggest
			txtmakhachhang.AutoCompleteSource = AutoCompleteSource.CustomSource
			txtmakhachhang.AutoCompleteCustomSource = auto
		End Sub

		Private Sub _ma_hop_dong()
			txtmahopdong.Text = New BLL_HopDong()._Ma_Hop_Dong().ToString()
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

		Private Sub btnthoat_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		Private Sub btnluu_Click(sender As Object, e As EventArgs)
			Dim kq As DialogResult = MessageBox.Show("Bạn Muốn Lưu Hợp Đồng Mới", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
			If kq = DialogResult.OK Then
				If txtmahopdong.Text.Trim() = "" OrElse txtmakhachhang.Text.Trim() = "" Then
					MessageBox.Show("Thông Tìn Không Đầy Đủ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
				Else
					If dtpngaybatdau.Value >= dtpngayketthuc.Value Then
						MessageBox.Show("Thời Gian Không Hợp Lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
					Else

						Dim hd As New DTO_HopDong()
						hd.ma_hop_dong = txtmahopdong.Text.Trim()
						hd.ma_khach_hang = txtmakhachhang.Text.Trim()
						hd.ngay_tao = DateTime.Now
						hd.ngay_bat_dau = dtpngaybatdau.Value
						hd.ngay_ket_thuc = dtpngayketthuc.Value
						hd.loaihanghoa = txtloaihanghoa.Text.Trim()
						hd.lotrinhvanchuyen = txtlotrinhvanchuyen.Text
						hd.phuongthucvanchuyen = txtphuongthucvanchuyen.Text.Trim()
						hd.giatrihopdong = txtgiatrihopdong.Text.Trim()
						hd.phuongthucthanhtoan = txtphuongthucthanhtoan.Text.Trim()
						Dim i As Integer = bll_hd._Them_Hop_Dong(hd)
						If i = 1 Then
							_Add_ListView()
							MessageBox.Show("Lưu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
							txtmahopdong.Text = New BLL_HopDong()._Ma_Hop_Dong()
						Else
							MessageBox.Show("Lưu Hợp Đồng Mới Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
						End If
					End If
				End If
			End If
		End Sub

		Private Sub btnshow_Click(sender As Object, e As EventArgs)
			If txtmakhachhang.Text.Trim() <> "" Then
				Dim dto As New DTO_KhachHang()
				dto.ma_khach_hang = txtmakhachhang.Text.ToString()
			End If
		End Sub

		Private Sub btnrefesh_Click(sender As Object, e As EventArgs)
			txtmahopdong.Text = ""
			txtmakhachhang.Text = ""
			txtloaihanghoa.Text = ""
			txtlotrinhvanchuyen.Text = ""
			txtphuongthucvanchuyen.Text = ""
			txtgiatrihopdong.Text = ""
			txtphuongthucthanhtoan.Text = ""
		End Sub

		Private Sub btntaoma_Click(sender As Object, e As EventArgs)
			_ma_hop_dong()
		End Sub

		Private Sub _Add_ListView()
			lvthongtinhopdong.Items.Clear()
			Dim MA As New ListViewItem("1")
			Dim lv0 As New ListViewItem.ListViewSubItem(MA, txtmakhachhang.Text)
			MA.SubItems.Add(lv0)
			Dim lv1 As New ListViewItem.ListViewSubItem(MA, cbkhachhang.Text.Trim())
			MA.SubItems.Add(lv1)
			Dim lv2 As New ListViewItem.ListViewSubItem(MA, txtmahopdong.Text)
			MA.SubItems.Add(lv2)
			Dim lv3 As New ListViewItem.ListViewSubItem(MA, dtpngaybatdau.Value.ToShortDateString())
			MA.SubItems.Add(lv3)
			Dim lv4 As New ListViewItem.ListViewSubItem(MA, dtpngayketthuc.Value.ToShortDateString())
			MA.SubItems.Add(lv4)

			Dim lv5 As New ListViewItem.ListViewSubItem(MA, txtloaihanghoa.Text)
			MA.SubItems.Add(lv5)
			Dim lv6 As New ListViewItem.ListViewSubItem(MA, txtlotrinhvanchuyen.Text)
			MA.SubItems.Add(lv6)
			Dim lv7 As New ListViewItem.ListViewSubItem(MA, txtphuongthucvanchuyen.Text)
			MA.SubItems.Add(lv7)
			Dim lv8 As New ListViewItem.ListViewSubItem(MA, txtgiatrihopdong.Text)
			MA.SubItems.Add(lv8)
			Dim lv9 As New ListViewItem.ListViewSubItem(MA, txtphuongthucthanhtoan.Text)
			MA.SubItems.Add(lv9)
			Dim lv10 As New ListViewItem.ListViewSubItem(MA, DateTime.Now.ToShortDateString())
			MA.SubItems.Add(lv10)

			lvthongtinhopdong.Items.Add(MA)
			lvthongtinhopdong.View = View.Details
		End Sub

		Private Sub btnxoa_Click(sender As Object, e As EventArgs)
			Dim del As Boolean = False
			For Each item As ListViewItem In lvthongtinhopdong.Items
				If item.Selected Then
					Dim hd As New DTO_HopDong()
					hd.ma_hop_dong = item.SubItems(3).Text.ToString()
					Dim kq As DialogResult = MessageBox.Show("Bạn Muốn Xóa Hợp Đồng Có Mã : " & hd.ma_hop_dong, "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
					If kq = DialogResult.OK Then
						del = New BLL_HopDong()._Xoa_Hop_Dong(hd)
					End If
					If del = True Then
						item.Remove()
					End If
				End If
			Next
			If del = True Then
				MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
			End If
			If del = False Then
				MessageBox.Show("Không Xóa Được Hợp Đồng Này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
			End If
		End Sub

		Private Sub lvthongtinhopdong_SelectedIndexChanged(sender As Object, e As EventArgs)
			For Each item As ListViewItem In lvthongtinhopdong.Items
				If item.Selected Then
					txtmakhachhang.Text = item.SubItems(1).Text
					txtmahopdong.Text = item.SubItems(3).Text
					dtpngaybatdau.Value = Convert.ToDateTime(item.SubItems(4).Text)
					dtpngayketthuc.Value = Convert.ToDateTime(item.SubItems(5).Text)
					txtloaihanghoa.Text = item.SubItems(6).Text
					txtlotrinhvanchuyen.Text = item.SubItems(7).Text
					txtphuongthucvanchuyen.Text = item.SubItems(8).Text
					txtgiatrihopdong.Text = item.SubItems(9).Text

					txtphuongthucthanhtoan.Text = item.SubItems(10).Text
				End If
			Next
		End Sub

		Private Sub btncapnhat_Click(sender As Object, e As EventArgs)

			Dim dto As New DTO_HopDong()
			dto.ma_hop_dong = txtmahopdong.Text
			dto.ma_khach_hang = txtmakhachhang.Text
			dto.ngay_bat_dau = dtpngaybatdau.Value
			dto.ngay_ket_thuc = dtpngayketthuc.Value
			dto.loaihanghoa = txtloaihanghoa.Text.Trim()
			dto.lotrinhvanchuyen = txtlotrinhvanchuyen.Text
			dto.phuongthucvanchuyen = txtphuongthucvanchuyen.Text.Trim()
			dto.giatrihopdong = txtgiatrihopdong.Text.Trim()
			dto.phuongthucthanhtoan = txtphuongthucthanhtoan.Text.Trim()
			If txtmahopdong.Text.Trim() <> New BLL_HopDong()._Ma_Hop_Dong().ToString() Then
				Dim kq As DialogResult = MessageBox.Show("Bạn Muốn Cập Nhật Hợp Đồng : " & txtmahopdong.Text, "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
				Dim kt As Boolean = True
				If kq = DialogResult.OK Then
					kt = New BLL_HopDong()._Update_Hop_Dong(dto)
				End If
				If kt = True Then
					MessageBox.Show("Cập Nhật Thành Công", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
					For Each item As ListViewItem In lvthongtinhopdong.Items
						If item.Selected Then
							item.SubItems(1).Text = txtmakhachhang.Text
							item.SubItems(3).Text = txtmahopdong.Text
							item.SubItems(4).Text = dtpngaybatdau.Value.ToShortDateString()
							item.SubItems(5).Text = dtpngayketthuc.Value.ToShortDateString()
							item.SubItems(6).Text = txtloaihanghoa.Text
							item.SubItems(7).Text = txtlotrinhvanchuyen.Text
							item.SubItems(8).Text = txtphuongthucvanchuyen.Text
							item.SubItems(9).Text = txtgiatrihopdong.Text

							item.SubItems(10).Text = txtphuongthucthanhtoan.Text
						End If
					Next
				End If
			End If
		End Sub

		Private Sub btntim_Click(sender As Object, e As EventArgs)
			lvthongtinhopdong.Items.Clear()
			Dim dt As New DTO_HopDong()
			dt.ma_hop_dong = txtmahopdong.Text.Trim()
			dt.ma_khach_hang = txtmakhachhang.Text.Trim()
			Dim stt As Integer = 1
			If New BLL_HopDong()._Tim_Khach_Hang_Hop_Dong(dt) IsNot Nothing Then
				For Each dto As DTO_HopDong In New BLL_HopDong()._Tim_Khach_Hang_Hop_Dong(dt)
					Dim MA As New ListViewItem(stt.ToString())
					Dim lv0 As New ListViewItem.ListViewSubItem(MA, dto.ma_khach_hang)
					MA.SubItems.Add(lv0)
					Dim lv1 As New ListViewItem.ListViewSubItem(MA, dto.ten_khach_hang)
					MA.SubItems.Add(lv1)
					Dim lv2 As New ListViewItem.ListViewSubItem(MA, dto.ma_hop_dong)
					MA.SubItems.Add(lv2)
					Dim lv3 As New ListViewItem.ListViewSubItem(MA, dto.ngay_bat_dau.ToShortDateString())
					MA.SubItems.Add(lv3)
					Dim lv4 As New ListViewItem.ListViewSubItem(MA, dto.ngay_ket_thuc.ToShortDateString())
					MA.SubItems.Add(lv4)
					Dim lv5 As New ListViewItem.ListViewSubItem(MA, dto.loaihanghoa)
					MA.SubItems.Add(lv5)
					Dim lv6 As New ListViewItem.ListViewSubItem(MA, dto.lotrinhvanchuyen)
					MA.SubItems.Add(lv6)
					Dim lv7 As New ListViewItem.ListViewSubItem(MA, dto.phuongthucvanchuyen)
					MA.SubItems.Add(lv7)
					Dim lv8 As New ListViewItem.ListViewSubItem(MA, dto.giatrihopdong)
					MA.SubItems.Add(lv8)
					Dim lv9 As New ListViewItem.ListViewSubItem(MA, dto.phuongthucthanhtoan)
					MA.SubItems.Add(lv9)

					lvthongtinhopdong.Items.Add(MA)
					stt += 1
				Next
			End If
			lvthongtinhopdong.View = View.Details
		End Sub

		Private Sub txtmakhachhang_TextChanged(sender As Object, e As EventArgs)
			If txtmakhachhang.Text.Trim() <> "" Then
				Dim dto As New DTO_KhachHang()
				dto.ma_khach_hang = txtmakhachhang.Text.Trim().ToString()
			Else
				lvthongtinhopdong.Items.Clear()
			End If
		End Sub

		Private Sub cbkhachhang_SelectedIndexChanged(sender As Object, e As EventArgs)
			lvthongtinhopdong.Items.Clear()
			If cbkhachhang.Text.Trim() <> "" Then
				txtmakhachhang.Text = cbkhachhang.SelectedValue.ToString()
			End If
		End Sub
	End Class
End Namespace

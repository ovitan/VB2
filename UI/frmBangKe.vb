Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports QLDVVTHH.DTO
Imports QLDVVTHH.BLL
Namespace UI
	Public Partial Class frmBangKe
		Inherits Form
		Private auto As New AutoCompleteStringCollection()
		Public Sub New()
			InitializeComponent()
			_AUTO_COMPLE_MA_KHACH_HANG()
			txtmabangke.Text = New BLL_BangKe()._Ma_Bang_Ke()
			_combobox_ten_khach_hang()
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
			cbhopdong.DataSource = New BLL_BangKe()._List_Hop_Dong(dto)
			cbhopdong.DisplayMember = "ma_hop_dong"
			cbhopdong.ValueMember = "ma_hop_dong"
		End Sub

		Private Sub btnthoat_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		Private Sub reset_control()
			txtdongiachuyen.Text = ""
			txtdongiatan.Text = ""
			txtmabangke.Text = ""
			txtmasoxe.Text = ""
			txtnoigiao.Text = ""
			txtnoinhan.Text = ""
			txtkhoiluong.Text = ""
		End Sub

		Private Sub txtdongiatan_KeyPress(sender As Object, e As KeyPressEventArgs)
			If [Char].IsDigit(e.KeyChar) OrElse [Char].IsControl(e.KeyChar) Then
			Else
				e.Handled = True
			End If
		End Sub

		Private Sub txtdongiachuyen_KeyPress(sender As Object, e As KeyPressEventArgs)
			If [Char].IsDigit(e.KeyChar) OrElse [Char].IsControl(e.KeyChar) Then
			Else
				e.Handled = True
			End If
		End Sub
		Private Sub _Load_ComBobox_Dieu_xe()
			Dim dx As New DTO_DieuXe()
			dx.ma_khach_hang = txtmakhachhang.Text.Trim()
			cbmadieuxe.DataSource = New BLL_BangKe()._List_Ma_Dieu_Xe(dx)
			cbmadieuxe.DisplayMember = "ma_dieu_xe"
			cbmadieuxe.ValueMember = "ma_so_xe"
		End Sub
		Private Sub txtmakhachhang_TextChanged(sender As Object, e As EventArgs)
			If txtmakhachhang.Text.Trim() <> "" Then
				Dim dto As New DTO_KhachHang()
				dto.ma_khach_hang = txtmakhachhang.Text.Trim().ToString()
				_Load_Combobox_Hop_Dong(dto.ma_khach_hang)

				_Load_ComBobox_Dieu_xe()
			Else
				lvthongtin.Items.Clear()
			End If
		End Sub

		Private Sub btnluu_Click(sender As Object, e As EventArgs)
			If txtmabangke.Text.Trim() = New BLL_BangKe()._Ma_Bang_Ke() Then
				Dim message As String = ""
				If txtmabangke.Text.Trim() = "" Then
					message += " Chưa Nhập Mã Bảng Kê "
				End If
				If txtmakhachhang.Text.Trim() = "" Then
					message += (If(String.IsNullOrEmpty(message), " ", " - ")) & "Chưa Nhập Mã Khách Hàng "
				End If
				If cbhopdong.Text.Trim() = "" Then
					message += (If(String.IsNullOrEmpty(message), " ", " - ")) & "Chưa Tạo Hợp Đồng "
				End If
				If txtmasoxe.Text.Trim() = "" Then
					message += (If(String.IsNullOrEmpty(message), " ", " - ")) & "Chưa Nhập Mã Số Xe "
				End If
				If txtkhoiluong.Text.Trim() = "" Then
					message += (If(String.IsNullOrEmpty(message), " ", " - ")) & "Chưa Nhập Khối Lượng "
				End If
				If txtnoinhan.Text.Trim() = "" Then
					message += (If(String.IsNullOrEmpty(message), " ", " - ")) & "Chưa Nhập Nơi Nhận "
				End If
				If txtnoigiao.Text.Trim() = "" Then
					message += (If(String.IsNullOrEmpty(message), " ", " - ")) & "Chưa Nhập Nơi Giao "
				End If
				If cbmadieuxe.Text.Trim() = "" Then
					message += (If(String.IsNullOrEmpty(message), " ", " - ")) & "Chưa Chọn Mã Điều Xe "
				End If
				If message = "" Then
					Dim dto As New DTO_BangKe()
					dto.ma_bang_ke = txtmabangke.Text.Trim()
					dto.ma_khach_hang = txtmakhachhang.Text.Trim()
					dto.ngay_van_chuyen = dtpngayvanchuyen.Value
					dto.ngay_tao = DateTime.Now
					dto.ngay_cap_nhat = DateTime.Now
					dto.so_xe = txtmasoxe.Text.Trim()
					dto.noi_giao = txtnoigiao.Text.Trim()
					dto.noi_nhan = txtnoinhan.Text.Trim()
					dto.khoi_luong = Single.Parse("0" & txtkhoiluong.Text.Trim())
					dto.don_gia_tan = Single.Parse("0" & txtdongiatan.Text.Trim())
					dto.don_gia_chuyen = Single.Parse("0" & txtdongiachuyen.Text.Trim())
					dto.ghi_chu = rtbghichu.Text.Trim()
					dto.ma_dieu_xe = cbmadieuxe.Text.Trim()
					Dim insert As Integer = New BLL_BangKe()._Them_BangKe(dto)
					If insert = 1 Then
						message = " Lưu Bản Kê Thất Bại "
						MessageBox.Show(message & "!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
					Else
						_Load_ListView_DanhSachBangKe_KhachHang()
						_Load_ComBobox_Dieu_xe()
						txtmabangke.Text = New BLL_BangKe()._Ma_Bang_Ke()
					End If
				Else
					MessageBox.Show("Bạn" & message & "!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
				End If
			Else
				MessageBox.Show("Không Thể Thêm Mới.Kiểm Tra Lại Mã Bảng Kê !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
			End If
		End Sub

		Private Sub _Load_ListView_DanhSachBangKe_KhachHang()
			lvthongtin.Items.Clear()
			Dim bk As New DTO_BangKe()
			bk.ma_khach_hang = txtmakhachhang.Text.Trim()
			bk.ma_bang_ke = cbhopdong.Text.Trim()
			Dim STT As Integer = 1
			Dim tongcong As Single = 0
			If New BLL_BangKe().DanhSachBangKe_TheoMaKhachHang_MaHopDong(bk) IsNot Nothing Then
				For Each dto As DTO_BangKe In New BLL_BangKe().DanhSachBangKe_TheoMaKhachHang_MaHopDong(bk)
					Dim lvi As New ListViewItem(STT.ToString())
					Dim ite1 As New ListViewItem.ListViewSubItem(lvi, dto.ma_bang_ke)
					lvi.SubItems.Add(ite1)

					Dim ite11 As New ListViewItem.ListViewSubItem(lvi, dto.ma_dieu_xe.Trim())
					lvi.SubItems.Add(ite11)

					Dim ite2 As New ListViewItem.ListViewSubItem(lvi, dto.ngay_van_chuyen.ToShortDateString())
					lvi.SubItems.Add(ite2)
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

					lvthongtin.Items.Add(lvi)
					STT += 1
					tongcong += (dto.don_gia_chuyen) + (If(dto.khoi_luong > 15, ((dto.khoi_luong - 15) * dto.don_gia_tan), 0))
				Next
			End If
			lvthongtin.View = View.Details
			_Tinh_TongCong_Thue_ThanhTien("Tổng Cộng", tongcong)
			_Tinh_TongCong_Thue_ThanhTien("Thếu 10%", tongcong * 10 / 100)
			_Tinh_TongCong_Thue_ThanhTien("Tổng Thành Tiền", tongcong + (tongcong * 10 / 100))
		End Sub

		Private Sub txtkhoiluong_KeyPress(sender As Object, e As KeyPressEventArgs)
			Dim decimalChar As Char = ","C
            If [Char].IsDigit(e.KeyChar) OrElse [Char].IsControl(e.KeyChar) OrElse e.KeyChar = Chr(54) Then
            ElseIf e.KeyChar = decimalChar AndAlso txtkhoiluong.Text.IndexOf(decimalChar.ToString()) = -1 Then
            Else
                e.Handled = True
            End If
		End Sub

		Private Sub btntaoma_Click(sender As Object, e As EventArgs)
			txtmabangke.Text = New BLL_BangKe()._Ma_Bang_Ke()
		End Sub

		Private Sub btncapnhat_Click(sender As Object, e As EventArgs)
			Dim kq As DialogResult = MessageBox.Show("Bạn Muốn Cập Nhật Mã Bảng Kê : " & txtmabangke.Text.Trim(), "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
			If kq = DialogResult.OK Then
				Dim message As String = ""
				If txtmabangke.Text.Trim() = "" Then
					message += " Chưa Nhập Mã Bảng Kê "
				End If
				If txtmakhachhang.Text.Trim() = "" Then
					message += (If(String.IsNullOrEmpty(message), " ", " - ")) & "Chưa Nhập Mã Khách Hàng "
				End If
				If cbhopdong.Text.Trim() = "" Then
					message += (If(String.IsNullOrEmpty(message), " ", " - ")) & "Chưa Tạo Hợp Đồng "
				End If
				If txtmasoxe.Text.Trim() = "" Then
					message += (If(String.IsNullOrEmpty(message), " ", " - ")) & "Chưa Nhập Mã Số Xe "
				End If
				If txtkhoiluong.Text.Trim() = "" Then
					message += (If(String.IsNullOrEmpty(message), " ", " - ")) & "Chưa Nhập Khối Lượng "
				End If
				If txtnoinhan.Text.Trim() = "" Then
					message += (If(String.IsNullOrEmpty(message), " ", " - ")) & "Chưa Nhập Nơi Nhận "
				End If
				If txtnoigiao.Text.Trim() = "" Then
					message += (If(String.IsNullOrEmpty(message), " ", " - ")) & "Chưa Nhập Nơi Giao "
				End If
				If message = "" Then
					Dim dto As New DTO_BangKe()
					dto.ma_bang_ke = txtmabangke.Text.Trim()
					dto.ma_khach_hang = txtmakhachhang.Text.Trim()
					dto.ngay_van_chuyen = dtpngayvanchuyen.Value
					dto.ngay_tao = DateTime.Now
					dto.ngay_cap_nhat = DateTime.Now
					dto.so_xe = txtmasoxe.Text.Trim()
					dto.noi_giao = txtnoigiao.Text.Trim()
					dto.noi_nhan = txtnoinhan.Text.Trim()
					dto.khoi_luong = Integer.Parse("0" & txtkhoiluong.Text.Trim())
					dto.don_gia_tan = Single.Parse("0" & txtdongiatan.Text.Trim())
					dto.don_gia_chuyen = Single.Parse("0" & txtdongiachuyen.Text.Trim())
					dto.ghi_chu = rtbghichu.Text.Trim()
					dto.ma_dieu_xe = cbmadieuxe.Text.Trim()
					Dim update As Integer = New BLL_BangKe()._CapNhat_BangKe(dto)
					If update = 1 Then
						message = " Bảng Kê Này Đã Xuất Hóa Đơn Không Thể Cập Nhật "
						MessageBox.Show(message & "!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
					Else
						_Load_ListView_DanhSachBangKe_KhachHang()
						_Load_ComBobox_Dieu_xe()
						txtkhoiluong.Text = ""
						txtnoigiao.Text = ""
						rtbghichu.Text = ""
						txtmasoxe.Text = ""
						txtmabangke.Text = New BLL_BangKe()._Ma_Bang_Ke()
					End If
				Else
					MessageBox.Show("Bạn" & message & "!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
				End If
			End If

		End Sub

		Private Sub lvthongtin_SelectedIndexChanged(sender As Object, e As EventArgs)
			For Each ite As ListViewItem In lvthongtin.Items
				If ite.Selected Then
					If ite.SubItems(1).Text.Trim() <> "" Then
						txtmabangke.Text = ite.SubItems(1).Text
						dtpngayvanchuyen.Value = Convert.ToDateTime(ite.SubItems(3).Text)
						txtmasoxe.Text = ite.SubItems(4).Text
						txtnoinhan.Text = ite.SubItems(5).Text
						txtnoigiao.Text = ite.SubItems(6).Text
						txtkhoiluong.Text = ite.SubItems(7).Text
						txtdongiachuyen.Text = ite.SubItems(8).Text
						txtdongiatan.Text = ite.SubItems(9).Text
						rtbghichu.Text = ite.SubItems(11).Text
					End If
				End If
			Next
		End Sub

		Private Sub btnxoa_Click(sender As Object, e As EventArgs)
			If txtmabangke.Text.Trim() <> New BLL_BangKe()._Ma_Bang_Ke() Then
				Dim kq As DialogResult = MessageBox.Show("Bạn Muốn Xóa Mã Bảng Kê : " & txtmabangke.Text.Trim(), "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
				If kq = DialogResult.OK Then
					Dim dto As New DTO_BangKe()
					dto.ma_bang_ke = txtmabangke.Text.Trim()
					Dim delete As Integer = New BLL_BangKe()._Xoa_BangKe(dto)
					If delete = 0 Then
						MessageBox.Show("Xóa Thành Công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
						_Load_ListView_DanhSachBangKe_KhachHang()
						_Load_ComBobox_Dieu_xe()
					End If
					If delete = 2 Then
						MessageBox.Show("Mã Bảng Kê Không Tồn Tại Không Thể Xóa !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
					End If
					If delete = 1 Then
						MessageBox.Show("Bảng Kê Đã Xuất Hóa Đơn Không Thể Xóa !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
					End If
				End If
			Else
				MessageBox.Show("Mã Bảng Kê Không Tồn Tại Không Thể Xóa !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
			End If
		End Sub

		Private Sub cbhopdong_SelectedIndexChanged(sender As Object, e As EventArgs)
			lvthongtin.Items.Clear()
			If cbhopdong.Text.Trim() <> "" Then
				_Load_ListView_DanhSachBangKe_KhachHang()
			End If
		End Sub

		Private Sub btntim_Click(sender As Object, e As EventArgs)
			Dim kh As New DTO_KhachHang()
			kh.ma_khach_hang = txtmakhachhang.Text.Trim()
			kh.ten_khach_hang = cbkhachhang.Text.Trim()
			Dim hd As New DTO_HopDong()
			hd.ma_hop_dong = cbhopdong.Text.Trim()
			Dim bk As New DTO_BangKe()
			bk.ma_bang_ke = txtmabangke.Text.Trim()
			bk.so_xe = txtmasoxe.Text.Trim()
			bk.ngay_van_chuyen = dtpngayvanchuyen.Value
			bk.noi_nhan = txtnoinhan.Text.Trim()
			bk.noi_giao = txtnoigiao.Text.Trim()
			bk.khoi_luong = Single.Parse("0" & txtkhoiluong.Text.Trim())
			bk.don_gia_chuyen = Single.Parse("0" & txtdongiachuyen.Text.Trim())
			bk.don_gia_tan = Single.Parse("0" & txtdongiatan.Text.Trim())
			bk.ghi_chu = rtbghichu.Text.Trim()

			lvthongtin.Items.Clear()
			Dim STT As Integer = 1
			Dim tongcong As Single = 0
			If New BLL_BangKe()._Tim_BangKe(bk, hd, kh) IsNot Nothing Then
				For Each dto As DTO_BangKe In New BLL_BangKe()._Tim_BangKe(bk, hd, kh)
					Dim lvi As New ListViewItem(STT.ToString())
					Dim ite1 As New ListViewItem.ListViewSubItem(lvi, dto.ma_bang_ke)
					lvi.SubItems.Add(ite1)

					Dim ite11 As New ListViewItem.ListViewSubItem(lvi, dto.ma_dieu_xe.Trim())
					lvi.SubItems.Add(ite11)

					Dim ite2 As New ListViewItem.ListViewSubItem(lvi, dto.ngay_van_chuyen.ToShortDateString())
					lvi.SubItems.Add(ite2)
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

					lvthongtin.Items.Add(lvi)
					STT += 1
					tongcong += (dto.don_gia_chuyen + (If(dto.khoi_luong > 15, ((dto.khoi_luong - 15) * dto.don_gia_tan), 0)))
				Next
			End If
			lvthongtin.View = View.Details
			_Tinh_TongCong_Thue_ThanhTien("Tổng Cộng", tongcong)
			_Tinh_TongCong_Thue_ThanhTien("Thếu 10%", tongcong * 10 / 100)
			_Tinh_TongCong_Thue_ThanhTien("Tổng Thành Tiền", tongcong + (tongcong * 10 / 100))
		End Sub

		Private Sub _Tinh_TongCong_Thue_ThanhTien(tengiatri As String, giatri As Single)
			If lvthongtin.Items.Count > 0 Then
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


				lvthongtin.Items.Add(MA)
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
			lvthongtin.Items.Clear()
			If cbkhachhang.Text.Trim() <> "" Then
				txtmakhachhang.Text = cbkhachhang.SelectedValue.ToString()
			End If
		End Sub

		Private Sub mnxoa_Click(sender As Object, e As EventArgs)
			Dim kq As DialogResult = MessageBox.Show("Bạn Chắc Chắc Muốn Xóa", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
			If kq = DialogResult.OK Then
				For Each item As ListViewItem In lvthongtin.Items
					If item.Selected Then
						Dim dto As New DTO_BangKe()
						dto.ma_bang_ke = item.SubItems(1).Text
						Dim delete As Integer = New BLL_BangKe()._Xoa_BangKe(dto)

						If delete = 0 Then
						End If
					End If
				Next
				_Load_ListView_DanhSachBangKe_KhachHang()
				_Load_ComBobox_Dieu_xe()
			End If
		End Sub

		Private Sub cbmadieuxe_SelectedIndexChanged(sender As Object, e As EventArgs)
			If cbmadieuxe.Text.Trim() <> "" AndAlso txtmakhachhang.Text.Trim() <> "" Then
				Dim _xe As New DTO_DieuXe()
				_xe.ma_khach_hang = txtmakhachhang.Text
				If New BLL_BangKe()._List_Ma_Dieu_Xe(_xe) IsNot Nothing Then
					For Each dx As DTO_DieuXe In New BLL_BangKe()._List_Ma_Dieu_Xe(_xe)
						If dx.ma_dieu_xe.Trim() = cbmadieuxe.Text.Trim() Then
							txtmasoxe.Text = dx.ma_so_xe.Trim()
							txtnoinhan.Text = dx.noi_nhan
							txtnoigiao.Text = dx.noi_giao
							dtpngayvanchuyen.Value = dx.ngay_dieu_xe
							txtkhoiluong.Text = dx.so_tan
							txtdongiachuyen.Text = dx.don_gia_chuyen.ToString()
							txtdongiatan.Text = dx.don_gia_tan.ToString()
						End If
					Next
				End If
			Else
				reset_control()
			End If
		End Sub
	End Class
End Namespace

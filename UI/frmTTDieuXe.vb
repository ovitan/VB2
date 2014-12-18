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
	Public Partial Class frmTTDieuXe
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub _load_tinh_trang_thanh_toan()
			Dim dt As New DataTable()
			dt.Columns.Add("Text")
			dt.Columns.Add("Value")
			Dim row As DataRow = dt.NewRow()
			row("Text") = "Chưa Thanh Toán"
			row("Value") = "0"
			dt.Rows.InsertAt(row, 0)
			Dim row2 As DataRow = dt.NewRow()
			row2("Text") = "Đã Thanh Toán"
			row2("Value") = "1"
			dt.Rows.InsertAt(row2, 0)

			cbtinhtrangthanhtoan.DataSource = dt
			cbtinhtrangthanhtoan.DisplayMember = "Text"
			cbtinhtrangthanhtoan.ValueMember = "Value"

			cbtinhtrangthanhtoan.SelectedIndex = 1
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
			cbhopdong.DataSource = New BLL_BangKe()._List_Hop_Dong(dto)
			cbhopdong.DisplayMember = "ma_hop_dong"
			cbhopdong.ValueMember = "ma_hop_dong"
		End Sub

		Private Sub _list_view_xe()
			lvxe.Items.Clear()
			If New BLL_DieuXe().Get_List_Xe_DangOBai() IsNot Nothing Then
				Dim stt As Integer = 1
				For Each xe As DTO_Xe In New BLL_DieuXe().Get_List_Xe_DangOBai()

					Dim lvi As New ListViewItem(stt.ToString())
					Dim ite1 As New ListViewItem.ListViewSubItem(lvi, xe.ma_so_xe)
					lvi.SubItems.Add(ite1)
					Dim ite2 As New ListViewItem.ListViewSubItem(lvi, xe.trong_luong.ToString("###,###"))
					lvi.SubItems.Add(ite2)
					Dim ite3 As New ListViewItem.ListViewSubItem(lvi, xe.ten_tinh_trang)
					lvi.SubItems.Add(ite3)
					Dim ite4 As New ListViewItem.ListViewSubItem(lvi, xe.loai_xe)
					lvi.SubItems.Add(ite4)


					lvxe.Items.Add(lvi)
					stt += 1
				Next
			End If
		End Sub
		Private Sub _list_view_nhan_vien(masx As String)
			Dim nv As New DTO_NhanVien()
			nv.ma_so_xe = masx
			lvnhanvien.Items.Clear()
			If New BLL_DieuXe().Get_List_Xe_Nhan_Vien(nv) IsNot Nothing Then
				Dim stt As Integer = 1

				For Each nhanvien As DTO_NhanVien In New BLL_DieuXe().Get_List_Xe_Nhan_Vien(nv)

					Dim lvi As New ListViewItem(stt.ToString())
					Dim ite1 As New ListViewItem.ListViewSubItem(lvi, nhanvien.ten_nhan_vien)
					lvi.SubItems.Add(ite1)
					Dim ite2 As New ListViewItem.ListViewSubItem(lvi, nhanvien.cmnd)
					lvi.SubItems.Add(ite2)
					Dim ite3 As New ListViewItem.ListViewSubItem(lvi, nhanvien.dia_chi)
					lvi.SubItems.Add(ite3)
					Dim ite4 As New ListViewItem.ListViewSubItem(lvi, nhanvien.dien_thoai)
					lvi.SubItems.Add(ite4)
					Dim ite5 As New ListViewItem.ListViewSubItem(lvi, nhanvien.chucvu)
					lvi.SubItems.Add(ite5)
					Dim ite6 As New ListViewItem.ListViewSubItem(lvi, nhanvien.nam_sinh.ToShortDateString())
					lvi.SubItems.Add(ite6)

					lvnhanvien.Items.Add(lvi)
					stt += 1
				Next
			End If
		End Sub
		Private Sub _load_cb_noi_nhan(bgg As DTO_BangBaoGia)
			cbnoinhan.DataSource = New BLL_DieuXe()._List_Get_NoiNhan(bgg)
			cbnoinhan.DisplayMember = "noi_nhan"
			cbnoinhan.ValueMember = "noi_nhan"
		End Sub
		Private Sub _load_cb_noi_giao(xx As DTO_DieuXe)
			cbnoigiao.DataSource = New BLL_DieuXe()._List_Get_NoiGiao(xx)
			cbnoigiao.DisplayMember = "noi_giao"
			cbnoigiao.ValueMember = "noi_giao"
		End Sub
        'Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        '    Me.Close()
        'End Sub
		Private Sub _Load_List_View_Dieu_Xe(mahopdong As String)
			If cbhopdong.Text.Trim() <> "" Then
				lvthongtindieuxe.Items.Clear()
				lvthongtindieuxe.Groups.Clear()
				Dim xxx As New DTO_DieuXe()
				xxx.ma_hop_dong = mahopdong
				If New BLL_DieuXe()._List_Get_Dieu_Xe_By_KhachHang_HopDong(xxx) IsNot Nothing Then
					For Each dx As DTO_DieuXe In New BLL_DieuXe()._List_Get_Dieu_Xe_By_KhachHang_HopDong(xxx)
						Dim item As New ListViewItem(New String() {"", dx.ma_so_xe, dx.tai_trong_xe.ToString(), dx.noi_nhan, dx.noi_giao, dx.so_tan, _
							dx.ngay_dieu_xe.ToShortDateString(), If(dx.ngay_ve.ToShortDateString() = "01/01/0001", "", dx.ngay_ve.ToShortDateString()), dx.tinh_trang_thanh_toan, dx.ma_dieu_xe})
						GroupItem(item)
						Me.lvthongtindieuxe.Items.Add(item)
					Next
				End If
			End If
		End Sub
		Private Sub GroupItem(item As ListViewItem)
			Dim group_exists As Boolean = False
			For Each group As ListViewGroup In Me.lvthongtindieuxe.Groups
				If group.Header = item.SubItems(9).Text Then
					item.Group = group
					group_exists = True
					Exit For
				End If
			Next
			If Not group_exists Then
				Dim group As New ListViewGroup(item.SubItems(9).Text)
				Me.lvthongtindieuxe.Groups.Add(group)
				item.Group = group
			End If
		End Sub
        Private Sub frmTTDieuXe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            _load_tinh_trang_thanh_toan()
            _combobox_ten_khach_hang()
            txtmadieuxe.Text = New BLL_DieuXe()._Ma_Dieu_Xe_Moi()
            _list_view_xe()
        End Sub

        'Private Sub cbkhachhang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbkhachhang.SelectedIndexChanged
        '    If cbkhachhang.Text.Trim() <> "" Then
        '        _Load_Combobox_Hop_Dong(cbkhachhang.SelectedValue.ToString().Trim())
        '    Else
        '        cbhopdong.DataSource = Nothing
        '    End If
        'End Sub

        Private Sub txtsotan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsotan.KeyPress
            'Dim decimalChar As Char = ","C
            If [Char].IsDigit(e.KeyChar) OrElse [Char].IsControl(e.KeyChar) = True OrElse e.KeyChar = Chr(54) Then
                'ElseIf e.KeyChar = decimalChar AndAlso txtsotan.Text.IndexOf(decimalChar.ToString()) = -1 Then
            Else
                e.Handled = True
            End If
        End Sub

        Private Sub btnthemma_Click(sender As Object, e As EventArgs) Handles btnthemma.Click
            txtmadieuxe.Text = New BLL_DieuXe()._Ma_Dieu_Xe_Moi()
        End Sub

        Private Sub lvxe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvxe.SelectedIndexChanged
            For Each ite As ListViewItem In lvxe.Items
                If ite.Selected Then
                    lvnhanvien.Items.Clear()
                    _list_view_nhan_vien(ite.SubItems(1).Text)
                End If
            Next
        End Sub

        Private Sub cbhopdong_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbhopdong.SelectedIndexChanged
            If cbhopdong.Text.Trim() <> "" Then
                Dim bgg As New DTO_BangBaoGia()
                bgg.ma_hop_dong = cbhopdong.Text.Trim()
                _Load_List_View_Dieu_Xe(cbhopdong.Text.Trim())

                Dim bg As New DTO_BangBaoGia()
                bg.ma_hop_dong = cbhopdong.Text.Trim()
                cbbaogia.DataSource = New BLL_DieuXe()._List_Get_Ma_Bao_Gia(bg)
                cbbaogia.DisplayMember = "ma_bao_gia"
                cbbaogia.ValueMember = "ma_bao_gia"
            End If
        End Sub

        Private Sub cbnoinhan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbnoinhan.SelectedIndexChanged
            If cbnoinhan.Text.Trim() <> "" Then
                Dim xx As New DTO_DieuXe()
                xx.noi_nhan = cbnoinhan.Text.Trim()
                _load_cb_noi_giao(xx)
            End If
        End Sub
		Private Sub _Them_Dieu_Xe()
			Dim message As String = ""
			If cbkhachhang.Text.Trim() = "" Then
				message += " Chưa Chọn Khách Hàng "
			End If
			If cbhopdong.Text.Trim() = "" Then
				message += (If(String.IsNullOrEmpty(message), " ", " - ")) & "Chưa Chọn Mã Hợp Đồng "
			End If
			If txtmadieuxe.Text.Trim() = "" Then
				message += (If(String.IsNullOrEmpty(message), " ", " - ")) & "Chưa Có Mã Điều Xe"
			End If
			If txtsotan.Text.Trim() = "" Then
				message += (If(String.IsNullOrEmpty(message), " ", " - ")) & "Chưa Nhập Khối Lượng "
			End If
			If cbnoinhan.Text.Trim() = "" Then
				message += (If(String.IsNullOrEmpty(message), " ", " - ")) & "Chưa Chọn Nơi Nhận "
			End If
			If cbnoigiao.Text.Trim() = "" Then
				message += (If(String.IsNullOrEmpty(message), " ", " - ")) & "Chưa Chọn Nơi Giao "
			End If
			Dim stt As Integer = 0
			Dim sosanh As Boolean = True
			Dim _tong_tan As Single = 0
			For Each item As ListViewItem In lvxe.Items

				If item.Checked Then
					stt += 1
					_tong_tan += Single.Parse(item.SubItems(2).Text)
				End If
			Next
			If _tong_tan < Single.Parse("0" & txtsotan.Text.Trim()) Then
				sosanh = False
			End If
			If stt = 0 Then
				message += (If(String.IsNullOrEmpty(message), " ", " - ")) & "Chưa Chọn Xe "
			End If
			If sosanh = False AndAlso stt <> 0 Then
				message += (If(String.IsNullOrEmpty(message), " ", " - ")) & "Có Số Lượng Xe Điều Đi Không Đủ "
			End If
			If message = "" Then
				Dim dx As New DTO_DieuXe()
				dx.ma_dieu_xe = txtmadieuxe.Text.Trim()
				dx.ma_khach_hang = Convert.ToString(cbkhachhang.SelectedValue.ToString())
				dx.ngay_ve = dtpngayve.Value
				dx.tttt = Integer.Parse(cbtinhtrangthanhtoan.SelectedValue.ToString())
				dx.ma_hop_dong = cbhopdong.Text.Trim()
				dx.noi_giao = cbnoigiao.Text.Trim()
				dx.noi_nhan = cbnoinhan.Text.Trim()
				dx.ngay_dieu_xe = dtpngaydi.Value
				Dim kq As Boolean = True
				Dim so_tan_con_lai As Single = Single.Parse(txtsotan.Text.Trim())
				While so_tan_con_lai > 0
					For Each item As ListViewItem In lvxe.Items
						If item.Checked Then
							If so_tan_con_lai > Single.Parse(item.SubItems(2).Text) Then
								dx.so_tan = item.SubItems(2).Text
							Else
								dx.so_tan = If((so_tan_con_lai < Single.Parse(item.SubItems(2).Text)), so_tan_con_lai.ToString(), (so_tan_con_lai - Single.Parse(item.SubItems(2).Text)).ToString())
							End If
							so_tan_con_lai = so_tan_con_lai - Single.Parse(item.SubItems(2).Text)
							dx.ma_so_xe = Convert.ToString(item.SubItems(1).Text)
							kq = New BLL_DieuXe().Create_DX(dx)
						End If
						If so_tan_con_lai <= 0 Then
							Exit For
						End If
					Next
				End While
				If kq = False Then
					message = " Lưu Điều Xe Thất Bại "
					MessageBox.Show(message & "!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
				Else
					_list_view_xe()
					_Load_List_View_Dieu_Xe(cbhopdong.Text.Trim())

					txtmadieuxe.Text = New BLL_DieuXe()._Ma_Dieu_Xe_Moi()
				End If
			Else
				MessageBox.Show("Bạn" & message & "!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
			End If
		End Sub
        Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
            If txtmadieuxe.Text.Trim() = New BLL_DieuXe()._Ma_Dieu_Xe_Moi() Then
                _Them_Dieu_Xe()
            Else
                txtmadieuxe.Text = New BLL_DieuXe()._Ma_Dieu_Xe_Moi()
                _Them_Dieu_Xe()
            End If
        End Sub

        Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
            For Each item As ListViewItem In lvthongtindieuxe.Items
                If item.Selected Then
                    Dim kq As DialogResult = MessageBox.Show("Bán Muốn Xóa Mã Điều Xe :" & item.SubItems(9).Text.Trim(), "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If kq = DialogResult.Yes Then
                        Dim dx As New DTO_DieuXe()
                        dx.ma_dieu_xe = item.SubItems(9).Text.Trim()
                        Dim delete As Boolean = New BLL_DieuXe().Delete_Dieu_Xe(dx)
                        If delete = True Then
                            _Load_List_View_Dieu_Xe(cbhopdong.Text.Trim())
                            _list_view_xe()
                        End If
                    End If
                End If
            Next
        End Sub

        Private Sub lvthongtindieuxe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvthongtindieuxe.SelectedIndexChanged
            For Each item As ListViewItem In lvthongtindieuxe.Items
                If item.Selected Then
                    txtmadieuxe.Text = item.SubItems(9).Text.Trim()
                    dtpngaydi.Value = Convert.ToDateTime(item.SubItems(6).Text)
                    If item.SubItems(7).Text.Trim() <> "" Then
                        dtpngayve.Value = Convert.ToDateTime(item.SubItems(7).Text)
                    End If
                    cbtinhtrangthanhtoan.SelectedValue = If(item.SubItems(8).Text.Trim() = "Chưa Thanh Toán", 0, 1)
                    Dim dv As New DTO_DieuXe()
                    dv.ma_dieu_xe = item.SubItems(9).Text.Trim()
                    txtsotan.Text = New BLL_DieuXe()._Get_Tong_Trong_Luong(dv).ToString()
                End If
            Next
        End Sub

        Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
            For Each item As ListViewItem In lvthongtindieuxe.Items
                If item.Selected Then
                    Dim kq As DialogResult = MessageBox.Show("Bán Muốn Sửa Mã Điều Xe : " & item.SubItems(9).Text.Trim() & " - Có Mã Số Xe : " & item.SubItems(1).Text.Trim(), "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If kq = DialogResult.Yes Then
                        Dim message As String = ""
                        If cbkhachhang.Text.Trim() = "" Then
                            message += " Chưa Chọn Khách Hàng "
                        End If
                        If cbhopdong.Text.Trim() = "" Then
                            message += (If(String.IsNullOrEmpty(message), " ", " - ")) & "Chưa Chọn Mã Hợp Đồng "
                        End If
                        If txtmadieuxe.Text.Trim() = "" Then
                            message += (If(String.IsNullOrEmpty(message), " ", " - ")) & "Chưa Có Mã Điều Xe"
                        End If
                        If dtpngayve.Value < dtpngaydi.Value Then
                            message += (If(String.IsNullOrEmpty(message), " ", " - ")) & "Ngày Về Không Hơp Lý.Vui Lòng Kiểm Tra Lại."
                        End If
                        If message = "" Then
                            Dim dx As New DTO_DieuXe()
                            dx.ma_dieu_xe = txtmadieuxe.Text.Trim()
                            dx.ma_khach_hang = Convert.ToString(cbkhachhang.SelectedValue.ToString())
                            dx.ngay_ve = dtpngayve.Value
                            dx.tttt = Integer.Parse(cbtinhtrangthanhtoan.SelectedValue.ToString())
                            dx.ma_hop_dong = cbhopdong.Text.Trim()
                            dx.noi_giao = cbnoigiao.Text.Trim()
                            dx.noi_nhan = cbnoinhan.Text.Trim()
                            dx.so_tan = txtsotan.Text.Trim()
                            dx.ngay_dieu_xe = dtpngaydi.Value
                            dx.ma_so_xe = item.SubItems(1).Text.Trim()
                            Dim update As Boolean = New BLL_DieuXe().Update_Dieu_Xe(dx)
                            If update = True Then
                                _Load_List_View_Dieu_Xe(cbhopdong.Text.Trim())
                                _list_view_xe()
                            End If
                        End If
                        If message <> "" Then
                            MessageBox.Show(message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                End If
            Next
        End Sub

        Private Sub cbbaogia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbaogia.SelectedIndexChanged
            If cbbaogia.Text.Trim() <> "" Then
                Dim bgg As New DTO_BangBaoGia()
                bgg.ma_bao_gia = cbbaogia.Text.Trim()
                _load_cb_noi_nhan(bgg)
            End If
        End Sub

        Private Sub txtsotan_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsotan.KeyDown
            If e.Modifiers = Keys.Control Then

                e.Handled = True

                txtsotan.SelectionLength = 0

            End If
        End Sub
    End Class
End Namespace

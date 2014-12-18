Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports QLDVVTHH.UI
Imports QLDVVTHH.DTO
Imports QLDVVTHH.BLL

Namespace UC
	Public Partial Class uchoadon
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			_combobox_ten_khach_hang()
		End Sub

		Private Sub btnthoat_Click(sender As Object, e As EventArgs)
			For Each mdiChild As Form In Main.ActiveForm.MdiChildren
				If mdiChild.Name = "frmXuatKetQua" Then
					mdiChild.Activate()
					mdiChild.Close()
				End If
			Next
			For Each mdiChild As Form In Main.ActiveForm.MdiChildren
				If mdiChild.Name = "frmInAn" Then
					mdiChild.Activate()
					mdiChild.Close()
				End If
			Next
		End Sub

		Private Sub btnxuat_Click(sender As Object, e As EventArgs)
			For Each mdiChild As Form In Main.ActiveForm.MdiChildren
				If mdiChild.Name = "frmXuatKetQua" Then
					mdiChild.Activate()
					mdiChild.Close()
				End If
			Next
			Dim uc As New frmXuatKetQua()
			uc.strReport = "rpthoadon.rdlc"
			If cbhoadon.Text.Trim() <> "" Then
				Dim dto As New DTO_HoaDon()
				dto.ma_hoa_don = cbhoadon.Text.Trim()
                Dim d = New BLL_INAN()._Luu_Data_Hoa_Don(dto)
			End If
			uc.MdiParent = Main.ActiveForm
			uc.Show()
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
		Private Sub cbhopdong_SelectedIndexChanged(sender As Object, e As EventArgs)
			If cbhopdong.Text.Trim() <> "" Then
				_Load_Combobox_Hoa_Don()
			End If
		End Sub
		Private Sub _Load_Combobox_Hoa_Don()
			Dim hoadon As New DTO_HoaDon()
			hoadon.ma_khach_hang = cbkhachhang.SelectedValue.ToString()
			hoadon.ma_hop_dong = cbhopdong.SelectedValue.ToString()
			cbhoadon.DataSource = New BLL_HoaDon()._List_Hoa_Don(hoadon)
			cbhoadon.DisplayMember = "ma_hoa_don"
			cbhoadon.ValueMember = "ma_hoa_don"
		End Sub

		Private Sub cbkhachhang_SelectedIndexChanged(sender As Object, e As EventArgs)
			If cbkhachhang.Text.Trim() <> "" Then
				_Load_Combobox_Hop_Dong(cbkhachhang.SelectedValue.ToString())
			End If
		End Sub
	End Class
End Namespace

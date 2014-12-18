Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports QLDVVTHH.Common
Imports QLDVVTHH.BLL
Imports QLDVVTHH.DTO
Imports QLDVVTHH.DAL
Imports System.Text.RegularExpressions

Namespace UI
	Public Partial Class frmXe
		Inherits Form
		Private dal_ttx As DAL_Tinhtrangxe = Nothing
		Private dal_xe As DAL_Xe = Nothing
		Public Sub New()
			dal_ttx = New DAL_Tinhtrangxe()
			dal_xe = New DAL_Xe()
			InitializeComponent()
		End Sub
		Private Sub frmXe_Load(sender As Object, e As EventArgs)
			EnableControl(False)

			btn_luu.Enabled = False
			btn_sua.Enabled = False
			btn_xoa.Enabled = False
			Loadcbbttxe()
			BindDataGridView()
		End Sub
		Private Sub BindDataGridView()
			grv_xe.DataSource = dal_xe.GetAll_Xe()
		End Sub
		Private Sub ResetControl()
			txt_ma_so_xe.Text = String.Empty
			txt_nhan_hieu.Text = String.Empty
			txt_trong_luong.Text = String.Empty
			txt_loai_xe.Text = String.Empty
			btn_xoa.Enabled = False
			btn_luu.Enabled = True
			btn_xoa.Enabled = False

			MethodHelper.ClearErrorProvider()
		End Sub
		Private Sub EnableControl(flag As Boolean)
			txt_ma_so_xe.Enabled = flag
			txt_nhan_hieu.Enabled = flag
			txt_trong_luong.Enabled = flag
			txt_loai_xe.Enabled = flag
			cbb_tinh_trang.Enabled = flag
		End Sub
		Private Sub Loadcbbttxe()
			'cbbRoleId.Items.Clear();
			cbb_tinh_trang.DataSource = dal_ttx.GetAll_TTXE()
			cbb_tinh_trang.DisplayMember = "ten_tinh_trang"
			cbb_tinh_trang.ValueMember = "ma_tinh_trang"
		End Sub
		Private Sub btn_them_Click(sender As Object, e As System.EventArgs)
			EnableControl(True)
			ResetControl()

			btn_luu.Enabled = True
			btn_xoa.Enabled = False
			btn_sua.Enabled = False
		End Sub

		Private Sub btn_sua_Click(sender As Object, e As System.EventArgs)
			If txt_ma_so_xe.Text.Length > 0 Then
				EnableControl(True)
				txt_ma_so_xe.Enabled = False
				MethodHelper.ClearErrorProvider()

				'cbbRoleId.Items.Clear();
				btn_luu.Enabled = True
			End If
		End Sub

		Private Sub btn_xoa_Click(sender As Object, e As System.EventArgs)
			If txt_ma_so_xe.Text.Length > 0 Then
				dal_xe.Delete_Xe(txt_ma_so_xe.Text.Trim())
				BindDataGridView()
				ResetControl()

				btn_xoa.Enabled = False
				btn_sua.Enabled = False
			End If
		End Sub

		Private Sub grv_xe_CellClick(sender As Object, e As DataGridViewCellEventArgs)
			Dim i As Integer = e.RowIndex
			If e.RowIndex = 0 Then
				Return
			End If
			Dim xe As DTO_Xe = TryCast(grv_xe.Rows(e.RowIndex).DataBoundItem, DTO_Xe)
			txt_ma_so_xe.Text = Convert.ToString(xe.ma_so_xe)
			txt_loai_xe.Text = xe.loai_xe
			txt_nhan_hieu.Text = xe.nhan_hieu
			txt_trong_luong.Text = Convert.ToString(xe.trong_luong)
			cbb_tinh_trang.SelectedValue = xe.ma_tinh_trang.ToString().Trim()
			EnableControl(False)
			MethodHelper.ClearErrorProvider()

			btn_luu.Enabled = False
			btn_sua.Enabled = True
			btn_xoa.Enabled = True
		End Sub

		Private Sub btn_luu_Click(sender As Object, e As EventArgs)
			If Not CheckBeforeSave() Then
				Return
			End If
			Dim xe As New DTO_Xe()
			xe.ma_so_xe = txt_ma_so_xe.Text
			xe.loai_xe = txt_loai_xe.Text
			xe.nhan_hieu = txt_nhan_hieu.Text
			xe.trong_luong = Convert.ToInt32(txt_trong_luong.Text)
			xe.ma_tinh_trang = Convert.ToInt32(cbb_tinh_trang.SelectedValue)
			xe.ngay_tao = DateTime.Now
			If txt_ma_so_xe.Enabled Then
				dal_xe.Create_Xe(xe)
			Else
				dal_xe.Update_Xe(xe)
			End If
			BindDataGridView()
			ResetControl()
			MethodHelper.ClearErrorProvider()

			btn_xoa.Enabled = False
			btn_sua.Enabled = False

		End Sub
		Private Function CheckBeforeSave() As Boolean
			Dim flag As Boolean = True
			If txt_ma_so_xe.Enabled AndAlso txt_ma_so_xe.Text.Length = 0 Then
				MethodHelper.AddErrorProvider(txt_ma_so_xe, [Const].EMPTY_MESSAGE)
				flag = False
			End If
			If txt_loai_xe.Enabled AndAlso txt_loai_xe.Text.Length = 0 Then
				MethodHelper.AddErrorProvider(txt_loai_xe, [Const].EMPTY_MESSAGE)

				flag = False
			End If
			If Not txt_loai_xe.Enabled AndAlso Not txt_ma_so_xe.Enabled Then
				flag = False
			End If
			Return flag
		End Function
		Private Sub btn_thoat_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub
	End Class
End Namespace

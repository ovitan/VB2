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
	Public Partial Class frmTinhTrangXe
		Inherits Form
		Private dal As DAL_Tinhtrangxe = Nothing
		Public Sub New()
			dal = New DAL_Tinhtrangxe()
			InitializeComponent()
		End Sub

		Private Sub frmTinhTrangXe_Load(sender As Object, e As EventArgs)
			EnableControl(False)
			btn_luu.Enabled = False
			btn_xoa.Enabled = False
			btn_sua.Enabled = False

			BindDataGridView()
		End Sub
		Private Sub BindDataGridView()
			grv_ttxe.DataSource = dal.GetAll_TTXE()
		End Sub

		Private Sub grv_ttxe_CellClick(sender As Object, e As DataGridViewCellEventArgs)
			If e.RowIndex < 0 Then
				Return
			End If
			Dim KH As DTO_TinhTrangXe = TryCast(grv_ttxe.Rows(e.RowIndex).DataBoundItem, DTO_TinhTrangXe)
			txt_matt.Text = KH.ma_tinh_trang
			txt_tentt.Text = KH.ten_tinh_trang
			EnableControl(False)
			MethodHelper.ClearErrorProvider()


			EnableControl(False)
			MethodHelper.ClearErrorProvider()

			btn_luu.Enabled = False
			btn_sua.Enabled = True
			btn_xoa.Enabled = True
		End Sub
		Private Sub EnableControl(flag As Boolean)
			txt_matt.Enabled = flag
			txt_tentt.Enabled = flag
		End Sub
		Private Sub ResetControl()
			txt_matt.Text = String.Empty
			txt_tentt.Text = String.Empty

			btn_luu.Enabled = True
			btn_xoa.Enabled = False
			btn_sua.Enabled = False
			txt_tentt.Focus()
			MethodHelper.ClearErrorProvider()


		End Sub

		Private Sub btn_them_Click(sender As Object, e As System.EventArgs)
			EnableControl(True)
			ResetControl()

			btn_luu.Enabled = True
			btn_xoa.Enabled = False
			btn_sua.Enabled = False

		End Sub

		Private Sub btn_xoa_Click(sender As Object, e As System.EventArgs)
			If txt_matt.Text.Length > 0 Then
				dal.Delete_TTxe(txt_matt.Text.Trim())
				BindDataGridView()
				ResetControl()

				btn_xoa.Enabled = False
				btn_sua.Enabled = False
			End If
		End Sub

		Private Sub btn_sua_Click(sender As Object, e As System.EventArgs)
			If txt_matt.Text.Length > 0 Then
				EnableControl(True)
				txt_matt.Enabled = False
				MethodHelper.ClearErrorProvider()

				'cbbRoleId.Items.Clear();
				btn_luu.Enabled = True
			End If
		End Sub

		Private Sub btn_luu_Click(sender As Object, e As System.EventArgs)
			If Not CheckBeforeSave() Then
				Return
			End If
			Dim TTxe As New DTO_TinhTrangXe()
			TTxe.ma_tinh_trang = txt_matt.Text
			TTxe.ten_tinh_trang = txt_tentt.Text
			If txt_matt.Enabled Then
				dal.Create_TTxe(TTxe)
			Else
				dal.Update_TTxe(TTxe)
			End If
			BindDataGridView()

			ResetControl()


			btn_xoa.Enabled = False
			btn_sua.Enabled = False
		End Sub
		Private Function CheckBeforeSave() As Boolean
			Dim flag As Boolean = True
			If txt_matt.Enabled AndAlso txt_matt.Text.Length = 0 Then
				MethodHelper.AddErrorProvider(txt_matt, [Const].EMPTY_MESSAGE)
				flag = False
			End If
			If txt_tentt.Enabled AndAlso txt_tentt.Text.Length = 0 Then
				MethodHelper.AddErrorProvider(txt_tentt, [Const].EMPTY_MESSAGE)

				flag = False
			End If
			If Not txt_tentt.Enabled AndAlso Not txt_matt.Enabled Then
				flag = False
			End If
			Return flag
		End Function
		Private Sub btn_thoat_Click(sender As Object, e As System.EventArgs)
			Me.Close()
		End Sub
	End Class
End Namespace

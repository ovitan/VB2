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
	Public Partial Class frmDichVu
		Inherits Form
		Private dal_dv As DAL_DichVu = Nothing
		Public Sub New()
			dal_dv = New DAL_DichVu()

			InitializeComponent()
		End Sub

		Private Sub frmDichVu_Load(sender As Object, e As EventArgs)
			EnableControl(False)
			BindDataGridView()
		End Sub
		Private Sub BindDataGridView()
			grv_dichvu.DataSource = dal_dv.GetAll_DV()
		End Sub

		Private Sub EnableControl(flag As Boolean)
			txt_khuvuc.Enabled = flag
			txt_phanvung.Enabled = flag
			txt_dongiachuyen.Enabled = flag
			txt_dongiatan.Enabled = flag
		End Sub
		Private Sub ResetControl()
			txt_phanvung.Text = String.Empty
			txt_khuvuc.Text = String.Empty
			txt_dongiachuyen.Text = String.Empty
			txt_dongiatan.Text = String.Empty
			btn_luu.Enabled = True
			btn_xoa.Enabled = False
			btn_sua.Enabled = False
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
			If txt_khuvuc.Text.Length > 0 Then
				dal_dv.Delete_DV(txt_khuvuc.Text.Trim())
				BindDataGridView()
				ResetControl()

				btn_xoa.Enabled = False
				btn_sua.Enabled = False
			End If
		End Sub

		Private Sub btn_sua_Click(sender As Object, e As System.EventArgs)
			If txt_khuvuc.Text.Length > 0 Then
				EnableControl(True)
				txt_khuvuc.Enabled = False
				txt_phanvung.Enabled = False
				MethodHelper.ClearErrorProvider()

				'cbbRoleId.Items.Clear();
				btn_luu.Enabled = True
			End If
		End Sub

		Private Sub btn_thoat_Click(sender As Object, e As System.EventArgs)
			Me.Close()
		End Sub

		Private Sub btn_luu_Click(sender As Object, e As System.EventArgs)
			If Not CheckBeforeSave() Then
				Return
			End If
			Dim dvu As New DTO_DichVu()
			dvu.khu_vuc = txt_khuvuc.Text
			dvu.phan_vung = txt_phanvung.Text
			dvu.don_gia_tan = Convert.ToInt32(txt_dongiatan.Text)
			dvu.don_gia_chuyen = Convert.ToInt32(txt_dongiachuyen.Text)
			If txt_khuvuc.Enabled Then
				dal_dv.Create_DV(dvu)
			Else
				dal_dv.Update_DVU(dvu)
			End If
			BindDataGridView()

			ResetControl()


			btn_xoa.Enabled = False
			btn_sua.Enabled = False
		End Sub

		Private Sub grv_dichvu_CellClick(sender As Object, e As DataGridViewCellEventArgs)
			If e.RowIndex < 0 Then
				Return
			End If
			Dim DV As DTO_DichVu = TryCast(grv_dichvu.Rows(e.RowIndex).DataBoundItem, DTO_DichVu)
			txt_khuvuc.Text = DV.khu_vuc
			txt_phanvung.Text = DV.phan_vung
			txt_dongiachuyen.Text = Convert.ToString(DV.don_gia_chuyen)
			txt_dongiatan.Text = Convert.ToString(DV.don_gia_tan)
			EnableControl(False)
			MethodHelper.ClearErrorProvider()


			EnableControl(False)
			MethodHelper.ClearErrorProvider()

			btn_luu.Enabled = False
			btn_sua.Enabled = True
			btn_xoa.Enabled = True
		End Sub
		Private Function CheckBeforeSave() As Boolean
			Dim flag As Boolean = True

			If txt_khuvuc.Enabled AndAlso txt_khuvuc.Text.Length = 0 Then
				MethodHelper.AddErrorProvider(txt_khuvuc, [Const].EMPTY_MESSAGE)

				flag = False
			End If
			If txt_phanvung.Enabled AndAlso txt_phanvung.Text.Length = 0 Then
				MethodHelper.AddErrorProvider(txt_phanvung, [Const].EMPTY_MESSAGE)
				flag = False
			End If
			If txt_dongiachuyen.Enabled AndAlso txt_dongiachuyen.Text.Length = 0 Then
				MethodHelper.AddErrorProvider(txt_dongiachuyen, [Const].EMPTY_MESSAGE)
				flag = False
			End If
			If Not txt_khuvuc.Enabled AndAlso Not txt_phanvung.Enabled AndAlso Not txt_dongiachuyen.Enabled Then
				flag = False
			End If
			Return flag
		End Function

		Private Sub grv_dichvu_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

		End Sub

	End Class
End Namespace

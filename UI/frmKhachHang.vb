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
	Public Partial Class frmKhachHang
		Inherits Form
		Private dal As DAL_KhachHang = Nothing
		Public Sub New()
			InitializeComponent()
			dal = New DAL_KhachHang()
		End Sub

		Private Sub frmKhachHang_Load(sender As Object, e As EventArgs)


			EnableControl(False)

			btn_luu.Enabled = False
			btn_sua.Enabled = False
			btn_xoa.Enabled = False
			BindDataGridView()
		End Sub
		Private Sub BindDataGridView()
			grv_khachhang.DataSource = dal.GetAll_KH()
		End Sub

		Private Sub btn_luu_Click(sender As Object, e As EventArgs)
			If Not CheckBeforeSave() Then
				Return
			End If
			Dim kh As New DTO_KhachHang()
			kh.ma_khach_hang = txt_ma_khachhang.Text
			kh.ten_khach_hang = txt_ten_khachhang.Text
			kh.ma_so_thue = Convert.ToString(txt_sothue.Text)
			kh.fax = txt_fax.Text
			kh.dia_chi = txt_diachi.Text
			kh.dien_thoai = txt_dienthoai.Text
			kh.ngay_tao = DateTime.Now
			If txt_ma_khachhang.Enabled Then
				dal.Create_KH(kh)
			Else
				dal.Update_KH(kh)
			End If
			BindDataGridView()

			ResetControl()


			btn_xoa.Enabled = False
			btn_sua.Enabled = False
		End Sub

		Private Sub EnableControl(flag As Boolean)
			txt_ma_khachhang.Enabled = flag
			txt_ten_khachhang.Enabled = flag
			txt_sothue.Enabled = flag
			txt_fax.Enabled = flag
			txt_dienthoai.Enabled = flag
			txt_diachi.Enabled = flag
		End Sub
		Private Sub ResetControl()
			txt_ma_khachhang.Text = String.Empty
			txt_ten_khachhang.Text = String.Empty
			txt_sothue.Text = String.Empty
			txt_diachi.Text = String.Empty
			txt_dienthoai.Text = String.Empty
			txt_fax.Text = String.Empty
			btn_luu.Enabled = True
			btn_xoa.Enabled = False
			btn_sua.Enabled = False
			txt_ten_khachhang.Focus()
			MethodHelper.ClearErrorProvider()


		End Sub

		Private Sub btn_them_Click(sender As Object, e As EventArgs)
			EnableControl(True)
			ResetControl()

			btn_luu.Enabled = True
			btn_xoa.Enabled = False
			btn_sua.Enabled = False
		End Sub

		Private Sub btn_xoa_Click(sender As Object, e As EventArgs)
			If txt_ma_khachhang.Text.Length > 0 Then
				dal.Delete_kh(txt_ma_khachhang.Text.Trim())
				BindDataGridView()
				ResetControl()

				btn_xoa.Enabled = False
				btn_sua.Enabled = False
			End If
		End Sub

		Private Sub btn_sua_Click(sender As Object, e As EventArgs)
			If txt_ma_khachhang.Text.Length > 0 Then
				EnableControl(True)
				txt_ma_khachhang.Enabled = False
				MethodHelper.ClearErrorProvider()

				'cbbRoleId.Items.Clear();
				btn_luu.Enabled = True
			End If
		End Sub


		Private Sub grv_khachhang_CellClick(sender As Object, e As DataGridViewCellEventArgs)
			If e.RowIndex < 0 Then
				Return
			End If
			Dim KH As DTO_KhachHang = TryCast(grv_khachhang.Rows(e.RowIndex).DataBoundItem, DTO_KhachHang)
			txt_ma_khachhang.Text = KH.ma_khach_hang
			txt_ten_khachhang.Text = KH.ten_khach_hang
			txt_sothue.Text = KH.ma_so_thue
			txt_fax.Text = KH.fax
			txt_diachi.Text = KH.dia_chi
			txt_dienthoai.Text = KH.dien_thoai
			EnableControl(False)
			MethodHelper.ClearErrorProvider()

			'if (e.RowIndex < 0)
			'    return;
			'if (e.RowIndex == grv_khachhang.Rows.Count - 1)
			'    return;
			'int i = e.RowIndex;
			'txt_ma_khachhang.Text = grv_khachhang.Rows[i].Cells[0].Value.ToString();
			'txt_ten_khachhang.Text = grv_khachhang.Rows[i].Cells[1].Value.ToString();
			'txt_sothue.Text = grv_khachhang.Rows[i].Cells[2].Value.ToString();
			'txt_diachi.Text = grv_khachhang.Rows[i].Cells[3].Value.ToString();
			'txt_dienthoai.Text = grv_khachhang.Rows[i].Cells[4].Value.ToString();
			'txt_fax.Text = grv_khachhang.Rows[i].Cells[5].Value.ToString();           




			EnableControl(False)
			MethodHelper.ClearErrorProvider()

			btn_luu.Enabled = False
			btn_sua.Enabled = True
			btn_xoa.Enabled = True
		End Sub
		Private Function CheckBeforeSave() As Boolean
			Dim flag As Boolean = True
			If txt_ma_khachhang.Enabled AndAlso txt_ma_khachhang.Text.Length = 0 Then
				MethodHelper.AddErrorProvider(txt_ma_khachhang, [Const].EMPTY_MESSAGE)
				flag = False
			End If
			If txt_ten_khachhang.Enabled AndAlso txt_ten_khachhang.Text.Length = 0 Then
				MethodHelper.AddErrorProvider(txt_ten_khachhang, [Const].EMPTY_MESSAGE)

				flag = False
			End If
			If Not txt_ten_khachhang.Enabled AndAlso Not txt_ma_khachhang.Enabled Then
				flag = False
			End If
			Return flag
		End Function
		Private Sub btn_thoat_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		Private Sub label7_Click(sender As Object, e As EventArgs)

		End Sub

	End Class
End Namespace

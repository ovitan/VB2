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
	Public Partial Class frmNhanVien
		Inherits Form
		Private dal As DAL_NhanVien = Nothing
		Private dalxe As DAL_Xe = Nothing
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub frmNhanVien_Load(sender As Object, e As EventArgs)

			dal = New DAL_NhanVien()
			dalxe = New DAL_Xe()
			grv_nhan_vien.AutoGenerateColumns = False
			EnableControl(False)
			Loadcbbmasoxe()

			btn_luu.Enabled = False
			btn_sua.Enabled = False
			btn_xoa.Enabled = False
			BindDataGridView()
		End Sub
		Private Sub BindDataGridView()
			grv_nhan_vien.DataSource = dal.dt_GetAll()
		End Sub
		Private Sub Loadcbbmasoxe()
			'cbbRoleId.Items.Clear();
			cbb_masoxe.DataSource = dalxe.GetAll_Xe()
			'cbb_tinh_trang.DisplayMember = "ten_tinh_trang";
			cbb_masoxe.ValueMember = "ma_so_xe"
		End Sub
		Private Sub btn_luu_Click(sender As Object, e As EventArgs)
			If Not CheckBeforeSave() Then
				Return
			End If
			Dim nv As New DTO_NhanVien()
			nv.ma_nhan_vien = txt_ma_nhan_vien.Text
			nv.ten_nhan_vien = txt_ten_nhan_vien.Text
			nv.ma_so_xe = Convert.ToString(cbb_masoxe.SelectedValue)
			nv.cmnd = txt_cmnd.Text
			nv.dia_chi = txt_dia_chi.Text
			nv.dien_thoai = txt_dien_thoai.Text
			nv.chucvu = Convert.ToString(cbb_chuc_vu.SelectedItem)
			nv.ngay_tao = DateTime.Now
			nv.nam_sinh = dt_nam_sinh.Value
			If txt_ma_nhan_vien.Enabled Then
				dal.Create_nv(nv)
			Else
				dal.Update_nv(nv)
			End If
			BindDataGridView()
			ResetControl()


			btn_xoa.Enabled = False
			btn_sua.Enabled = False
		End Sub
		Private Sub EnableControl(flag As Boolean)
			txt_ma_nhan_vien.Enabled = flag
			txt_ten_nhan_vien.Enabled = flag
			txt_cmnd.Enabled = flag
			txt_dia_chi.Enabled = flag
			txt_dien_thoai.Enabled = flag
			cbb_chuc_vu.Enabled = flag
			dt_nam_sinh.Enabled = flag
		End Sub

		Private Sub btn_them_Click(sender As Object, e As EventArgs)
			EnableControl(True)
			ResetControl()

			btn_luu.Enabled = True
			btn_xoa.Enabled = False
			btn_sua.Enabled = False
		End Sub
		Private Sub ResetControl()
			txt_ma_nhan_vien.Text = String.Empty
			txt_ten_nhan_vien.Text = String.Empty
			txt_cmnd.Text = String.Empty
			txt_dia_chi.Text = String.Empty
			txt_dien_thoai.Text = String.Empty
			dt_nam_sinh.Value = DateTime.Now
			btn_luu.Enabled = True
			btn_xoa.Enabled = False
			btn_sua.Enabled = False
			txt_ten_nhan_vien.Focus()
			MethodHelper.ClearErrorProvider()
		End Sub

		Private Sub btn_xoa_Click(sender As Object, e As EventArgs)
			If txt_ma_nhan_vien.Text.Length > 0 Then
				dal.Delete_nv(txt_ma_nhan_vien.Text.Trim())
				BindDataGridView()
				ResetControl()

				btn_xoa.Enabled = False
				btn_sua.Enabled = False
			End If
		End Sub
		Private Function CheckBeforeSave() As Boolean
			Dim flag As Boolean = True
			If txt_ma_nhan_vien.Enabled AndAlso txt_ma_nhan_vien.Text.Length = 0 Then
				MethodHelper.AddErrorProvider(txt_ma_nhan_vien, [Const].EMPTY_MESSAGE)
				flag = False
			End If
			If txt_ten_nhan_vien.Enabled AndAlso txt_ten_nhan_vien.Text.Length = 0 Then
				MethodHelper.AddErrorProvider(txt_ten_nhan_vien, [Const].EMPTY_MESSAGE)

				flag = False
			End If
			If Not txt_ten_nhan_vien.Enabled AndAlso Not txt_ma_nhan_vien.Enabled Then
				flag = False
			End If
			Return flag
		End Function

		Private Sub btn_sua_Click(sender As Object, e As EventArgs)
			If txt_ma_nhan_vien.Text.Length > 0 Then
				EnableControl(True)
				txt_ma_nhan_vien.Enabled = False
				MethodHelper.ClearErrorProvider()

				'cbbRoleId.Items.Clear();
				btn_luu.Enabled = True
			End If
		End Sub

		Private Sub grv_nhan_vien_CellClick(sender As Object, e As DataGridViewCellEventArgs)
			Dim i As Integer = e.RowIndex
			If e.RowIndex < 0 Then
				Return
			End If
			'if (e.RowIndex == grv_nhan_vien.Rows.Count-1)
			'    return;
			Dim nhanvien As DTO_NhanVien = TryCast(grv_nhan_vien.Rows(e.RowIndex).DataBoundItem, DTO_NhanVien)

			txt_ma_nhan_vien.Text = nhanvien.ma_nhan_vien
			txt_ten_nhan_vien.Text = nhanvien.ten_nhan_vien
			txt_cmnd.Text = nhanvien.cmnd
			txt_dia_chi.Text = nhanvien.dia_chi
			txt_dien_thoai.Text = nhanvien.dien_thoai
			dt_nam_sinh.Value = Convert.ToDateTime(nhanvien.nam_sinh)
			cbb_chuc_vu.SelectedItem = nhanvien.chucvu.Trim()
			'   cbb_masoxe.SelectedItem = nhanvien.ma_so_xe.Trim();
			cbb_masoxe.Text = grv_nhan_vien.Rows(i).Cells("col_soxe").Value.ToString()
			'cbbMaLoaiTB.Text = dgvDanhSachTB.Rows[curIndex].Cells["colMaLoaiTB"].Value.ToString();
			'int i = e.RowIndex;
			'txt_ma_nhan_vien.Text = grv_nhan_vien.Rows[i].Cells[0].Value.ToString();
			'txt_ten_nhan_vien.Text = grv_nhan_vien.Rows[i].Cells[1].Value.ToString();
			'txt_cmnd.Text = grv_nhan_vien.Rows[i].Cells[2].Value.ToString();
			'txt_dia_chi.Text = grv_nhan_vien.Rows[i].Cells[3].Value.ToString();
			'txt_dien_thoai.Text = grv_nhan_vien.Rows[i].Cells[4].Value.ToString();
			'dt_nam_sinh.Value = Convert.ToDateTime(grv_nhan_vien.Rows[i].Cells[5].Value.ToString());
			'cbb_chuc_vu.SelectedItem = grv_nhan_vien.Rows[i].Cells[6].Value.ToString();



			EnableControl(False)
			MethodHelper.ClearErrorProvider()

			btn_luu.Enabled = False
			btn_sua.Enabled = True
			btn_xoa.Enabled = True
		End Sub

		Private Sub btn_thoat_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		'private void txt_ma_nhan_vien_TextChanged(object sender, EventArgs e)
		'{
		'    if (txt_ma_nhan_vien.Enabled == true)
		'    {
		'        txt_ma_nhan_vien.Text = MethodHelper.GetIdFromName(txt_ma_nhan_vien.Text);
		'    }
		'}
	End Class
End Namespace

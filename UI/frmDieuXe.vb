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
	Public Partial Class frmDieuXe
		Inherits Form
		Private auto1 As New AutoCompleteStringCollection()
		Private auto2 As New AutoCompleteStringCollection()
		Private dal_nv As DAL_NhanVien = Nothing
		Private dal_ttxe As DAL_Tinhtrangxe = Nothing
		Private dal_dx As DAL_DieuXe = Nothing
		Private dal_xe As DAL_Xe = Nothing
		Private dal_kh As DAL_KhachHang = Nothing
		Private dal_hd As DAL_HopDong = Nothing
		Public Sub New()
			dal_nv = New DAL_NhanVien()
			dal_ttxe = New DAL_Tinhtrangxe()
			dal_dx = New DAL_DieuXe()
			dal_xe = New DAL_Xe()
			dal_kh = New DAL_KhachHang()
			dal_hd = New DAL_HopDong()
			InitializeComponent()
			grv_TTxe.AutoGenerateColumns = False
			grv_KH.AutoGenerateColumns = False
			grv_NV.AutoGenerateColumns = False
			grv_dieuxe.AutoGenerateColumns = False
			Loadcbb_soxe()
			Loadkhachhang()
			_load_tinh_trang_thanh_toan()


			EnableControl(False)
			btn_luu.Enabled = False
			btn_sua.Enabled = False
			btn_xoa.Enabled = False

			txt_madieuxe.Text = New BLL_DieuXe()._Ma_Dieu_Xe_Moi()

			Auto_NoiNhan()
			Auto_NoiGiao()
		End Sub

		Private Sub Auto_NoiNhan()
			If New BLL_DieuXe().Get_NoiNhan() IsNot Nothing Then
				For Each dx As DTO_DieuXe In New BLL_DieuXe().Get_NoiNhan()
					auto1.Add(dx.noi_nhan.ToString())
				Next
				txt_noinhan.AutoCompleteMode = AutoCompleteMode.Suggest
				txt_noinhan.AutoCompleteSource = AutoCompleteSource.CustomSource
				txt_noinhan.AutoCompleteCustomSource = auto1
			End If
		End Sub
		Private Sub Auto_NoiGiao()
			If New BLL_DieuXe().Get_NoiGiao() IsNot Nothing Then
				For Each dx As DTO_DieuXe In New BLL_DieuXe().Get_NoiGiao()
					auto2.Add(dx.noi_giao.ToString())
				Next
				txt_noigiao.AutoCompleteMode = AutoCompleteMode.Suggest
				txt_noigiao.AutoCompleteSource = AutoCompleteSource.CustomSource
				txt_noigiao.AutoCompleteCustomSource = auto2
			End If
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
		Private Sub frmDieuXe_Load(sender As Object, e As EventArgs)
			BindDataGridView_TTxe()
			BinbDataGridView_Dieuxe()
		End Sub
		Private Sub BindDataGridView_TTxe()
			grv_TTxe.DataSource = dal_xe.GetAll_Xe_1()
		End Sub
		Private Sub BinbDataGridView_Dieuxe()
			grv_dieuxe.DataSource = dal_dx.GetAll_DX()
		End Sub
		Private Sub Loadkhachhang()
			'cbbRoleId.Items.Clear();
			'cbb_khachhang.DataSource = dal_kh.GetAll_KH();
			'cbb_khachhang.DisplayMember = "ten_khach_hang";
			'cbb_khachhang.ValueMember = "ma_khach_hang";
			Dim kh As New List(Of DTO_KhachHang)()
			Dim groups = dal_kh.GetAll_KH()
            kh.Add(New DTO_KhachHang() With { _
                 .ma_khach_hang = "-1", _
                 .ten_khach_hang = "Chọn tên" _
            })
			kh.AddRange(groups)
			cbb_khachhang.DataSource = kh
			cbb_khachhang.DisplayMember = "ten_khach_hang"
			cbb_khachhang.ValueMember = "ma_khach_hang"
			'cbb_khachhang.SelectedValue = "-1";

		End Sub
		Private Sub Loadcbb_soxe()
			Dim soxe As New List(Of DTO_Xe)()
			Dim groups = dal_xe.GetAll_Xe()
            soxe.Add(New DTO_Xe() With { _
                 .ma_so_xe = "Chọn số xe" _
            })
			soxe.AddRange(groups)
			cbb_soxe.DataSource = soxe
			cbb_soxe.ValueMember = "ma_so_xe"
			'cái mã cũng là cái sô xe
			cbb_soxe.DisplayMember = "ma_so_xe"
			'cbb_soxe.SelectedValue = "-1";
			'cbb_soxe.DataSource = dal_nv.dt_GetAll();
			'cbb_tinh_trang.DisplayMember = "ten_tinh_trang";
			'cbb_soxe.ValueMember = "ma_so_xe";
		End Sub
		Private Sub cbb_soxe_SelectedIndexChanged(sender As Object, e As EventArgs)

			If cbb_soxe.SelectedValue IsNot Nothing Then

				Dim chonsoxe As String = cbb_soxe.SelectedValue.ToString().Trim()
				If cbb_soxe.SelectedIndex = 0 Then
					txt_trongluongxe.Text = ""
					grv_NV.DataSource = dal_nv.dt_GetAll()
				Else
					' int i = cbb_soxe.SelectedIndex;
					grv_NV.DataSource = Nothing
					grv_NV.DataSource = dal_nv.GetAll_NV_ID(chonsoxe)
					Dim dto As New DTO_Xe()
					dto.ma_so_xe = cbb_soxe.SelectedValue.ToString()
					Dim li As List(Of DTO_Xe) = New BLL_DieuXe().Get_TrongLuongXe(dto)
					For Each xe As DTO_Xe In li
						txt_trongluongxe.Text = xe.trong_luong.ToString()
						'txt_trongluongxe.Text = grv_TTxe.Rows[i].Cells["coltrongluong"].Value.ToString();
					Next
				End If
			End If
		End Sub

		Private Sub cbb_khachhang_SelectedIndexChanged(sender As Object, e As EventArgs)
			If cbb_khachhang.SelectedValue IsNot Nothing Then
				Dim chonKH As String = cbb_khachhang.SelectedValue.ToString()
				If cbb_khachhang.SelectedIndex = 0 Then
					grv_KH.DataSource = dal_hd.GetAll_KH_HD_HH()
				Else
					grv_KH.DataSource = dal_hd.GetAll_KH_ID(chonKH)
				End If
			End If
			'MessageBox.Show(cbb_khachhang.SelectedValue.ToString());
		End Sub


		'dieuxe

		Private Sub EnableControl(flag As Boolean)
			txt_madieuxe.Enabled = flag
			cbb_soxe.Enabled = flag
			txt_sotan.Enabled = flag
			txt_noinhan.Enabled = flag
			txt_noigiao.Enabled = flag
			cbb_khachhang.Enabled = flag
			data_ngaydieuxe.Enabled = flag
		End Sub
		Private Sub ResetControl()
			txt_madieuxe.Text = String.Empty
			txt_sotan.Text = String.Empty
			txt_noinhan.Text = String.Empty
			txt_noigiao.Text = String.Empty
			data_ngaydieuxe.Value = DateTime.Now
			btn_luu.Enabled = True
			btn_xoa.Enabled = False
			'btn_sua.Enabled = false;         
			MethodHelper.ClearErrorProvider()
		End Sub

		'private void btn_xoa_Click(object sender, EventArgs e)
		'{
		'    if (txt_madieuxe.Text.Length > 0)
		'    {
		'        dal_dx.Delete_Dxe(txt_madieuxe.Text.Trim());
		'        BinbDataGridView_Dieuxe();
		'        ResetControl();

		'        btn_xoa.Enabled = false;
		'        btn_sua.Enabled = false;
		'    }
		'}
		Private Function CheckBeforeSave() As Boolean
			Dim flag As Boolean = True
			If txt_madieuxe.Enabled AndAlso txt_madieuxe.Text.Length = 0 Then
				MethodHelper.AddErrorProvider(txt_madieuxe, [Const].EMPTY_MESSAGE)
				flag = False
			End If
			If txt_sotan.Enabled AndAlso txt_sotan.Text.Length = 0 Then
				MethodHelper.AddErrorProvider(txt_sotan, [Const].EMPTY_MESSAGE)

				flag = False
			End If
			If Not txt_sotan.Enabled AndAlso Not txt_sotan.Enabled Then
				flag = False
			End If
			Return flag
		End Function
		Private Sub btn_them_Click(sender As Object, e As EventArgs)
			EnableControl(True)
			ResetControl()

			txt_madieuxe.Text = New BLL_DieuXe()._Ma_Dieu_Xe_Moi()
			btn_luu.Enabled = True
			btn_xoa.Enabled = False
			btn_sua.Enabled = False
		End Sub

		Private Sub btn_luu_Click(sender As Object, e As EventArgs)
			If Not CheckBeforeSave() Then
				Return
			End If
			Dim dx As New DTO_DieuXe()
			dx.ma_dieu_xe = txt_madieuxe.Text
			dx.ma_khach_hang = Convert.ToString(cbb_khachhang.SelectedValue.ToString())
			dx.ma_so_xe = Convert.ToString(cbb_soxe.SelectedValue)
			dx.so_tan = txt_sotan.Text
			dx.noi_giao = txt_noigiao.Text
			dx.noi_nhan = txt_noinhan.Text
			dx.ngay_dieu_xe = data_ngaydieuxe.Value
			dx.ngay_ve = dtpngayve.Value
			dx.tttt = Integer.Parse(cbtinhtrangthanhtoan.SelectedValue.ToString())
			If txt_madieuxe.Enabled Then
				dal_dx.Create_DX(dx)
			Else
				dal_dx.Update_DX(dx)
			End If
			BinbDataGridView_Dieuxe()
			If (Integer.Parse(txt_sotan.Text) > Integer.Parse(txt_trongluongxe.Text)) AndAlso (Integer.Parse(txt_sotan.Text) - Integer.Parse(txt_trongluongxe.Text) > 0) Then
				MessageBox.Show("Điều Thêm Xe " & (Integer.Parse(txt_sotan.Text) - Integer.Parse(txt_trongluongxe.Text)).ToString() & " Tấn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
			End If

			ResetControl()


			btn_xoa.Enabled = False
			btn_sua.Enabled = False
		End Sub

		Private Sub btn_sua_Click_1(sender As Object, e As EventArgs)
			If txt_madieuxe.Text.Length > 0 Then
				EnableControl(True)
				txt_madieuxe.Enabled = False
				MethodHelper.ClearErrorProvider()

				'cbbRoleId.Items.Clear();
				btn_luu.Enabled = True
			End If
		End Sub


		Private Sub btn_xoa_Click(sender As Object, e As EventArgs)
			If txt_madieuxe.Text.Length > 0 Then
				dal_dx.Delete_Dxe(txt_madieuxe.Text.Trim())
				BinbDataGridView_Dieuxe()
				ResetControl()

				btn_xoa.Enabled = False
				btn_sua.Enabled = False
			End If
		End Sub

		Private Sub grv_dieuxe_CellClick(sender As Object, e As DataGridViewCellEventArgs)
			Dim i As Integer = e.RowIndex
			If e.RowIndex < 0 Then
				Return
			End If
			'if (e.RowIndex == grv_nhan_vien.Rows.Count-1)
			'    return;
			Dim dieuxe As DTO_DieuXe = TryCast(grv_dieuxe.Rows(e.RowIndex).DataBoundItem, DTO_DieuXe)

			txt_madieuxe.Text = dieuxe.ma_dieu_xe
			txt_noigiao.Text = dieuxe.noi_giao
			txt_noinhan.Text = dieuxe.noi_nhan
			txt_sotan.Text = dieuxe.so_tan
			cbb_khachhang.SelectedValue = dieuxe.ma_khach_hang.Trim()
			'cbb_soxe.SelectedValue = dieuxe.ma_so_xe.Trim();
			cbb_soxe.Text = grv_dieuxe.Rows(i).Cells("col_sx").Value.ToString()
			' cbb_soxe.SelectedIndex = 3;
			' MessageBox.Show(dieuxe.ma_so_xe.Trim());
			data_ngaydieuxe.Value = Convert.ToDateTime(dieuxe.ngay_dieu_xe)
			If grv_dieuxe.Rows(i).Cells("ngay_ve").Value.ToString().Trim() <> "01/01/0001 12:00:00 SA" Then
					'MessageBox.Show(grv_dieuxe.Rows[i].Cells["ngay_ve"].Value.ToString() );
				dtpngayve.Value = Convert.ToDateTime(dieuxe.ngay_ve)
			End If
			

			cbtinhtrangthanhtoan.SelectedValue = If(dieuxe.tinh_trang_thanh_toan = "Chưa Thanh Toán", 0, 1)
			EnableControl(False)
			MethodHelper.ClearErrorProvider()

			btn_luu.Enabled = False
			btn_sua.Enabled = True
			btn_xoa.Enabled = True

		End Sub
		Private Sub btn_thoat_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		Private Sub label8_Click(sender As Object, e As EventArgs)

		End Sub

		Private Sub groupBox4_Enter(sender As Object, e As EventArgs)

		End Sub

		Private Sub label5_Click(sender As Object, e As EventArgs)

		End Sub

		Private Sub grv_TTxe_CellClick(sender As Object, e As DataGridViewCellEventArgs)
			Dim i As Integer = e.RowIndex
			If e.RowIndex < 0 Then
				Return
			End If
			cbb_soxe.Text = grv_TTxe.Rows(i).Cells("Column1").Value.ToString()
		End Sub
	End Class
End Namespace


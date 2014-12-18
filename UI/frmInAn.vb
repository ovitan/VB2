Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports QLDVVTHH.UC
Imports QLDVVTHH.DTO
Imports QLDVVTHH.BLL

Namespace UI
	Public Partial Class frmInAn
		Inherits Form
		Private originalWidth As Integer
		Private originalHeight As Integer
		Public Sub New(rz As DTO_ResizeForm)
			InitializeComponent()
			_Load_Combobox()
			Dim rs As DTO_ResizeForm = rz
			originalHeight = rs.CHIEU_CAO
			originalWidth = rs.CHIEU_DAI
			cbdanhmuc.SelectedValue = rs.Index
			If cbdanhmuc.SelectedValue.ToString() = "0001" Then
				pncontrol.Controls.Clear()
				Dim uc As New uckhachhang()
				pncontrol.Controls.Add(uc)
				Me.Width = 214
				Me.Height = 130

			End If
		End Sub
		Private Sub _Load_Combobox()
			Dim dt As New DataTable()
			dt.Columns.Add("Text")
			dt.Columns.Add("Value")
			Dim row As DataRow = dt.NewRow()
			row("Text") = "In Danh Sách Khách Hàng"
			row("Value") = "0001"
			dt.Rows.InsertAt(row, 0)

			'DataRow row2 = dt.NewRow();
			'row2["Text"] = "In Danh Sách Nhân Viên";
			'row2["Value"] = "0002";
			'dt.Rows.InsertAt(row2, 0);

			'DataRow row3 = dt.NewRow();
			'row3["Text"] = "In Danh Sách Xe ";
			'row3["Value"] = "0003";
			'dt.Rows.InsertAt(row3, 0);

			'DataRow row4 = dt.NewRow();
			'row4["Text"] = "In Hóa Đơn ";
			'row4["Value"] = "0004";
			'dt.Rows.InsertAt(row4, 0);


			cbdanhmuc.DataSource = dt
			cbdanhmuc.DisplayMember = "Text"
			cbdanhmuc.ValueMember = "Value"

			cbdanhmuc.SelectedIndex = 0

		End Sub

		Private Sub cbdanhmuc_SelectedIndexChanged(sender As Object, e As EventArgs)
			If cbdanhmuc.SelectedValue.ToString().Trim() = "0001" Then
				Me.Width = 214
				Me.Height = 130
				pncontrol.Controls.Clear()
				Dim uc As New uckhachhang()
				pncontrol.Controls.Add(uc)
			End If
			'if (cbdanhmuc.SelectedValue.ToString().Trim() == "0002")
			'{
			'    this.Width = 214;
			'    this.Height = 100;
			'    pncontrol.Controls.Clear();
			'    ucnhanvien uc = new ucnhanvien();
			'    pncontrol.Controls.Add(uc);
			'}
			'if (cbdanhmuc.SelectedValue.ToString().Trim() == "0003")
			'{
			'    this.Width = 214;
			'    this.Height = 100;
			'    pncontrol.Controls.Clear();
			'    ucxe uc = new ucxe();
			'    pncontrol.Controls.Add(uc);
			'}
			'if (cbdanhmuc.SelectedValue.ToString().Trim() == "0004")
			'{
			'    this.Width = 214;
			'    this.Height = 250;
			'    pncontrol.Controls.Clear();
			'    uchoadon uc = new uchoadon();
			'    pncontrol.Controls.Add(uc);
			'}
		End Sub
	End Class
End Namespace

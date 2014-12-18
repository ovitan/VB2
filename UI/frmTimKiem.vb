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
Imports QLDVVTHH.UC_TIMKIEM

Namespace UI
	Public Partial Class frmTimKiem
		Inherits Form
		Private originalWidth As Integer
		Private originalHeight As Integer
		Public Sub New(rz As DTO_ResizeForm)
			InitializeComponent()
			_Load_Combobox()
			Dim rs As DTO_ResizeForm = rz
			originalHeight = rs.CHIEU_CAO
				'cbdanhmuc.SelectedValue = rs.Index.ToString();
				'if (cbdanhmuc.SelectedValue.ToString().Trim() == "0005")
				'{
				'    this.Width = 300;
				'    this.Height = 200;
				'    pncontrol.Controls.Clear();
				'    uchopdong uc = new uchopdong();
				'    pncontrol.Controls.Add(uc);
				'}
			originalWidth = rs.CHIEU_DAI
		End Sub

		Private Sub button1_Click(sender As Object, e As EventArgs)
			For Each mdiChild As Form In Main.ActiveForm.MdiChildren
				If mdiChild.Name = "frmTimKetQua" Then
					mdiChild.Activate()
					Return
				End If
			Next
			Dim uc As New frmTimKetQua()
			uc.MdiParent = Main.ActiveForm
			uc.Show()
		End Sub
		Private Sub _Load_Combobox()
			Dim dt As New DataTable()
			dt.Columns.Add("Text")
			dt.Columns.Add("Value")
			Dim row As DataRow = dt.NewRow()
			row("Text") = "Tìm Thông Tin Khách Hàng"
			row("Value") = "0001"
			dt.Rows.InsertAt(row, 0)
			Dim row2 As DataRow = dt.NewRow()
			row2("Text") = "Tìm Thông Tin Nhân Viên"
			row2("Value") = "0002"
			dt.Rows.InsertAt(row2, 0)

			Dim row3 As DataRow = dt.NewRow()
			row3("Text") = "Tìm Thông Tin Xe "
			row3("Value") = "0003"
			dt.Rows.InsertAt(row3, 0)

			Dim row4 As DataRow = dt.NewRow()
			row4("Text") = "Tìm Thông Tin Hóa Đơn "
			row4("Value") = "0004"
			dt.Rows.InsertAt(row4, 0)

			Dim row5 As DataRow = dt.NewRow()
			row5("Text") = "Tìm Thông Tin Hợp Đồng "
			row5("Value") = "0005"
			dt.Rows.InsertAt(row5, 0)


			'cbdanhmuc.DataSource = dt;
			'cbdanhmuc.DisplayMember = "Text";
			'cbdanhmuc.ValueMember = "Value";

			'cbdanhmuc.SelectedIndex = 0;
		End Sub
		Private Sub cbdanhmuc_SelectedIndexChanged(sender As Object, e As EventArgs)
			'if (cbdanhmuc.SelectedValue.ToString().Trim() == "0001")
			'{
			'    this.Width = 300;
			'    this.Height = 250;
			'    pncontrol.Controls.Clear();
			'    uctkhachang uc = new uctkhachang();
			'    pncontrol.Controls.Add(uc);
			'}
			'if (cbdanhmuc.SelectedValue.ToString().Trim() == "0002")
			'{
			'    this.Width = 300;
			'    this.Height = 265;
			'    pncontrol.Controls.Clear();
			'    uctnhanvien uc = new uctnhanvien();
			'    pncontrol.Controls.Add(uc);
			'}
			'if (cbdanhmuc.SelectedValue.ToString().Trim() == "0003")
			'{
			'    this.Width = 300;
			'    this.Height = 200;
			'    pncontrol.Controls.Clear();
			'    uctxe uc = new uctxe();
			'    pncontrol.Controls.Add(uc);
			'}
			'if (cbdanhmuc.SelectedValue.ToString().Trim() == "0004")
			'{
			'    this.Width = 300;
			'    this.Height = 200;
			'    pncontrol.Controls.Clear();
			'    ucthoadon uc = new ucthoadon();
			'    pncontrol.Controls.Add(uc);
			'}
			'if (cbdanhmuc.SelectedValue.ToString().Trim() == "0005")
			'{
			'    this.Width = 300;
			'    this.Height = 200;
			'    pncontrol.Controls.Clear();
			'    uchopdong uc = new uchopdong();
			'    pncontrol.Controls.Add(uc);
			'}
		End Sub
	End Class
End Namespace

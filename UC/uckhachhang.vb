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
	Public Partial Class uckhachhang
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			_Load_DanhSach_TuyChon()
			_Delete_Insert_Database()
		End Sub
		Private Sub _Delete_Insert_Database()
			Dim i As Integer = New BLL_INAN()._Luu_Data_Khach_Hang_Rpt()
		End Sub
		Private Sub _Load_DanhSach_TuyChon()
			Dim dt As New DataTable()
			dt.Columns.Add("Text")
			dt.Columns.Add("Value")

			Dim row As DataRow = dt.NewRow()
			row("Text") = "-->>In Toàn Bộ Khách Hàng"
			row("Value") = "0002"
			dt.Rows.InsertAt(row, 0)

			cbdanhsachtuyechon.DataSource = dt
			cbdanhsachtuyechon.DisplayMember = "Text"
			cbdanhsachtuyechon.ValueMember = "Value"

			cbdanhsachtuyechon.SelectedIndex = 0
		End Sub

		Private Sub btnxuat_Click(sender As Object, e As EventArgs)
			For Each mdiChild As Form In Main.ActiveForm.MdiChildren
				If mdiChild.Name = "frmXuatKetQua" Then
					mdiChild.Activate()
					mdiChild.Close()
				End If
			Next
			Dim uc As New frmXuatKetQua()
			uc.strReport = "rptkhachhang.rdlc"
			uc.MdiParent = Main.ActiveForm
			uc.Show()
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
	End Class
End Namespace

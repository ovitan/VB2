Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports QLDVVTHH.UI
Imports QLDVVTHH.BLL
Imports QLDVVTHH.DTO
Imports QLDVVTHH.UC

Namespace UC
	Public Partial Class ucnhanvien
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
            Dim c = New BLL_INAN()._Luu_Data_Nhan_Vien_Rpt()
		End Sub

		Private Sub btnthoat_Click(sender As Object, e As EventArgs)
			For Each mdiChild As Form In Main.ActiveForm.MdiChildren
				If mdiChild.Name = "frmXuatKetQua" Then
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
			uc.strReport = "rptnhanvien.rdlc"
			uc.MdiParent = Main.ActiveForm
			uc.Show()
		End Sub
	End Class
End Namespace

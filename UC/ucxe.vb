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
	Public Partial Class ucxe
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
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

		Private Sub btnxuat_Click(sender As Object, e As EventArgs)
			For Each mdiChild As Form In Main.ActiveForm.MdiChildren
				If mdiChild.Name = "frmXuatKetQua" Then
					mdiChild.Activate()
					mdiChild.Close()
				End If
			Next
			Dim uc As New frmXuatKetQua()
			uc.strReport = "rptxe.rdlc"
			uc.MdiParent = Main.ActiveForm
			uc.Show()
		End Sub

		Private Sub ucxe_Load(sender As Object, e As EventArgs)
            Dim b = New BLL_INAN()._Luu_Data_Xe_Rpt()
		End Sub
	End Class
End Namespace

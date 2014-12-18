Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports QLDVVTHH.UC_TIMKIEM
Imports QLDVVTHH.BLL
Imports QLDVVTHH.UI
Namespace UC_TIMKIEM
	Public Partial Class uctxe
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub btntruyvan_Click(sender As Object, e As EventArgs)
			For Each mdiChild As Form In Main.ActiveForm.MdiChildren
				If mdiChild.Name = "frmTimKetQua" Then
					mdiChild.Activate()
					mdiChild.Close()
				End If
			Next
			Dim uc As New frmTimKetQua()
			uc._truyvan = "xe"
			uc._Key_id = txtmasoxe.Text.Trim()
			uc.MdiParent = Main.ActiveForm
			uc.Show()
		End Sub

		Private Sub Thoát_Click(sender As Object, e As EventArgs)
			For Each mdiChild As Form In Main.ActiveForm.MdiChildren
				If mdiChild.Name = "frmTimKetQua" Then
					mdiChild.Activate()
					mdiChild.Close()
				End If
			Next
			For Each mdiChild As Form In Main.ActiveForm.MdiChildren
				If mdiChild.Name = "frmTimKiem" Then
					mdiChild.Activate()
					mdiChild.Close()
				End If
			Next
		End Sub

		Private Sub txtmasoxe_KeyPress(sender As Object, e As KeyPressEventArgs)
            If e.KeyChar = Chr(13) Then
                For Each mdiChild As Form In Main.ActiveForm.MdiChildren
                    If mdiChild.Name = "frmTimKetQua" Then
                        mdiChild.Activate()
                        mdiChild.Close()
                    End If
                Next
                Dim uc As New frmTimKetQua()
                uc._truyvan = "xe"
                uc._Key_id = txtmasoxe.Text.Trim()
                uc.MdiParent = Main.ActiveForm
                uc.Show()
            End If
		End Sub
	End Class
End Namespace

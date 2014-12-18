Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace UI
	Public Partial Class frmSaoLuuData
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub btnthoat_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub
	End Class
End Namespace

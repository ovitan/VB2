Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Namespace BLL
	Public Class ListViewNoLag
		Inherits ListView
		Public Sub New()
			MyBase.New()
			Me.DoubleBuffered = True
		End Sub
	End Class
End Namespace

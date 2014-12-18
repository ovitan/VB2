Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace Common
	Public NotInheritable Class [Const]
		Private Sub New()
		End Sub
		Public Const EMPTY_MESSAGE As String = "Không được rỗng"
		Public Const DATE_FORMAT As String = "dd/MM/yyyy"
		Public Const DATE_TIME_FORMAT As String = "dd/MM/yyyy hh:mm:ss"
		Public Const FIRST_CHAR_INPUT As String = "PN-"
		Public Const FIRST_CHAR_BILL As String = "PB-"
		Public Const NUMBER_FORMAT As String = "{0:0,0.00}"
		Public Const EMPTY_FROMAT As String = "........................."
		Public Shared CurrentUser As QLDVVTHH.DTO.DTO_NhanVien = New DTO.DTO_NhanVien()
	End Class
End Namespace

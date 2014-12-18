Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace Common
	Public Class MethodHelper
		#Region "Property"
















		Private Shared ReadOnly VietnameseSigns As String() = New String() {"aAeEoOuUiIdDyY", "áàạảãâấầậẩẫăắằặẳẵ", "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ", "éèẹẻẽêếềệểễ", "ÉÈẸẺẼÊẾỀỆỂỄ", "óòọỏõôốồộổỗơớờợởỡ", _
			"ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ", "úùụủũưứừựửữ", "ÚÙỤỦŨƯỨỪỰỬỮ", "íìịỉĩ", "ÍÌỊỈĨ", "đ", _
			"Đ", "ýỳỵỷỹ", "ÝỲỴỶỸ"}


		Private Shared [error] As New ErrorProvider()

		#End Region

		#Region "Method"
		Public Shared Sub OnlyNumberFloatTextBox(txt As TextBox, e As KeyPressEventArgs)
			If Char.IsDigit(e.KeyChar) Then
				Return
			End If
            If e.KeyChar = CChar(ChrW(Keys.Back)) Then
                Return
            End If
			If e.KeyChar = "."C AndAlso Not TryCast(txt, TextBox).Text.Contains("."C) Then
				Return
			End If
			e.Handled = True
		End Sub
		Public Shared Sub OnlyNumberIntTextBox(txt As TextBox, e As KeyPressEventArgs)
			If Char.IsDigit(e.KeyChar) Then
				Return
			End If
            If e.KeyChar = CChar(ChrW(Keys.Back)) Then
                Return
            End If

			e.Handled = True
		End Sub

		Public Shared Function RemoveUnicode(str As String) As String

			For i As Integer = 1 To VietnameseSigns.Length - 1

				For j As Integer = 0 To VietnameseSigns(i).Length - 1

					str = str.Replace(VietnameseSigns(i)(j), VietnameseSigns(0)(i - 1))

				Next
			Next

			Return str
		End Function

		Public Shared Function GetIdFromName(str As String) As String
			Return RemoveUnicode(str.Replace(" ", "")).ToLower()
		End Function


		Public Shared Sub AddErrorProvider(ctr As Control, value As String)
			[error].SetError(ctr, value)
			[error].SetIconPadding(ctr, -17)
		End Sub

		Public Shared Sub ClearErrorProvider()
			[error].Clear()
		End Sub

		Public Shared Function GetInputId() As String
			Return [Const].FIRST_CHAR_INPUT & DateTime.Now.ToString("yyMMddhhmmssms")
		End Function

		Public Shared Function GetBillId() As String
			Return [Const].FIRST_CHAR_BILL & DateTime.Now.ToString("yyMMddhhmmssms")
		End Function

		#End Region
	End Class
End Namespace

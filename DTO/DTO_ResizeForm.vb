Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace DTO
	Public Class DTO_ResizeForm
		Private _ChieuCao As Integer
		Private _ChieuDai As Integer
		Private _index As String
		Public Property CHIEU_CAO() As Integer
			Get
				Return _ChieuCao
			End Get
			Set
				_ChieuCao = value
			End Set
		End Property
		Public Property CHIEU_DAI() As Integer
			Get
				Return _ChieuDai
			End Get
			Set
				_ChieuDai = value
			End Set
		End Property
		Public Property Index() As String
			Get
				Return _index
			End Get
			Set
				_index = value
			End Set
		End Property
	End Class
End Namespace

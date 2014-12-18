Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace DTO
	Public Class DTO_TinhTrangXe
		Private _ma_tinh_trang As String
		Private _ten_tinh_trang As String

		Public Property ma_tinh_trang() As String
			Get
				Return _ma_tinh_trang
			End Get
			Set
				_ma_tinh_trang = value
			End Set
		End Property
		Public Property ten_tinh_trang() As String
			Get
				Return _ten_tinh_trang
			End Get
			Set
				_ten_tinh_trang = value
			End Set
		End Property
	End Class
End Namespace

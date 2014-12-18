Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace DTO
	Public Class DTO_Chi_Tiet_Hoa_Don
		Private _ma_chi_tiet_hoa_don As Integer
		Private _ma_hoa_don As String
		Private _ma_bang_ke As String
		Private _ma_khach_hang As String
		Public Property ma_khach_hang() As String
			Get
				Return _ma_khach_hang
			End Get
			Set
				_ma_khach_hang = value
			End Set
		End Property
		Public Property ma_chi_tiet_hoa_don() As Integer
			Get
				Return _ma_chi_tiet_hoa_don
			End Get
			Set
				_ma_chi_tiet_hoa_don = value
			End Set
		End Property
		Public Property ma_hoa_don() As String
			Get
				Return _ma_hoa_don
			End Get
			Set
				_ma_hoa_don = value
			End Set
		End Property
		Public Property ma_bang_ke() As String
			Get
				Return _ma_bang_ke
			End Get
			Set
				_ma_bang_ke = value
			End Set
		End Property
	End Class
End Namespace

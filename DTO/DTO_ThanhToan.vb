Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace DTO
	Public Class DTO_ThanhToan
		Private _ma_thanh_toan As Integer
		Private _ma_khach_hang As String
		Private _ngay_thanh_toan As DateTime
		Private _so_tien_thanh_toan As Single
		Private _ma_hop_dong As String
		Public Property ma_hop_dong() As String
			Get
				Return _ma_hop_dong
			End Get
			Set
				_ma_hop_dong = value
			End Set
		End Property
		Public Property ma_thanh_toan() As Integer
			Get
				Return _ma_thanh_toan
			End Get
			Set
				_ma_thanh_toan = value
			End Set
		End Property
		Public Property ma_khach_hang() As String
			Get
				Return _ma_khach_hang
			End Get
			Set
				_ma_khach_hang = value
			End Set
		End Property
		Public Property ngay_thanh_toan() As DateTime
			Get
				Return _ngay_thanh_toan
			End Get
			Set
				_ngay_thanh_toan = value
			End Set
		End Property
		Public Property so_tien_thanh_toan() As Single
			Get
				Return _so_tien_thanh_toan
			End Get
			Set
				_so_tien_thanh_toan = value
			End Set
		End Property
	End Class
End Namespace

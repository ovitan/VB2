Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace DTO
	Public Class DTO_CongNo
		Private _ma_cong_no As String
		Private _ma_khach_hang As String
		Private _ngay_xuat_hd As DateTime
		Private _ma_hoa_don As String
		Private _so_tien_thanh_toan As Single
		Private _tenkhachhang As String
		Private _tongno As Single
		Private _tongtra As Single
		Private _con_lai As Single
		Private _ma_hd As String

		Public Property ma_khach_hang() As String
			Get
				Return _ma_khach_hang
			End Get
			Set
				_ma_khach_hang = value
			End Set
		End Property
		Public Property ma_cong_no() As String
			Get
				Return _ma_cong_no
			End Get
			Set
				_ma_cong_no = value
			End Set
		End Property
		Public Property ngay_xuat_hd() As DateTime
			Get
				Return _ngay_xuat_hd
			End Get
			Set
				_ngay_xuat_hd = value
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
		Public Property so_tien_thanh_toan() As Single
			Get
				Return _so_tien_thanh_toan
			End Get
			Set
				_so_tien_thanh_toan = value
			End Set
		End Property

		Public Property tenkhachhang() As String
			Get
				Return _tenkhachhang
			End Get
			Set
				_tenkhachhang = value
			End Set
		End Property
		Public Property tongno() As Single
			Get
				Return _tongno
			End Get
			Set
				_tongno = value
			End Set
		End Property
		Public Property tongtra() As Single
			Get
				Return _tongtra
			End Get
			Set
				_tongtra = value
			End Set
		End Property
		Public Property so_tien_con_lai() As Single
			Get
				Return _con_lai
			End Get
			Set
				_con_lai = value
			End Set
		End Property

		Public Property ma_hop_dong() As String
			Get
				Return _ma_hd
			End Get
			Set
				_ma_hd = value
			End Set
		End Property
	End Class
End Namespace

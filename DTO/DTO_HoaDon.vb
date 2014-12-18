Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace DTO
	Public Class DTO_HoaDon
		Private _ma_hoa_don As String
		Private _ma_khach_hang As String
		Private _ma_hop_dong As String
		Private _khoi_luong As Single
		Private _tong_cuot_van_chuyen As Single
		Private _ngay_xuat_hoa_don As DateTime
		Private _thue As Single
		Private _tong_cong As Single
		Private _tenkhachhang As String
		Public Property tenkhachhang() As String
			Get
				Return _tenkhachhang
			End Get
			Set
				_tenkhachhang = value
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
		Public Property ma_khach_hang() As String
			Get
				Return _ma_khach_hang
			End Get
			Set
				_ma_khach_hang = value
			End Set
		End Property
		Public Property ngay_Xuat_hoa_don() As DateTime
			Get
				Return _ngay_xuat_hoa_don
			End Get
			Set
				_ngay_xuat_hoa_don = value
			End Set
		End Property
		Public Property ma_hop_dong() As String
			Get
				Return _ma_hop_dong
			End Get
			Set
				_ma_hop_dong = value
			End Set
		End Property
		Public Property tong_khoi_luong() As Single
			Get
				Return _khoi_luong
			End Get
			Set
				_khoi_luong = value
			End Set
		End Property
		Public Property tong_cuot_van_chuyen() As Single
			Get
				Return _tong_cuot_van_chuyen
			End Get
			Set
				_tong_cuot_van_chuyen = value
			End Set
		End Property
		Public Property theu() As Single
			Get
				Return _thue
			End Get
			Set
				_thue = value
			End Set
		End Property
		Public Property tong_cong() As Single
			Get
				Return _tong_cong
			End Get
			Set
				_tong_cong = value
			End Set
		End Property
	End Class
End Namespace

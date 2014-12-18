Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace DTO
	Public Class DTO_HopDong
		Private _ma_hop_dong As String
		Private _ma_khach_hang As String
		Private _ngay_tao As DateTime
		Private _ngay_bat_dau As DateTime
		Private _ngay_ket_thuc As DateTime
		Private _ten_khach_hang As String
		Private _loaihanghoa As String
		Private _lotrinhvanchuyen As String
		Private _phuongthucvanchuyen As String
		Private _giatrihopdong As String
		Private _phuongthucthanhtoan As String

		Public Property ma_hop_dong() As String
			Get
				Return _ma_hop_dong
			End Get
			Set
				_ma_hop_dong = value
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
		Public Property ngay_tao() As DateTime
			Get
				Return _ngay_tao
			End Get
			Set
				_ngay_tao = value
			End Set
		End Property
		Public Property ngay_bat_dau() As DateTime
			Get
				Return _ngay_bat_dau
			End Get
			Set
				_ngay_bat_dau = value
			End Set
		End Property
		Public Property ngay_ket_thuc() As DateTime
			Get
				Return _ngay_ket_thuc
			End Get
			Set
				_ngay_ket_thuc = value
			End Set
		End Property
		Public Property ten_khach_hang() As String
			Get
				Return _ten_khach_hang
			End Get
			Set
				_ten_khach_hang = value
			End Set
		End Property

		Public Property loaihanghoa() As String
			Get
				Return _loaihanghoa
			End Get
			Set
				_loaihanghoa = value
			End Set
		End Property
		Public Property lotrinhvanchuyen() As String
			Get
				Return _lotrinhvanchuyen
			End Get
			Set
				_lotrinhvanchuyen = value
			End Set
		End Property
		Public Property phuongthucvanchuyen() As String
			Get
				Return _phuongthucvanchuyen
			End Get
			Set
				_phuongthucvanchuyen = value
			End Set
		End Property
		Public Property giatrihopdong() As String
			Get
				Return _giatrihopdong
			End Get
			Set
				_giatrihopdong = value
			End Set
		End Property
		Public Property phuongthucthanhtoan() As String
			Get
				Return _phuongthucthanhtoan
			End Get
			Set
				_phuongthucthanhtoan = value
			End Set
		End Property
	End Class
End Namespace

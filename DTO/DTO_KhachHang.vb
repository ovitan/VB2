Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace DTO
	Public Class DTO_KhachHang
		Private _ma_khach_hang As String
		Private _ten_khach_hang As String
		Private _ma_so_thue As String
		Private _dia_chi As String
		Private _dien_thoai As String
		Private _fax As String
		Private _ngay_tao As DateTime

		Public Property ma_khach_hang() As String
			Get
				Return _ma_khach_hang
			End Get
			Set
				_ma_khach_hang = value
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
		Public Property ma_so_thue() As String
			Get
				Return _ma_so_thue
			End Get
			Set
				_ma_so_thue = value
			End Set
		End Property
		Public Property dia_chi() As String
			Get
				Return _dia_chi
			End Get
			Set
				_dia_chi = value
			End Set
		End Property
		Public Property dien_thoai() As String
			Get
				Return _dien_thoai
			End Get
			Set
				_dien_thoai = value
			End Set
		End Property
		Public Property fax() As String
			Get
				Return _fax
			End Get
			Set
				_fax = value
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
	End Class
End Namespace

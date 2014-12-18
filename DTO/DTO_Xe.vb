Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace DTO
	Public Class DTO_Xe
		Private _ma_so_xe As String
		Private _trong_luong As Single
		Private _loai_xe As String
		Private _nhan_hieu As String
		Private _ma_tinh_trang As Integer
		Private _ten_tinh_trang As String
		Private _ngay_tao As DateTime

		Public Property ma_so_xe() As String
			Get
				Return _ma_so_xe
			End Get
			Set
				_ma_so_xe = value
			End Set
		End Property
		Public Property trong_luong() As Single
			Get
				Return _trong_luong
			End Get
			Set
				_trong_luong = value
			End Set
		End Property
		Public Property loai_xe() As String
			Get
				Return _loai_xe
			End Get
			Set
				_loai_xe = value
			End Set
		End Property
		Public Property nhan_hieu() As String
			Get
				Return _nhan_hieu
			End Get
			Set
				_nhan_hieu = value
			End Set
		End Property
		Public Property ma_tinh_trang() As Integer
			Get
				Return _ma_tinh_trang
			End Get
			Set
				_ma_tinh_trang = value
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
